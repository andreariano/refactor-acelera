using PerformanceBiller.Models;
using PerformanceBiller.Reporting;
using System;
using System.Globalization;
using System.Text;

namespace PerformanceBiller.Infra.Reporting
{
    public class StringBuilderInvoiceReporter : IInvoiceReporter
    {
        private StringBuilder reportStringBuilder;

        public void GenerateReportFor(Invoice invoice)
        {
            reportStringBuilder = new StringBuilder();
            var cultureInfo = new CultureInfo("en-US");

            reportStringBuilder.Append($"Statement for {invoice.InvoiceData.Customer.Name}\n");

            foreach (var performance in invoice.InvoiceData.Performances)
            {
                reportStringBuilder.Append($" {performance.Play.Name}: {performance.PerformaceTotal.ToString("C", cultureInfo)} ({performance.Audience} seats)\n");
            }

            reportStringBuilder.Append($"Amount owed is {invoice.PerformancesTotal.ToString("C", cultureInfo)}\n");
            reportStringBuilder.Append($"You earned {invoice.VolumeCreditsTotal} credits\n");
        }

        public override string ToString()
        {
            return reportStringBuilder.ToString();
        }
    }
}
