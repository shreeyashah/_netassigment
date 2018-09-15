using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeMange.Models
{
    public class EmployeeDataAccessLayer
    {
        employeeDBContext db = new employeeDBContext();

        public IEnumerable<Employee> GetAllEmployees()

        {

            try

            {

                return db.Employee.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddEmployee(Employee employee)

        {

            try

            {

                db.Employee.Add(employee);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar employee  

        public int UpdateEmployee(Employee employee)

        {

            try

            {

                db.Entry(employee).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular employee  

        public Employee GetEmployeeData(int id)

        {

            try

            {

                Employee employee = db.Employee.Find(id);

                return employee;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteEmployee(int id)

        {

            try

            {

                Employee emp = db.Employee.Find(id);

                db.Employee.Remove(emp);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Get the list of Department 

        public List<Department> GetDepartment()

        {

            List<Department> lstDepartment = new List<Department>();

            lstDepartment = (from DepartmentList in db.Department select DepartmentList).ToList();



            return lstDepartment;

        }
    }
}
