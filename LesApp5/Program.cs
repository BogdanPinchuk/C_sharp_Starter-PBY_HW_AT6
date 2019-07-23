using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp5
{
    class Program
    {
        static void Main()
        {
            // діапазон чисел, що виводяться
            float a = 1,
                b = 5,
                step = 0.2f;

            // виведення
            // цикл for
            Console.WriteLine("\nЗа допомогою циклу for:\n");
            for (float i = a; i <= b; i += step)
            {
                Console.Write("\t" + $"{i:N1}");
            }

            // цикл do while
            Console.WriteLine("\n\nЗа допомогою циклу do while:\n");
            {
                float i = a;
                do
                {
                    Console.Write("\t" + $"{i:N1}");
                    i += step;
                } while (i <= b);
            }

            // цикл do while
            Console.WriteLine("\n\nЗа допомогою циклу while:\n");
            {
                float i = a;
                while (i <= b)
                {
                    Console.Write("\t" + $"{i:N1}");
                    i += step;
                }
            }

            Console.WriteLine();

            // delay
            Console.ReadKey(true);
        }
    }
}
