using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Dependencyinversion.ApplyPrinciple
{
    internal class Emailer : INotifer
    {
        public void AlertweatherConditions(string weatherDescription)
        {
            Console.WriteLine(weatherDescription);
        }
    }
}
