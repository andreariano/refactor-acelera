using System.Collections.Generic;

namespace PerformanceBiller.Models
{
    public class Invoice
    {
        public Customer Customer { get; set; }

        public IList<Performance> Performances { get; set; }
    }
}
