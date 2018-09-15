using System;
using System.Collections.Generic;

namespace EmployeeMange.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string Department { get; set; }
    }
}
