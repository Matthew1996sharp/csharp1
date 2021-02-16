using System;
using Program1.CalcLib;
using Program1.WordLib;

namespace Program1.TestConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int y = x + 20;
            Word.WriteWord("World");
            Console.WriteLine("x + y = {0}", Calc.Sum(x,y));
        }
    }
}
