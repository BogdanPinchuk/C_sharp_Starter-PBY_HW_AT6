using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp10
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // назва програми
            Console.Title = "Future flag of Ukraine (натисни \"Т\" для оновлення)";

            // Розміри вікна
            int h = Console.WindowHeight,
                w = Console.WindowWidth;

            // Виведення прапору
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (i <= h / 2)
                    {
                        if (i >= j * h / w)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                    }
                    else
                    {
                        if (i <= -j * h / w + h + 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                    }
                    Console.Write("\0");
                }
            }


            #region Повторення
            //Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            //Console.Write("\t");
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
