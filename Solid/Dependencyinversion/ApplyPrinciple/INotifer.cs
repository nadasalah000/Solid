using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Dependencyinversion.ApplyPrinciple
{
    internal interface INotifer
    {
        void AlertweatherConditions(string weatherDescription);
    }
}
