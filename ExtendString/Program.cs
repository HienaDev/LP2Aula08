using System;

namespace ExtendString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";

            for (int i = 0; i < 5; i++)
                Console.WriteLine(str.ToRandomCase());
        }
    }
}
