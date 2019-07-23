﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // діапазон чисел, що виводяться
            int a = 1001,
                b = 2500,
                step = 3;

            // виведення
            // цикл for
            Console.WriteLine("\nЗа допомогою циклу for:\n");
            for (int i = a; i <= b; i += step)
            {
                Console.Write("\t" + i);
            }

            // цикл do while
            Console.WriteLine("\n\nЗа допомогою циклу do while:\n");
            {
                int i = a;
                do
                {
                    Console.Write("\t" + i);
                    i += step;
                } while (i <= b);
            }

            // цикл do while
            Console.WriteLine("\n\nЗа допомогою циклу while:\n");
            {
                int i = a;
                while (i <= b)
                {
                    Console.Write("\t" + i);
                    i += step;
                }
            }

            Console.WriteLine();

            // delay
            Console.ReadKey(true);
        }
    }
}
