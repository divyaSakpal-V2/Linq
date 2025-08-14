using Models.SeasonalSale;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class SeasonalSalesService : ISeasonalSalesService
    {
        readonly IRepositorySeasonalSales _repository;
        public SeasonalSalesService(IRepositorySeasonalSales repository) {
            _repository=repository;
        }
        public async Task<Dictionary<int, SeasonalSalesDTO>> Get(int topN)
        {
            return await _repository.Get(topN);
        }
    }
}
