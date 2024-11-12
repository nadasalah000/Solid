using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Liskov_Substitution.ViolatePrinciple
{
    public class Bicycle : IBike
    {
        bool isEngineOn;
        int speed;
        public void Speed()
        {
            speed += 10; 
        }

        public void TurnOnboolEngineOn()
        {
            throw new Exception("There Is No Engine");
        }
    }
}
