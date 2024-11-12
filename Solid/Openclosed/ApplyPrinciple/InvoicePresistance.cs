using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Openclosed.ApplyPrinciple
{
    public class InvoicePresistance:IInvoicePresistance
    {
        private Invoice _invoice;
        public InvoicePresistance(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Save(Invoice invoice)
        {
            Console.WriteLine();       
        }
    }
}
