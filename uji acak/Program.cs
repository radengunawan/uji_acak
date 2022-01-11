using System;

namespace uji_acak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            Random ac1 = new Random();
            //int val1 = ac1.Next(-5,5);

            // //Console.WriteLine(val1);
            // double b1 = ac1.NextDouble();
            //// Console.WriteLine(b1);// <--- number from 0 to 1.0
            // Console.WriteLine(b1*100);
            // Console.WriteLine((float)b1 * 100F);
            // // Console.WriteLine((float)b1 * 100M); /// <---WRONG 
            // Console.WriteLine((decimal)b1 * 100M);

            
            
            //coinflip 5x:

            for (int i = 0; i < 6; i++)
            {
                int zeroOrOne = ac1.Next(2);
                bool coinFlip = Convert.ToBoolean(zeroOrOne);
                Console.WriteLine(coinFlip);
            }
           


        }
    }
}
