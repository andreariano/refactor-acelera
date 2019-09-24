using PerformanceBiller.Models;

namespace PerformanceBiller.Infra
{
    public interface IInvoiceRepository
    {
        Invoice GetInvoice();
    }
}
