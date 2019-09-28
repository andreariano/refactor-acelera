using System.Collections;
using System.Collections.Generic;

namespace PerformanceBiller.Models
{
    public class PerformanceCollection: IEnumerable<Performace<Play>>
    {
        private IList<Performace<Play>> _performances;

        public decimal PerformancesTotal { get; private set; }

        public PerformanceCollection()
        {
            _performances = new List<Performace<Play>>();
        }

        public void AddPerformance(Performace<Play> performace)
        {
            _performances.Add(performace);
        }

        public IEnumerator<Performace<Play>> GetEnumerator()
        {
            return _performances.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _performances.GetEnumerator();
        }
    }
}
