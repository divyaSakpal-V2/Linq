using Models.SupportTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class RepositorySupportTicket : IRepositorySupportTicket
    {
        public readonly List<SupportTicket> MonthlySupportTickets;
        public RepositorySupportTicket()
        {


            MonthlySupportTickets =
                    [
                       // Flattened support ticket data from January to March 2023
                       // January 2023
                       new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 01, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 01, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 01, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 01, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 01, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 01, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 01, 01)),
                        new SupportTicket("Payment Issues", new DateTime(2023, 01, 01)),
                        new SupportTicket("Payment Issues", new DateTime(2023, 01, 01)),
                        new SupportTicket("Payment Issues", new DateTime(2023, 01, 01)),
                        new SupportTicket("Customer Service", new DateTime(2023, 01, 01)),
                        new SupportTicket("Customer Service", new DateTime(2023, 01, 01)),
                        // February 2023
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 02, 01)),
                        new SupportTicket("Payment Issues", new DateTime(2023, 02, 01)),
                        new SupportTicket("Customer Service", new DateTime(2023, 02, 01)),
                        // March 2023
                        new SupportTicket("Delivery Delays", new DateTime(2023, 03, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 03, 01)),
                        new SupportTicket("Delivery Delays", new DateTime(2023, 03, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 03, 01)),
                        new SupportTicket("Product Quality", new DateTime(2023, 03, 01)),
                        new SupportTicket("Payment Issues", new DateTime(2023, 03, 01)),
                        new SupportTicket("Customer Service", new DateTime(2023, 03, 01))
                    ];
        }
        public async Task<Dictionary<int, SupportTicketAnalysisDTO>> get()
        {
           
          var Result  = MonthlySupportTickets.GroupBy(x => x.Date.Year)
                .Select(yrwise => (yrwise.Key,
                new SupportTicketAnalysisDTO()
                {
                    supportTicketAnalyses = yrwise.GroupBy(x => x.Category)
                        .Select(categorywise => new SupportTicketAnalysis()
                        {
                            Occurance = categorywise.Select(x => x).Count(),
                            Category = categorywise.Key,
                            Critical = (categorywise.GroupBy(m => m.Date.Month).All(monthwise => monthwise.Count() > 9))
                        }).ToList(),

                })).ToDictionary();
            return  Result;
        }
    }
}
