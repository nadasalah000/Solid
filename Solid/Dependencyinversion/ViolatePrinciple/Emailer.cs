﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Dependencyinversion.ViolatePrinciple
{
    public class Emailer
    {
        public void SendEmail(string message)
        {
            Console.WriteLine(message);

        }
    }
}
