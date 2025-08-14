using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.loyalty
{
    public class Tier
    {
        public required string TierName { get; set; }
        public int min { get; set; }
    }
}
