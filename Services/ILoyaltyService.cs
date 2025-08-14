using Models.loyalty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ILoyaltyService
    {
        Task<Dictionary<int, LoyaltyDTO>> Get();
    }
}
