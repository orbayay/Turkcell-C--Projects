using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Değişkenler ile Switch-Case Uygulaması");
            Console.WriteLine();
            string mevsim;
            Console.Write("Please enter a season in Turkish: ");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "yaz":Console.WriteLine("Haziran - Temmuz - Ağustos"); break;
                case "kış":Console.WriteLine("Aralık-Ocak-Şubat");break;
                case "ilkbahar":Console.WriteLine("Mart-Nisan-Mayıs");break;
                case "sonbahar":Console.WriteLine("Eylül-Ekim-Kasım");break;
                default:Console.WriteLine("Wrong Entry Dude");break;
            }
            Console.ReadLine();
        }
    }
}