using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisam
{
   public abstract class  Employee
    {
       public int id { get; set; }
        public int annsalary { get; set; }
       public string name { get; set; }
       public string designation { get; set; }
      public string Dateofjoin { get; set; }
       public float experience { get; set; }
       // public abstract void Data();
        public abstract void Salary();
        public abstract void display();




    }
}

