using System;

namespace Sumoffloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            float X = 0.06f, Y = 5.94f;

            //SUM OF TWO ELEMENT
            sum = X + Y;
            Console.WriteLine($"\n X : {X} + Y {Y} =  sum is {sum}");

            //EQUALING SUM=6??
            if (sum == 6)
            {
                Console.WriteLine("sum is 6");
            }
            else
            {
                Console.WriteLine("sum is not 6");
            }

            //COMPARING X AND Y
            if (X>Y)
            {
                Console.WriteLine(" \n X IS GREATER THEN Y");
            }
            else
            {
                Console.WriteLine("\n Y IS GRETER THEN X");
            }


            // Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
        
    }
    
}
