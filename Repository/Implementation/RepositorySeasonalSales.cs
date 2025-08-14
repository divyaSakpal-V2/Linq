using Models.SeasonalSale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class RepositorySeasonalSales : IRepositorySeasonalSales
    {
        public readonly List<Sale> MonthlySales;
        public readonly List<Season> SeasonsMaster;
        public RepositorySeasonalSales()
        {
            SeasonsMaster = new List<Season>()
            {
                new Season()
                {
                    SeasonName = "Spring",
                   Months = new List<int>(){3,4,5}
                },
                 new Season()
                {
                    SeasonName = "Summer",
                   Months = new List<int>(){6,7,8}
                },
                  new Season()
                {
                    SeasonName = "Autumn",
                   Months = new List<int>(){9,10,11}
                },
                   new Season()
                {
                    SeasonName = "Winter",
                   Months = new List<int>(){12,1,2}
                },
            };
                   MonthlySales =
        [
            // Sales data from January to September 2023
            // January 2023
            new Sale { ProductName = "Laptop", QuantitySold = 65, SaleDate = new DateTime(2023, 01, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 55, SaleDate = new DateTime(2023, 01, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 30, SaleDate = new DateTime(2023, 01, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 20, SaleDate = new DateTime(2023, 01, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 15, SaleDate = new DateTime(2023, 01, 01) },
 
            // February 2023
            new Sale { ProductName = "Laptop", QuantitySold = 70, SaleDate = new DateTime(2023, 02, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 45, SaleDate = new DateTime(2023, 02, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 25, SaleDate = new DateTime(2023, 02, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 25, SaleDate = new DateTime(2023, 02, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 14, SaleDate = new DateTime(2023, 02, 01) },
 
            // March 2023
            new Sale { ProductName = "Laptop", QuantitySold = 55, SaleDate = new DateTime(2023, 03, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 60, SaleDate = new DateTime(2023, 03, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 40, SaleDate = new DateTime(2023, 03, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 30, SaleDate = new DateTime(2023, 03, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 12, SaleDate = new DateTime(2023, 03, 01) },
 
            // April 2023
            new Sale { ProductName = "Laptop", QuantitySold = 75, SaleDate = new DateTime(2023, 04, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 50, SaleDate = new DateTime(2023, 04, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 35, SaleDate = new DateTime(2023, 04, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 35, SaleDate = new DateTime(2023, 04, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 10, SaleDate = new DateTime(2023, 04, 01) },
 
            // May 2023
            new Sale { ProductName = "Laptop", QuantitySold = 80, SaleDate = new DateTime(2023, 05, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 70, SaleDate = new DateTime(2023, 05, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 45, SaleDate = new DateTime(2023, 05, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 40, SaleDate = new DateTime(2023, 05, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 9, SaleDate = new DateTime(2023, 05, 01) },
 
            // June 2023
            new Sale { ProductName = "Laptop", QuantitySold = 85, SaleDate = new DateTime(2023, 06, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 65, SaleDate = new DateTime(2023, 06, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 50, SaleDate = new DateTime(2023, 06, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 45, SaleDate = new DateTime(2023, 06, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 8, SaleDate = new DateTime(2023, 06, 01) },
 
            // July 2023
            new Sale { ProductName = "Laptop", QuantitySold = 90, SaleDate = new DateTime(2023, 07, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 75, SaleDate = new DateTime(2023, 07, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 55, SaleDate = new DateTime(2023, 07, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 50, SaleDate = new DateTime(2023, 07, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 7, SaleDate = new DateTime(2023, 07, 01) },
 
            // August 2023
            new Sale { ProductName = "Laptop", QuantitySold = 95, SaleDate = new DateTime(2023, 08, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 80, SaleDate = new DateTime(2023, 08, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 60, SaleDate = new DateTime(2023, 08, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 55, SaleDate = new DateTime(2023, 08, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 6, SaleDate = new DateTime(2023, 08, 01) },
 
            // September 2023
            new Sale { ProductName = "Laptop", QuantitySold = 100, SaleDate = new DateTime(2023, 09, 01) },
            new Sale { ProductName = "Smartphone", QuantitySold = 85, SaleDate = new DateTime(2023, 09, 01) },
            new Sale { ProductName = "Tablet", QuantitySold = 65, SaleDate = new DateTime(2023, 09, 01) },
            new Sale { ProductName = "Headphones", QuantitySold = 60, SaleDate = new DateTime(2023, 09, 01) },
            new Sale { ProductName = "Watch", QuantitySold = 5, SaleDate = new DateTime(2023, 09, 01) }
        ];
    }

        public async Task<Dictionary<int, SeasonalSalesDTO>> Get(int topN)
        {
            var result = MonthlySales.GroupBy(x => x.SaleDate.Year).Select(yrwise => (yrwise.Key, new SeasonalSalesDTO()
            {seasonalSales = yrwise.GroupBy(x=> SeasonsMaster.Find(s=>s.Months.Contains( x.SaleDate.Month)).SeasonName)
            .Select(seasonwise=> new SeasonalSales()
            {
               SeasonName= seasonwise.Key,
               sales= seasonwise.GroupBy(p=>p.ProductName).Select(prdwise=> new ProductSale()
               {
                   ProductName= prdwise.Key,
                   TotalQuantitySold= prdwise.Sum(q=>q.QuantitySold)
               }).OrderByDescending(p=> p.TotalQuantitySold).Take(topN).ToList()
            } ).ToList()


            })).ToDictionary();
           return result;
        }
    }
}
