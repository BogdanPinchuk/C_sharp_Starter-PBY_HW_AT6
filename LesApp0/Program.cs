using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення чисел
            Console.WriteLine("Введіть число:\n");
            Console.Write("\tA = ");
            int a = int.Parse(Console.ReadLine());

            // цикл for
            Console.WriteLine("\nЗа допомогою циклу for:");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("\tHello!");
            }

            // цикл do while
            Console.WriteLine("\nЗа допомогою циклу do while:");
            {
                int i = default;
                do
                {
                    Console.WriteLine("\tHello!");
                    i++;
                } while (i < a);
            }

            // цикл do while
            Console.WriteLine("\nЗа допомогою циклу while:");
            {
                int i = default;
                while (i < a)
                {
                    Console.WriteLine("\tHello!");
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
