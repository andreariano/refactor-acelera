namespace PerformanceBiller.Models
{
    public class TragedyPerformance : Performace<TragedyPlay>
    {
        public TragedyPerformance(TragedyPlay play, int audience) : base(play, audience)
        {
        }

        protected override decimal FixedMinimumPrice => 40000;

        protected override decimal PricePerPersonAboveThreshold => 1000;

        protected override int AudienceThreshold => 30;

        protected override decimal CalculatePerformaceSpecific()
        {
            return 0;
        }

        protected override int CalculatePerformanceSpecificVolumeCredits()
        {
            return 0;
        }

        protected override decimal PriceAboveAudienceThreshold()
        {
            if (Audience <= AudienceThreshold)
                return 0;

            return (Audience - AudienceThreshold) * PricePerPersonAboveThreshold;
        }
    }
}
