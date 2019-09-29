using PerformanceBiller.Models;
using PerformanceBiller.Repositories;

namespace PerformanceBiller.Infra.Repositories
{
    public class InMemoryInvoiceRepository : IInvoiceRepository
    {
        public InvoiceData GetInvoiceData()
        {
            var hamletPlay = new TragedyPlay("Hamlet");
            var asLikePlay = new ComedyPlay("As You Like It");
            var othelloPlay = new TragedyPlay("Othello");

            var hamletPerformance = new TragedyPerformance(hamletPlay, 55);
            var asLikePerformance = new ComedyPerformance(asLikePlay, 35);
            var othelloPerformance = new TragedyPerformance(othelloPlay, 40);

            var performanceCollection = new PerformanceCollection(new IPerformace<IPlay>[] { 
                hamletPerformance, 
                asLikePerformance, 
                othelloPerformance 
            });

            return new InvoiceData(new Customer("BigCo"), performanceCollection);
        }
    }
}
