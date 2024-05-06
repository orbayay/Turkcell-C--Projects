using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Captcha Example
            int n1, n2, n3, n4, n5;
            Random rand1 = new Random();
            n1 = rand1.Next(0, 10);
            n2 = rand1.Next(0, 10);
            n3 = rand1.Next(0, 10);
            n4 = rand1.Next(0, 10);
            n5 = rand1.Next(0, 10);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            string[] character = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
            Console.WriteLine(n1 + character[n2] + n3 + character[n4]);
            Console.Read();
        }
    }
}