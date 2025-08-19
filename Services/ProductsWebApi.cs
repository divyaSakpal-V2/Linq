using Models.Partner;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ProductsWebApi
    {
        [Get("/products")]
        Task<List<Product>> GetProductsAsync( int limit);
    }
}
