using PerformanceBiller.Models;

namespace PerformanceBiller.Repositories
{
    public interface IInvoiceRepository
    {
        InvoiceData GetInvoiceData();
    }
}
