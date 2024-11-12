using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Openclosed.ApplyPrinciple
{
    public class DatabasePresistance : IInvoicePresistance
    {
        private Invoice _invoic;
        public DatabasePresistance(Invoice invoice)
        {
            _invoic = invoice;
        }
        public void Save(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
