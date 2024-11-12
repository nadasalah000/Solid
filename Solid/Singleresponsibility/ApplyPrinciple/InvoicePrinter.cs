using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Singleresponsibility.ApplyPrinciple
{
    public class InvoicePrinter
    {
        private Invoice _invoice;
        public InvoicePrinter(Invoice invoice)
        {
        _invoice = invoice;
        }
        public void PrintInvoice()
        {
            Console.WriteLine($"BookName : {_invoice.Book.Name} - BookPrice : {_invoice.Book.Price} - Quantity : {_invoice.Quanitity} - Discount : {_invoice.DiscountRate} - Total : {_invoice.Total}");
        }
    }
}
