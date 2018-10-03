using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd1 = new Random();
            float exampleRnd1 = Rnd1.Next(0, 100);
            float newfloat1 = 10.2F;
            string titlestr = "New Program";
            Console.Title = ($"Title: {titlestr}");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****Hi, this is a new test program.*****");
            Console.WriteLine("*****************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(exampleRnd1 + newfloat1);
            Console.ReadKey();
        }
    }
}
