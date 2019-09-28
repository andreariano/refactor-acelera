using System.Linq;

namespace PerformanceBiller.Models
{
    public class Invoice
    {
        public Customer Customer { get; set; }

        public PerformanceCollection Performances { get; set; }

        public decimal PerformancesTotal { get; private set; }

        public decimal VolumeCreditsTotal { get; private set; }

        public Invoice CalculatePerformancesTotal()
        {
            PerformancesTotal = Performances.Sum(x => x.CalculatePerformace());

            return this;
        }

        public Invoice CalculateVolumeCredits()
        {
            VolumeCreditsTotal = Performances.Sum(x => x.CalculateVolumeCredits());

            return this;
        }
    }
}
