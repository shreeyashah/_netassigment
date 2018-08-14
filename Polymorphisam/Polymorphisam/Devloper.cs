using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisam
{
    class Devloper : Employee
    {
      
        public float salary=0;
        public override void Salary()
        {
            if(experience>5)
            {
                salary = 8000 + (2000 *experience);
                Console.WriteLine($"devloper monthly salary is {salary}");
            }
            else
            {
                Console.WriteLine("basic monthly salary is 8000");
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
