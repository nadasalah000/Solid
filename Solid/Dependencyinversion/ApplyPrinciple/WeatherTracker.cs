using Solid.Dependencyinversion.ViolatePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Dependencyinversion.ApplyPrinciple
{
    internal class WeatherTracker
    {
        string CurrentConditions;
        INotifer _notifer;
        public WeatherTracker(INotifer notifer)
        {
            _notifer = notifer;
        }
        public void SetCurrentConditions(string weatherDescription)
        {
            CurrentConditions = weatherDescription;
            if (CurrentConditions == "Hot")
                _notifer.AlertweatherConditions("It Is Hot");
        }
    }
}
