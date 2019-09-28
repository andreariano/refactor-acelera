using PerformanceBiller.Infra;

namespace PerformanceBiller.Billing
{
    public class PerformanceStatement
    {
        private IInvoiceRepository _invoiceRepository;

        public PerformanceStatement(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public void CalculateInvoice()
        {
            var invoice = _invoiceRepository.GetInvoice();

            invoice
                .CalculatePerformancesTotal()
                .CalculateVolumeCredits();
        }
    }
}
