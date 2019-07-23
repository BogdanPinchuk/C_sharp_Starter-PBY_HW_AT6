using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp6
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
            int a = int.Parse(Console.ReadLine()),
                b = 4 * a;

            // виведення фігури
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < b; j++)
                {
                    if (b - j - 1 == i * b / a)
                    {
                        Console.Write("8");
                    }
                    else
                    {
                        Console.Write("o");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

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
