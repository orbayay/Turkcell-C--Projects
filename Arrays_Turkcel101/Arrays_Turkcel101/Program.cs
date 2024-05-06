using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Turkcel101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziye Klavyeden Değer Girişi");
            Console.WriteLine();
            //int[] numbers1 = {21, 39, 69, 54, 20, 33, 6};
            string[] cities = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Please Enter a City : ");
                cities[i] = Console.ReadLine();
            }
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine(cities[j]);
            }
            Console.Read();
        }
    }
}