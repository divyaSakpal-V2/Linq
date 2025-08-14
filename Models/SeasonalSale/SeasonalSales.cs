using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SeasonalSale
{
    public class SeasonalSales
    {
        public string SeasonName {  get; set; }
         public List<ProductSale> sales { get; set; }

    }
}
