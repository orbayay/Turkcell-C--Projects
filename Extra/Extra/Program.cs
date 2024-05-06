using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fault Managment - Try Catch

            try
            {
                Console.WriteLine("Please enter a int value : ");
                int n1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please enter a int value : ");
                int n2 = Convert.ToInt16(Console.ReadLine());
                int multiple1 = n1 * n2;
                Console.WriteLine("Result : " + multiple1);
            }
            catch (Exception)
            {
                Console.WriteLine("Mistakeeee!!!!!!!!");
            }
            finally
            {
                Console.WriteLine("This place is worked :)");
            }

            Console.Read();
        }
    }
}