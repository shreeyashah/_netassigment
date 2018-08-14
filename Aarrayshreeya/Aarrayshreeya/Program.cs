using System;
using System.Linq;


namespace Aarrayshreeya
{
    class Program
    {


        static void Main(string[] args)
        {

            int count=0;
          string[] strArray = { "Boat",
                "house",
                "cat",
                "river",
                 "cupboard",}; 
            // makepural of all word
            Makepural(strArray);
             
            //replace word with synoname
            strArray = strArray.Select(s => s.Replace("house", "home")).ToArray();
            foreach (var str in strArray)
            {
                count++;
            
                Console.Write($"\n {str}");

            }

            //afteradding new element
            string[] strArray1 = { "Boat",
                "house",
                "cat",
                "river",
                 "cupboard","dog"};
            Console.Write($"\n  after adding new element:");
            foreach (var str1 in strArray1)
            {
                count++;

                Console.Write($"\n {str1}");

            }
            Console.Write($"\n  after adding new element: {count}");
            Console.WriteLine($"\n count is:{count}");

            //lenght of 6 word
            string[] all = Array.FindAll(strArray,x=>x.Length==6);
            foreach(var y in all)
            {
                Console.WriteLine( $"length of 6 is {y}");
            }
            
            //at 3rd index...
            int index = Array.FindIndex(strArray, y => y[0]=='r');
            //Console.WriteLine(index);
            Console.WriteLine(strArray[index]);

            //sorting array
            Array.Sort(strArray);
            Console.WriteLine("\n sorted array");
            foreach (var str in strArray)
            {
               

                Console.Write($"\n {str}");
             }

            //reversing array
            Array.Reverse(strArray);
            Console.WriteLine("\nreverse array");
            foreach (var str in strArray)
            {
                Console.Write($"\n {str}");
            }

            Console.ReadKey(true);
           }
        static void Makepural(string[] strArray)

        {
            for (int i=0;i<strArray.Length;i++)
            {
                strArray[i] = strArray[i] + "s";
            }
          
        }

        
    }
 
}