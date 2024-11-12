using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Openclosed.ApplyPrinciple
{
    public interface IInvoicePresistance
    {
        void Save(Invoice invoice);
    }
}
