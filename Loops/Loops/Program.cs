﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number <= 5);
            Console.Read();
        }
    }
}