using Models.SupportTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface  ISupportTicketService
    {
        Task<Dictionary<int, SupportTicketAnalysisDTO>> Get();
    }
}
