using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Dependencyinversion.ViolatePrinciple
{
    internal class WeatherTracker
    {
        string CurrentConditions;
        Emailer _emailer;
        public WeatherTracker()
        { 
            _emailer = new Emailer();
        }
        public void SetCurrentConditions(string weatherDescription)
        {
            CurrentConditions = weatherDescription;
            if (CurrentConditions == "Hot")
                _emailer.SendEmail("It Is Hot");
        }
    }
}
