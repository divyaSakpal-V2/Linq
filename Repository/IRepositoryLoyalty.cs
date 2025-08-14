using Models.loyalty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryLoyalty
    {
        Task<Dictionary<int, LoyaltyDTO>> Get();
    }
}
