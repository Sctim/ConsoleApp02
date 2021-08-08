using System;

namespace ConsoleApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Star();
            Console.WriteLine();
            NumPyramid();
            Console.WriteLine();
            Alphabet();
            Console.WriteLine();
            Binaries();
            Console.WriteLine();
            TripleMatrix();
        }
        public static void Star()
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("".PadRight(i, '*'));
            }
        }
        public static void NumPyramid()
        {
            string str1 = "  1";
            string t = "";
            string t1;
            for (int i = 1; i <= 3;)
            {
                Console.WriteLine(str1 + t);
                t1 = t;
                t = str1.Substring(str1.Length - 1, 1);
                t += t1;
                i++;
                str1 = str1.Remove(0, 1) + i;
            }
        }
        public static void Alphabet()
        {
            string h = "";
            string s = "";
            int b = 1;
            for (char c = 'A'; c <= 'D'; c++)
            {
                s += c;
                Console.WriteLine(s + h);
                h = "";
                for (int j = 1; j <= b; j++)
                {
                    h += s.Substring(s.Length - j, 1);
                }
                b++;
            }
        }
        public static void Binaries()
        {
            string st = "";
            string ht = "";
            bool bi = Convert.ToBoolean(1);
            for (int i = 0; i <= 4; i++)
            {
                ht = st;
                st = Convert.ToString(Convert.ToByte(bi));
                st += ht;
                Console.WriteLine(st);
                bi = !bi;
            }
        }
        public static void TripleMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
