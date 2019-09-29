using System;

namespace PerformanceBiller.Models
{
    public abstract class Performace<T> : IPerformace<IPlay>
    {
        protected const int AudienceThresholdForVolumeCredit = 30;

        protected abstract decimal FixedMinimumPrice { get; }

        protected abstract decimal PricePerPersonAboveThreshold { get; }

        protected abstract int AudienceThreshold { get; }

        public T Play { get; private set; }

        public int Audience { get; private set; }

        protected Performace(T play, int audience)
        {
            Play = play;
            Audience = audience;
        }

        protected abstract decimal PriceAboveAudienceThreshold();

        protected abstract int CalculatePerformanceSpecificVolumeCredits();

        protected abstract decimal CalculatePerformaceSpecific();

        public decimal CalculatePerformace()
        {
            return
                (FixedMinimumPrice +
                PriceAboveAudienceThreshold() + 
                CalculatePerformaceSpecific()) / 100;
        }

        public virtual int CalculateVolumeCredits()
        {
            return 
                Math.Max(Audience - AudienceThresholdForVolumeCredit, 0) + 
                CalculatePerformanceSpecificVolumeCredits();
        }
    }
}
