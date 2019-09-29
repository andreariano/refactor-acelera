using System;

namespace PerformanceBiller.Models
{
    public abstract class Performace<T> : IPerformace<IPlay>
    {
        protected const int AudienceThresholdForVolumeCredit = 30;

        protected abstract decimal FixedMinimumPrice { get; }

        protected abstract decimal PricePerPersonAboveThreshold { get; }

        protected abstract int AudienceThreshold { get; }

        public IPlay Play { get; private set; }

        public int Audience { get; private set; }

        public decimal PerformaceTotal { get; private set; }

        protected Performace(IPlay play, int audience)
        {
            Play = play;
            Audience = audience;
        }

        protected abstract decimal PriceAboveAudienceThreshold();

        protected abstract int CalculatePerformanceSpecificVolumeCredits();

        protected abstract decimal CalculatePerformaceSpecific();

        public decimal CalculatePerformace()
        {
            PerformaceTotal = 
                (FixedMinimumPrice +
                PriceAboveAudienceThreshold() + 
                CalculatePerformaceSpecific()) / 100;

            return PerformaceTotal;
        }

        public int CalculateVolumeCredits()
        {
            return 
                Math.Max(Audience - AudienceThresholdForVolumeCredit, 0) + 
                CalculatePerformanceSpecificVolumeCredits();
        }
    }
}
