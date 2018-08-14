using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisam
{
      class HR:Employee
    {
        float hsalary = 0;
        //private object salary;

        public HR():base()
        {

        }

        
        public override void Salary()
        {
            if (experience>4)
            {
                hsalary = 8000 + (1000 * experience);
                Console.WriteLine($"devloper salary is {hsalary}");
            }
            else
            {
                Console.WriteLine(" HR basic salary is 8000 BECUSE OF EXPERIANCED IS LESS THEN 4 YEAR");
            }
        }
        public override void display()
        {
            Console.WriteLine($" id of employee {id}");
            Console.WriteLine($" name of employee {name}");
            Console.WriteLine($" designation of employee {designation}");
            Console.WriteLine($" dateofjoin of employee {Dateofjoin}");
            Console.WriteLine($" salary of employee {annsalary}");
        }
      
    }
}
