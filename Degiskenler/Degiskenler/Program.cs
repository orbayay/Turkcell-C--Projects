using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool durum;
            durum = true;
            Console.WriteLine("Öğrenci Sınavı Geçti Mi? : " + durum);

            bool üyemi;
            Console.Write("Kullanıcı sisteme üye mi? : ");
            üyemi = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Kullanıcının sistem üyelik durumu : "+üyemi);
            Console.Read();
        }
    }
}