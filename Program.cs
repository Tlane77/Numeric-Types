using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Lets Add!");

            // int a = 18;
            // int b = 6;
            // int c = a + b;
            // Console.WriteLine(c);

            // Console.WriteLine("Lets Subtract!");

            // int d = a - b;
            // Console.WriteLine(d);

            // Console.WriteLine("Lets Multiply!");

            // int e = a * b;
            // Console.WriteLine(e);

            // Console.WriteLine("Lets Divide!");

            // int f = a / b;
            // Console.WriteLine(f);

            // Console.WriteLine("Lets Do Order of Operations!");

            // int w = 5;
            // int x = 4;
            // int y = 2;
            // int z = w + x * y;
            // Console.WriteLine(d);

            Console.WriteLine("Lets Do a Combination!");

            // int mdas = (w + x) - 6 * y + (12 * 4) / 3 + 12;

            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
        }
    }
}