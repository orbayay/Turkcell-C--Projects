using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        public static int average1(int exam1, int exam2)
        {
            int result = (exam1 + exam2) / 2;
            return result;
        }
        public static double average1(int exam1, int exam2, int exam3)
        {
            double  result = (exam1 + exam2 + exam3) / 3;
            return result;
        }

        static void Main(string[] args)
        {
            //Overload
            Console.WriteLine("Your Average Result On 2 Exams : "+average1(100,35));
            Console.WriteLine("Your Average Result On 3 Exams : " + average1(97, 38, 65));
            Console.Read();
        }
    }
}