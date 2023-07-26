using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonalCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal credit payment plan is calculated.");
        }

        public void DoSomething()
        {
            
        }
    }
}
