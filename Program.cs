using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print
            string m = "Hello World!";
            Console.WriteLine(Alfa(m));
            Console.WriteLine(40 * 30);
            Console.WriteLine(Alfa(Convert.ToString(320.54)));
            Console.WriteLine(Alfa(Convert.ToString(320.00.ToString("C"))));
            Console.WriteLine(Alfa(Convert.ToString(320.00.ToString("N2"))));
            Console.WriteLine(Alfa(Convert.ToString(320.00)));
            Console.WriteLine(DateTime.Now.ToLongDateString());

            //C# Type Casting
            //Explicit Casting
            //Explicit casting must be done manually by placing the type in parentheses in front of the value:
            double x = 4.00;
            int y = (int)x;

            //Type Conversion Methods
            //It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean,
            //Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long):
            //Case one
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            //Case Two
            string u = "30";
            string d = "60";

            Console.WriteLine(int.Parse(u));
            Console.WriteLine(int.Parse(d));

            //Get User Input
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //Short Hand If...Else(Ternary Operator)
            Console.Write("Entr your age : ");
            int age = int.Parse(Console.ReadLine());
            string result = (age > 16) ? "Done" : "Feald";
            Console.Write(result);
        }

        static string Alfa(string s) 
        {
            return s;
        }
    }
}
