using PerformanceBiller.Reporting;
using PerformanceBiller.Repositories;
using System.Linq;

namespace PerformanceBiller.Models
{
    public class Invoice
    {
        public InvoiceData InvoiceData { get; private set; }

        internal decimal PerformancesTotal { get; private set; }

        internal decimal VolumeCreditsTotal { get; private set; }

        public Invoice FecthPerformancesDataFrom(IInvoiceRepository invoiceRepository)
        {
            InvoiceData = invoiceRepository.GetInvoiceData();

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

        public Invoice GenerateInvoiceReportWith(IInvoiceReporter invoiceReporter)
        {
            return this;
        }
    }
}
