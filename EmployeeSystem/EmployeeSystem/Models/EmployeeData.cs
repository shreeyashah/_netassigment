using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Models
{
    public class EmployeeData
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Surname{ get; set; }

        [Required]
        [StringLength(60)]
        public string Address { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public int Phnno { get; set; }


        public int DepartmentID { get; set; }

        public Department Department { get; set; }

    }
}
