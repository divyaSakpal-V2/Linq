using Models.loyalty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class RepositoryLoyalty : IRepositoryLoyalty
    {
        readonly List<Purchase> Purchases;
        readonly List<Tier> TierMaster;
        public RepositoryLoyalty()
        {
            TierMaster = new List<Tier>()
            {
                new Tier()
                {
                    TierName = "Platinum",
                    min = 12
                },
                 new Tier()
                {
                    TierName = "Gold",
                    min = 6
                },
                  new Tier()
                {
                    TierName = "Silver",
                    min = 1
                }

            };
            Purchases =
      [
          new Purchase { CustomerId = "C001", Amount = 1500, PurchaseDate = new DateTime(2023, 01, 15) },
                   new Purchase { CustomerId = "C002", Amount = 2500, PurchaseDate = new DateTime(2023, 02, 20) },
                   new Purchase { CustomerId = "C001", Amount = 3000, PurchaseDate = new DateTime(2023, 03, 05) },
                   new Purchase { CustomerId = "C003", Amount = 700, PurchaseDate = new DateTime(2023, 04, 25) },
                   new Purchase { CustomerId = "C002", Amount = 5500, PurchaseDate = new DateTime(2023, 05, 15) },
                   new Purchase { CustomerId = "C001", Amount = 3200, PurchaseDate = new DateTime(2023, 06, 10) },
                   new Purchase { CustomerId = "C003", Amount = 1000, PurchaseDate = new DateTime(2023, 07, 22) },
                   new Purchase { CustomerId = "C004", Amount = 400, PurchaseDate = new DateTime(2023, 08, 30) }
      ];
        }

        public async Task<Dictionary<int, LoyaltyDTO>> Get()
        {
            var result = Purchases.GroupBy(y => y.PurchaseDate.Year).Select(yrwise => (yrwise.Key, new LoyaltyDTO()
            {
                loyaltyList = yrwise.GroupBy(c=>c.CustomerId)
                   .Select(custwise=> new Loyalty()
                   {
                       customerId= custwise.Key,
                       loyaltyTier= (TierMaster.OrderByDescending(m=>m.min)).First(z=> z.min <= (custwise.Count()) ).TierName
                   }).ToList(),     
            })).ToDictionary();

            return result;
        }
    }
}
