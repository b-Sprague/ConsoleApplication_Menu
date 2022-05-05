using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Menu:");
            Console.SetCursorPosition(3, 1);
            Console.Write("A.");
            Console.SetCursorPosition(3, 2);
            Console.Write("B.");
            Console.SetCursorPosition(3, 3);
            Console.Write("C.");

            Console.SetCursorPosition(0, 1);
            Menu(0, 1, ConsoleColor.DarkRed, "->", 1, 3, "Hi", 1, "Hello", 2, "Bye", 3);


            Console.Read();
        }

        static void Menu(int x, int y, ConsoleColor Color, string Pointer, int top, int bottom, string a1, int y1, string a2, int y2, string a3, int y3)
        {
            int NewY = 1;
            ConsoleKeyInfo input;
            Console.ForegroundColor = Color;
            Console.Write(Pointer);

            while(true)
            {
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY--;

                    if(NewY < top)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = bottom;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY++;

                    if (NewY > bottom)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = top;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if(input.Key == ConsoleKey.Enter)
                {
                    if (NewY == y1)
                    {
                        Console.Clear();
                        Console.Write(a1);
                    }
                    else 
                    if(NewY == y2)
                    {
                        Console.Clear();
                        Console.Write(a2);
                    }
                    else
                    if(NewY == y3)
                    {
                        Console.Clear();
                        Console.Write(a3);
                    }

                }

            }
        }
    }
}
