using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace EqualityTask
{
    class program
    {
        static void Main(string[] args)
        {
             int count=0;
        List<string> inventory = new List<string> { "Tomato",
                "Potato",
                "ToMato",
                "Potato",
                "Red Tomato",
                "Tomato Catchup",
                "Grapes",
                "grapes",
                "potato" };
            foreach (var q in inventory)
            {
                Console.WriteLine(q);
            }
                foreach(var s in inventory)
                {
                    if(s.IndexOf("tomato",StringComparison.CurrentCultureIgnoreCase)>=0)
                    {
                         count = count + 1;
                       
                    }
               
                }
            Console.Write($"\n  containig tomato {count}");

            Console.Write("\n contaning potato : where 0 is encounter:\n");
            foreach (var s in inventory)
            {
                //Console.WriteLine("\n");
                Console.WriteLine(s.IndexOf("Potato", StringComparison.CurrentCulture));
               

               
                
            }
          
            Console.ReadKey(true);
        }
           
    }
    
        
 }
 


