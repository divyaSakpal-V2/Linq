using Models.SeasonalSale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISeasonalSalesService
    {
        Task<Dictionary<int, SeasonalSalesDTO>> Get(int topN);
    }
}
