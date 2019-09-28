using System;

namespace PerformanceBiller.Models
{
    public abstract class Performace<T> where T : Play
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

        public abstract decimal CalculatePerformace();

        protected decimal PriceAboveAudienceThreshold()
        {
            if (Audience <= AudienceThreshold)
                return 0;

            return (Audience - AudienceThreshold) * PricePerPersonAboveThreshold;
        }

        public virtual int CalculateVolumeCredits()
        {
            return Math.Max(Audience - AudienceThresholdForVolumeCredit, 0);
        }
    }
}
