using Models.SupportTicket;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class SupportTicketService : ISupportTicketService
    {
        IRepositorySupportTicket _repository;
        public SupportTicketService(IRepositorySupportTicket repository ) {
            _repository = repository;
        }
      
        public async Task<Dictionary<int, SupportTicketAnalysisDTO>> Get()
        {
            return await _repository.get();
        }
    }
}
