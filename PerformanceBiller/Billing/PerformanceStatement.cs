using PerformanceBiller.Models;
using PerformanceBiller.Reporting;
using PerformanceBiller.Repositories;

namespace PerformanceBiller.Billing
{
    public class PerformanceStatement
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceReporter _invoiceReporter;

        public PerformanceStatement(IInvoiceRepository invoiceRepository, IInvoiceReporter invoiceReporter)
        {
            _invoiceRepository = invoiceRepository;
            _invoiceReporter = invoiceReporter;
        }

        public void CalculateInvoice()
        {
            var invoice = new Invoice();

            invoice
                .FecthPerformancesDataFrom(_invoiceRepository)
                .CalculatePerformancesTotal()
                .CalculateVolumeCredits();
        }
    }
}
