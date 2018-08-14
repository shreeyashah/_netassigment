using System;

namespace Polymorphisam
{
    class Program
    {
        static void Main(string[] args)
        {
            Devloper emp = new Devloper();
            {
                emp.id = 1;
                emp.name = "shreeya";
                emp.designation = "devloper";
                emp.annsalary = 185000;
                emp.Dateofjoin = "20/2/2014";
                emp.experience = 5;

            }
            emp.Salary();
            emp.display();
            Console.WriteLine("\n \n \n ");


            Devloper emp1 = new Devloper();
            {
                emp1.id = 2;
                emp1.name = "riya";
                emp1.designation = "devloper";
                emp1.annsalary = 200000;
                emp1.Dateofjoin = "20/2/2011";
                emp1.experience = 7;
            }
            emp1.Salary();
            emp1.display();

            Console.WriteLine("\n \n ");
            HR h = new HR();
            {
                h.id = 103;
                h.name = "zal";
                h.designation = "HR";
                h.annsalary = 150000;
               h.Dateofjoin = "20/7/2016";
                h.experience = 2;
            }
            h.Salary();
            h.display();
            Console.WriteLine("\n \n \n ");

            HR h1 = new HR();
            {
                h1.id = 107;
                h1.name = "JAINA";
                h1.designation = "HR";
                h1.annsalary = 300000;
                h1.Dateofjoin = "20/7/2016";
                h1.experience = 8;
            }
            h1.Salary();
            h1.display();
            Console.ReadKey(true);
            
        }
    }
}
