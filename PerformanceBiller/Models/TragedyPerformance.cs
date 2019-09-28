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

        public override decimal CalculatePerformace()
        {
            return FixedMinimumPrice + PriceAboveAudienceThreshold();
        }
    }
}
