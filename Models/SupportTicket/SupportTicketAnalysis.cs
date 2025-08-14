using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SupportTicket
{
    public class SupportTicketAnalysis
    {
        public string Category {  get; set; }
        public int Occurance { get; set; }
        public Boolean  Critical { get; set; }
    }
}
