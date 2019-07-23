using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення чисел
            Console.WriteLine("Введіть параметри:\n");
            Console.Write("\tВисота прямокутника: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tШирина прямокутника: ");
            int b = int.Parse(Console.ReadLine());

            // цикл for
            Console.WriteLine("\nЗа допомогою циклу for:\n");
            for (int i = 0; i < a; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < b; j++)
                {
                    Console.Write("O");
                }
                Console.WriteLine();
            }

            // цикл do while
            Console.WriteLine("\nЗа допомогою циклу do while:\n");
            {
                int i = default;
                do
                {
                    int j = default;

                    Console.Write("\t");
                    do
                    {
                        Console.Write("O");
                        j++;
                    } while (j < b);
                    Console.WriteLine();
                    i++;
                } while (i < a);
            }

            // цикл do while
            Console.WriteLine("\nЗа допомогою циклу while:\n");
            {
                int i = default;
                while (i < a)
                {
                    int j = default;

                    Console.Write("\t");
                    while (j < b)
                    {
                        Console.Write("O");
                        j++;
                    }
                    Console.WriteLine("");
                    i++;
                }
            }

            #region Повторення
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
            #endregion
        }
    }
}
