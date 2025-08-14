using Models.loyalty;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class LoyaltyService : ILoyaltyService
    {
        readonly IRepositoryLoyalty _repository; 
        public LoyaltyService(IRepositoryLoyalty repository) {
            _repository = repository;
        }
        public async Task<Dictionary<int, LoyaltyDTO>> Get()
        {
            return await _repository.Get();
        }
    }
}
