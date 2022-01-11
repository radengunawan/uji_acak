using System;

namespace uji_acak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random ac1 = new Random();
            int val1 = ac1.Next(-5,5);

            Console.WriteLine(val1);
        }
    }
}
