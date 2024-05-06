using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Turkcell201_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw1 = new StreamWriter("C:\\Users\\user\\Masaüstü\\example.txt");
            Console.WriteLine("Enter value into Example.txt from here : ");
            string value = Console.ReadLine();
            sw1.Write(value);
            sw1.Close();

            FileStream fs1 = new FileStream("C:\\Users\\user\\Masaüstü\\example.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs1);
            string road = sr1.ReadLine();
            while (road != null)
            {
                Console.WriteLine(road);
                road = sr1.ReadLine();
            }
            sr1.Close();
            fs1.Close();
            Console.Read();
        }
    }
}
