using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.loyalty
{
    public class Purchase
    {
        public string CustomerId { get; set; }
        public int Amount { get; set; }
        public DateTime PurchaseDate {  get; set; }

    }
}
