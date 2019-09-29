using PerformanceBiller.Reporting;
using PerformanceBiller.Repositories;
using System.Linq;

namespace PerformanceBiller.Models
{
    public class Invoice
    {
        private readonly IInvoiceRepository _invoiceRepository;

        private readonly IInvoiceReporter _invoiceReporter;

        public InvoiceData InvoiceData { get; private set; }

        public decimal PerformancesTotal { get; private set; }

        public decimal VolumeCreditsTotal { get; private set; }

        public Invoice(IInvoiceRepository invoiceRepository, IInvoiceReporter invoiceReporter)
        {
            this._invoiceRepository = invoiceRepository;
            this._invoiceReporter = invoiceReporter;
        }

        public Invoice FecthPerformancesData()
        {
            InvoiceData = _invoiceRepository.GetInvoiceData();

            return this;
        }

        public Invoice CalculatePerformancesTotal()
        {
            PerformancesTotal = InvoiceData.Performances.Sum(x => x.CalculatePerformace());

            return this;
        }

        public Invoice CalculateVolumeCredits()
        {
            VolumeCreditsTotal = InvoiceData.Performances.Sum(x => x.CalculateVolumeCredits());

            return this;
        }

        public IInvoiceReporter GenerateInvoiceReport()
        {
            _invoiceReporter.GenerateReportFor(this);

            return _invoiceReporter;
        }
    }
}
