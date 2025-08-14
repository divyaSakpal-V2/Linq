using Models.SeasonalSale;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositorySeasonalSales
    {
        Task<Dictionary<int, SeasonalSalesDTO>> Get(int topN);
    }
}
