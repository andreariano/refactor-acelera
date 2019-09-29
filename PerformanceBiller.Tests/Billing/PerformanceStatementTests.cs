using PerformanceBiller.Billing;
using PerformanceBiller.Infra.Reporting;
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
            var reporter = new StringBuilderInvoiceReporter();

            _performanceStatement = new PerformanceStatement(repository, reporter);
        }

        [Fact]
        public void CalculateInvoice()
        {
            var expectedOutput = "Statement for BigCo\n" +
                " Hamlet: $650.00 (55 seats)\n" +
                " As You Like It: $580.00 (35 seats)\n" +
                " Othello: $500.00 (40 seats)\n" +
                "Amount owed is $1,730.00\n" +
                "You earned 47 credits\n";

            _performanceStatement.CalculateInvoice();
            var actualResult = _performanceStatement.InvoiceReporter.ToString();

            Assert.Equal(expectedOutput, actualResult);
        }
    }
}
