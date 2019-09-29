namespace PerformanceBiller.Models
{
    public class InvoiceData
    {
        public InvoiceData(Customer customer, PerformanceCollection performaces)
        {
            Customer = customer;
            Performances = performaces;
        }

        public Customer Customer { get; private set; }
        public PerformanceCollection Performances { get; private set; }
    }
}
