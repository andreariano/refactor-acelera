using System.Collections;
using System.Collections.Generic;

namespace PerformanceBiller.Models
{
    public class PerformanceCollection: IEnumerable<IPerformace<IPlay>>
    {
        private IList<IPerformace<IPlay>> _performances;

        public decimal PerformancesTotal { get; private set; }

        public PerformanceCollection()
        {
            _performances = new List<IPerformace<IPlay>>();
        }

        public PerformanceCollection(IEnumerable<IPerformace<IPlay>> performaces)
        {
            _performances = new List<IPerformace<IPlay>>(performaces);
        }

        public void AddPerformance(IPerformace<IPlay> performace)
        {
            _performances.Add(performace);
        }

        public IEnumerator<IPerformace<IPlay>> GetEnumerator()
        {
            return _performances.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _performances.GetEnumerator();
        }
    }
}
