using System;

namespace Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            MarieProgram.Mainx();
            return;

            DrawBox(1, 1, ConsoleColor.Green);
            DrawBox(10, 1, ConsoleColor.Yellow);
            DrawBox(1, 10, ConsoleColor.Red);
            DrawBox(10, 10, ConsoleColor.Blue);
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        static void DrawBox(int left, int top, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Write(left, top, "######");
            Write(left, top + 1, "#");
            Write(left + 5, top + 1, "#");
            Write(left, top + 2, "#");
            Write(left + 5, top + 2, "#");
            Write(left, top + 3, "#");
            Write(left + 5, top + 3, "#");
            Write(left, top + 4, "######");
        }

        static void Write(int left, int top, string text)
        {
            Console.CursorLeft = left;
            Console.CursorTop = top;
            Console.WriteLine(text);
        }
    }
}
