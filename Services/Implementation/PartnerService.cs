using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Models.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class PartnerService : IPartnerService
    {
        readonly IMemoryCache _memoryCache;
        readonly ProductsWebApi _productsWebApi;
        readonly IConfiguration _configuration;

        public PartnerService(ProductsWebApi productsWebApi, IMemoryCache memoryCache, IConfiguration configuration)
        {
            _productsWebApi = productsWebApi;
            _memoryCache = memoryCache;
            _configuration = configuration;
        }
        public async Task<List<Product>> GetProductsAsync(int limit)
        {
            List<Product> products = null;
            int count = 0;
            try
            {
                _memoryCache.TryGetValue<int>("Count", out count);
                if (limit!=0 && count != 0 && count >= limit)
                {
                    _memoryCache.TryGetValue<List<Product>>("Product", out products);
                    products = products.Take(limit).ToList();
                }
                else
                { /*Using Refit*/
                    products = await UsingRefitHttpClient(limit);
                    if (products != null)
                    {
                        _memoryCache.Set<List<Product>>("Product", products);
                        var cacheTime = Convert.ToDouble(_configuration.GetSection("ProductPartnerIntegration:cacheTime").Value);
                        _memoryCache.Set<int>("Count", products.Count, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(cacheTime)
                        });
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return products;
        }
        /*Refit http client method*/
        public async Task<List<Product>> UsingRefitHttpClient(int limit)
        {
            return await _productsWebApi.GetProductsAsync(limit);
        }

        /*Traditional way to call httpclient */
        public async Task<List<Product>> UsingHttpCLientFactory(int limit)
        {
            using (var client = new HttpClient())
            {
                var clienturl = "";
                if (!string.IsNullOrEmpty(clienturl) && clienturl.Contains("{limit}") && limit > 0)
                {
                    clienturl = clienturl.Replace("{limit}", limit.ToString());
                }
                client.BaseAddress = new Uri(clienturl);
                var response = client.GetAsync("");
                response.Result.EnsureSuccessStatusCode();
                var Jsonstring = await response.Result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Product>>(Jsonstring, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}
