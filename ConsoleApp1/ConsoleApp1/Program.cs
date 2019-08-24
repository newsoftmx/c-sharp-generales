using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            string line;
            n1 = 10;
            Console.WriteLine("Hola " + n1);

            Console.Clear();
            line = Console.ReadLine();
            n2 = int.Parse( Console.ReadLine());
            Console.WriteLine(n2);
            DateTime dat = DateTime.Now;

            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
            //print("Hola");
        }
    }
}
