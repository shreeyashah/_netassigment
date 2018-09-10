using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeSystem.Models;

namespace EmployeeSystem.Models
{
    public class EmployeeSystemContext : DbContext
    {
        public EmployeeSystemContext (DbContextOptions<EmployeeSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeSystem.Models.EmployeeData> EmployeeData { get; set; }

        public DbSet<EmployeeSystem.Models.Department> Department { get; set; }
    }
}
