using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Falcon f1 = new Falcon();
            f1.kind = "Falcon";
            f1.speed = 75;
            f1.name = "Sam";
            f1.weight = 25.5;
            f1.gotvoice();

            Crown c1 = new Crown();
            c1.kind = "Crown";
            c1.speed = 50;
            c1.name = "Bradley";
            c1.weight = 30.7;
            c1.gotvoice();

            Console.WriteLine("Falcon Values");
            Console.WriteLine(f1.kind);
            Console.WriteLine(f1.speed);
            Console.WriteLine(f1.name);
            Console.WriteLine(f1.weight);
            Console.WriteLine(f1.gotvoice());
            Console.WriteLine();
            Console.WriteLine("Crown Values");
            Console.WriteLine(c1.kind);
            Console.WriteLine(c1.speed);
            Console.WriteLine(c1.name);
            Console.WriteLine(c1.weight);
            Console.WriteLine(c1.gotvoice());
            Console.Read();
        }
    }
}