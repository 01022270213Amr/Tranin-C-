using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print
            //string m = "Hello World!";


            //Console.WriteLine(Alfa(m));
            //Console.WriteLine(40 * 30);

            Console.WriteLine(Alfa(Convert.ToString(320.00.ToString("N2"))));
            Console.WriteLine(Alfa(Convert.ToString(320.00)));
            Console.WriteLine(DateTime.Now.ToLongDateString());

            //Console.WriteLine(Alfa(Convert.ToString(320.54)));

            //Console.WriteLine(Alfa(Convert.ToString(320.00.ToString("C"))));

        }

        static string Alfa(string s) 
        {
            return s;
        }
    }
}
