using PerformanceBiller.Models;

namespace PerformanceBiller.Reporting
{
    public interface IInvoiceReporter
    {
        void GenerateReportFor(Invoice invoice);
    }
}
