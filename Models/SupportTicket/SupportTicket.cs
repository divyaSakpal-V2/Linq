using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SupportTicket
{
    public class SupportTicket
    {
       public SupportTicket(string category, DateTime datetime)
        {
            Category = category;
            Date = datetime;
        }
        public string Category {  get; set; }
        public DateTime Date { get; set; }
    }
}
