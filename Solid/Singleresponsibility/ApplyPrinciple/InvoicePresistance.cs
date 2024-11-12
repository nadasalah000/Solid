using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Singleresponsibility.ApplyPrinciple
{
    internal class InvoicePresistance
    {
        private Invoice _invoice;
        public InvoicePresistance(Invoice invoice)
        {
            _invoice = invoice;
        }
        public void SaveToFile(string filename)
        {
            Console.WriteLine();
        }
    }
}
