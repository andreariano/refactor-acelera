namespace PerformanceBiller.Models
{
    public class ComedyPerformance : Performace<ComedyPlay>
    {
        private const int NumberOfAtendeesForExtraVolumeCredits = 5;

        protected override decimal FixedMinimumPrice => 30000;

        protected override decimal PricePerPersonAboveThreshold => 10500;

        protected override int AudienceThreshold => 20;

        private decimal FixedPricePerPerson => 300;

        public ComedyPerformance(ComedyPlay play, int audience) : base(play, audience)
        {
        }

        public override decimal CalculatePerformace()
        {
            return
                FixedMinimumPrice +
                PriceAboveAudienceThreshold() +
                FixedPricePerPerson * Audience;
        }

        public override int CalculateVolumeCredits()
        {
            return 
                base.CalculateVolumeCredits() + 
                Audience / NumberOfAtendeesForExtraVolumeCredits;
        }
    }
}
