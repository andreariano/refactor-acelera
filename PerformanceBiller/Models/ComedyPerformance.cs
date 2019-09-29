namespace PerformanceBiller.Models
{
    public class ComedyPerformance : Performace<ComedyPlay>
    {
        private const int NumberOfAtendeesForExtraVolumeCredits = 5;

        private const decimal FixedPricePerPerson = 300;

        private const decimal FixedPriceAboveThreshold = 10000;

        protected override decimal FixedMinimumPrice => 30000;

        protected override decimal PricePerPersonAboveThreshold => 500;

        protected override int AudienceThreshold => 20;

        public ComedyPerformance(ComedyPlay play, int audience) : base(play, audience)
        {
        }

        protected override decimal CalculatePerformaceSpecific()
        {
            return FixedPricePerPerson * Audience;
        }

        protected override int CalculatePerformanceSpecificVolumeCredits()
        {
            return Audience / NumberOfAtendeesForExtraVolumeCredits;
        }

        protected override decimal PriceAboveAudienceThreshold()
        {
            if (Audience <= AudienceThreshold)
                return 0;

            return (Audience - AudienceThreshold) * PricePerPersonAboveThreshold + FixedPriceAboveThreshold;
        }
    }
}
