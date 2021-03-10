using System;

namespace pure_puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Oppgave1();
            Oppgave2();
            Oppgave3();
            NewLine();
            Console.WriteLine("NASA hire me pls :)");

        }

        private static void Oppgave1()
        {
            for (var i = 0; i < 4; i++)
            {
                HashTag(8 - 2 * i);
                NewLine();
                Space(i + 1);
            }
            NewLine();
        }

        private static void Oppgave2()
        {
            for (var i = 3; i >= 0; i--)
            {
                Space(i + 1);
                HashTag(8 - 2 * i);
                NewLine();
            }

            for (var i = 0; i < 4; i++)
            {
                Space(i + 1);
                HashTag(8 - 2 * i);
                NewLine();
            }
            NewLine();
        }

        private static void Oppgave3()
        {
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                HashTag(i + 1);
                Space(12 - 4 * i);
                HashTag(i + 1);
                NewLine();
            }

            for (var i = 3; i >= 0; i--)
            {
                Space(i);
                HashTag(i + 1);
                Space(12 - 4 * i);
                HashTag(i + 1);
                NewLine();
            }
        }

        private static void HashTag()
        {
            Console.Write("#");
        }

        private static void Space()
        {
            Console.Write(" ");
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }

        private static void HashTag(int counter)
        {
            for (var i = 0; i < counter; i++) HashTag();
        }

        private static void Space(int counter)
        {
            for (var i = 0; i < counter; i++) Space();
        }
    }
}
