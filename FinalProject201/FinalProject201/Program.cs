using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumprice = 0;
            int booknumber1;
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***                 Turkish Books                 ***                 English Books                 ***");
            Console.WriteLine();
            Console.WriteLine("***  1-Yaprak Dökümü: Reşat Nuri Gültekin         ***      7-Percy Jackson: Rick Riordan            ***");
            Console.WriteLine();
            Console.WriteLine("***  2-Yaban: Yakup Kadri                         ***      8-A North Adventure: Jack London         ***");
            Console.WriteLine();
            Console.WriteLine("***  3-Tutunamayanlar: Oğuz Atay                  ***      9-Losers: Arsen Wenger                   ***");
            Console.WriteLine();
            Console.WriteLine("***  4-Gazi Paşam: Cevat Şenol                    ***      10-Brave New World: Aldous Huxley        ***");
            Console.WriteLine();
            Console.WriteLine("***  5-Kukla: Ahmet Ümit                          ***      11-Gambler: Dostoyevski                  ***");
            Console.WriteLine();
            Console.WriteLine("***  6-Tehlikeli Oyunlar: Oğuz Atay               ***      12-Doctor Sleep: Stephen King            ***");
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Ask The Price");
            Console.WriteLine("2-New Reader Save");
            Console.WriteLine("3-Book of Today");
            Console.WriteLine("4-Book Archieve");
            Console.WriteLine("5-Buy a New Book");
            Console.WriteLine("6-Game");
            Console.WriteLine();
            Console.WriteLine("Please enter the number you wanna do : ");
            int choose1 = Convert.ToInt16(Console.ReadLine());
            if(choose1 == 1)
            {
                Console.WriteLine();
                Console.WriteLine("*** Ask The Price ***");
                Console.WriteLine();
                Console.Write("Please enter the number of the book you wanna learn it's price : ");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1": Console.WriteLine("Price of the Yaprak Dökümü is 5 Euro"); break;
                    case "2": Console.WriteLine("Price of the Yaban is 3 Euro"); break;
                    case "3": Console.WriteLine("Price of the Tutunamayanlar is 2 Euro"); break;
                    case "4": Console.WriteLine("Price of the Gazi Paşa is 11 Euro"); break;
                    case "5": Console.WriteLine("Price of the Kukla is 6 Euro"); break;
                    case "6": Console.WriteLine("Price of the Tehlikeli Oyunlar is 4 Euro"); break;
                    case "7": Console.WriteLine("Price of the Percy Jackson is 10 Euro"); break;
                    case "8": Console.WriteLine("Price of the A North Adventure is 14 Euro"); break;
                    case "9": Console.WriteLine("Price of the Losers is 7 Euro"); break;
                    case "10": Console.WriteLine("Price of the Brave New World is 20 Euro"); break;
                    case "11": Console.WriteLine("Price of the Gambler is 15 Euro"); break;
                    case "12": Console.WriteLine("Price of the Doctor Sleep is 19 Euro"); break;
                    default: Console.WriteLine("There is no book in this number. Please check your number"); break;
                }
            }
            if (choose1 == 2)
            {
                Console.WriteLine();
                Console.WriteLine("*** Save of the New Reader ***");
                Console.WriteLine();
                string name, surname, university1;
                Console.WriteLine("Please enter your name : ");
                name = Console.ReadLine();
                Console.WriteLine("Please enter your surname : ");
                surname = Console.ReadLine();
                Console.WriteLine("Please enter your University : ");
                university1 = Console.ReadLine();

                string file1 = "C:\\Users\\user\\Masaüstü\\final.txt";
                StreamWriter s1 = new StreamWriter(file1);
                s1.WriteLine("Your Name : "+name);
                s1.WriteLine("Your Surname : " + name);
                s1.WriteLine("Your University : " + name);
                s1.Close();
            }
            if (choose1 == 3)
            {
                Console.WriteLine();
                Console.WriteLine("*** Book of Today ***");
                Console.WriteLine();
                Console.WriteLine("***************");
                Console.WriteLine("Brave New World");
                Console.WriteLine("***************");
            }
            if (choose1 == 4)
            {
                Console.WriteLine();
                Console.WriteLine("*** Archieve of Books ***");
                Console.WriteLine();
                FileStream fs1 = new FileStream("C:\\Users\\user\\Masaüstü\\books.txt",
                    FileMode.Open,FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs1);
                string word1 = sr1.ReadLine();
                while(word1 != null)
                {
                    Console.WriteLine(word1);
                    word1 = sr1.ReadLine();
                }
                sr1.Close();
                fs1.Close();
            }
            if (choose1 == 5)
            {
                Console.WriteLine();
                Console.WriteLine("*** Buy a New Book ***");
                Console.WriteLine();
                for(int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("The Number of the Book You Wanna Buy : ");
                    booknumber1 = Convert.ToInt16(Console.ReadLine());
                    if(booknumber1 == 1)
                    {
                        sumprice = sumprice + 5;
                    }
                    else if(booknumber1 == 2)
                    {
                        sumprice = sumprice + 3;
                    }
                    else if (booknumber1 == 3)
                    {
                        sumprice = sumprice + 2;
                    }
                    else if (booknumber1 == 4)
                    {
                        sumprice = sumprice + 11;
                    }
                    else if (booknumber1 == 5)
                    {
                        sumprice = sumprice + 6;
                    }
                    else if (booknumber1 == 6)
                    {
                        sumprice = sumprice + 4;
                    }
                    else if (booknumber1 == 7)
                    {
                        sumprice = sumprice + 10;
                    }
                    else if (booknumber1 == 8)
                    {
                        sumprice = sumprice + 14;
                    }
                    else if (booknumber1 == 9)
                    {
                        sumprice = sumprice + 7;
                    }
                    else if (booknumber1 == 10)
                    {
                        sumprice = sumprice + 20;
                    }
                    else if (booknumber1 == 11)
                    {
                        sumprice = sumprice + 15;
                    }
                    else if (booknumber1 == 12)
                    {
                        sumprice = sumprice + 19;
                    }
                    else 
                        Console.WriteLine("There is no book in this number");
                        Console.WriteLine("Do you wanna buy another book");
                        string answer = Console.ReadLine();
                        if (answer == "h" || answer == "H" || answer == "Hayır" || answer == "hayır")
                            break;
                }
                Console.WriteLine("Total Price : " + sumprice);
            }
            if (choose1 == 6)
            {
                Console.WriteLine();
                Console.WriteLine("*** Game ***");
                Console.WriteLine();
                int guess1 = 0;
                Random rand1 = new Random();
                int number1 = rand1.Next(1, 100);
                while(number1 != guess1)
                {
                    Console.WriteLine("Sayı Giriniz : ");
                    guess1 = Convert.ToInt16(Console.ReadLine());
                    if(guess1 > number1)
                    {
                        Console.WriteLine("Try a little bit lower number!");
                    }
                    if (guess1 < number1)
                    {
                        Console.WriteLine("Try a little bit higher number!");
                    }
                    if (guess1 == number1)
                    {
                        Console.WriteLine("You Wonnnn!!!!!!!!!");
                        break;
                    }
                }

            }
            Console.Read();
        }
    }
}