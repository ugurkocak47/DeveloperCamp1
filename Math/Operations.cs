using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Operations
    {
        public void Add(int sayi1, int sayi2)
        {
            int addition = sayi1 + sayi2;
            Console.WriteLine(sayi1.ToString() + " + " + sayi2.ToString() + " = " + addition.ToString());
        }
    }
}
