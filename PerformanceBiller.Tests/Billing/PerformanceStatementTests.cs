using PerformanceBiller.Billing;
using PerformanceBiller.Infra.Repositories;
using Xunit;

namespace PerformanceBiller.Tests.Billing
{
    public class PerformanceStatementTests
    {
        private PerformanceStatement _performanceStatement;

        public PerformanceStatementTests()
        {
            var repository = new InMemoryInvoiceRepository();
            _performanceStatement = new PerformanceStatement(repository);
        }

        [Fact]
        public void CalculateInvoice()
        {
            _performanceStatement.CalculateInvoice();
        }
    }
}
