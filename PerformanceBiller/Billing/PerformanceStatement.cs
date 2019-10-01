using PerformanceBiller.Models;
using PerformanceBiller.Reporting;
using PerformanceBiller.Repositories;

namespace PerformanceBiller.Billing
{
    public class PerformanceStatement
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IInvoiceReporter _invoiceReporter;

        public PerformanceStatement(IInvoiceRepository invoiceRepository, IInvoiceReporter invoiceReporter)
        {
            _invoiceRepository = invoiceRepository;
            _invoiceReporter = invoiceReporter;
        }

        public IInvoiceReporter InvoiceReporter { get => _invoiceReporter; }

        public void CalculateInvoice()
        {
            var invoice = new Invoice(_invoiceRepository, _invoiceReporter);

            invoice
                .FecthPerformancesData()
                .CalculatePerformancesTotal()
                .CalculateVolumeCredits()
                .GenerateInvoiceReport();
        }
    }
}
