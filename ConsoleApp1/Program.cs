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
            int exampleB = 10;
            float newfloat1 = 10.2F;
            string titlestr = "New Program";
            Console.Title = ($"Title: {titlestr}");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hi, this is a new test program.");
            Console.WriteLine(exampleB + newfloat1);
            Console.ReadKey();
        }
    }
}
