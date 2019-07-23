using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp9
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // назва програми
            Console.Title = "Текстовий редактор";

            bool isWorking = true;
            while (isWorking == true)
            {
                var symbol = Console.ReadKey(true);

                switch (symbol.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                        {
                            Console.CursorTop--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.CursorTop++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 0)
                        {
                            Console.CursorLeft--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorLeft++;
                        break;
                    case ConsoleKey.Escape:
                        isWorking = false;
                        break;
                    case ConsoleKey.Backspace:
                        if (Console.CursorLeft > 0)
                        {
                            Console.CursorLeft--;
                            Console.Write("\0");
                            Console.CursorLeft--;
                        }
                        else
                        {
                            if (Console.CursorTop > 0)
                            {
                                Console.CursorTop--;
                                Console.CursorLeft = Console.WindowWidth - 2;
                                Console.Write("\0");
                            }
                        }
                        break;
                    case ConsoleKey.Delete:
                        Console.Write("\0");
                        break;
                    case ConsoleKey.Home:
                        Console.CursorLeft = 0;
                        break;
                    case ConsoleKey.End:
                        Console.CursorLeft = Console.WindowHeight;
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorTop++;
                        Console.CursorLeft = 0;
                        break;
                    case ConsoleKey.Tab:
#if true
                        if (Console.ForegroundColor == ConsoleColor.Gray)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (Console.ForegroundColor == ConsoleColor.Green)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (Console.ForegroundColor == ConsoleColor.Blue)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
#endif
#if false
                        if (Console.BackgroundColor == ConsoleColor.Black)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        else if (Console.BackgroundColor == ConsoleColor.Green)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else if (Console.BackgroundColor == ConsoleColor.Blue)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
#endif
                        break;
                }

                if (char.IsLetterOrDigit(symbol.KeyChar))
                {
                    Console.Write(symbol.KeyChar);
                }
                else if (char.IsWhiteSpace(symbol.KeyChar))
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
