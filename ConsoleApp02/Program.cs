using System;

namespace ConsoleApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 7; i++)
            {
                Console.WriteLine("".PadRight(i, '*'));
            }
        }
    }
}
