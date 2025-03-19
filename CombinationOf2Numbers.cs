using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningen_OOP
{
    internal class CombinationOf2Numbers
    {
        public int Number1;
        public int Number2;

        public static double Sum(int a, int b) {return a + b;}
        public static double Difference(int a, int b) {return a - b;}
        public static double Product(int a, int b) { return a * b; }
        public static double Quotient(int a, int b) { return a / b; }
    
        public static void Demo()
        {
            CombinationOf2Numbers pair = new CombinationOf2Numbers();
            pair.Number1 = 12;
            pair.Number2 = 34;
            Console.WriteLine("Paar:" + pair.Number1 + ", " + pair.Number2);
            Console.WriteLine("Som = " + pair.Sum());
            Console.WriteLine("Verschil = " + pair.Difference());
            Console.WriteLine("Product = " + pair.Product());
            Console.WriteLine("Quotient = " + pair.Quotient());
        }
    }
}
