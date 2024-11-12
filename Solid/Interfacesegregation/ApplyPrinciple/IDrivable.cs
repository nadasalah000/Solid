using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interfacesegregation.ApplyPrinciple
{
    internal interface IDrivable
    {
        void StartEngine();
        void StopEngine();
        void Drive();
    }
}
