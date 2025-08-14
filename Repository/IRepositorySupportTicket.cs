using Models.SupportTicket;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositorySupportTicket
    {
        Task<Dictionary<int, SupportTicketAnalysisDTO>> get();
    }
}
