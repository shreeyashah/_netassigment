using System.Collections.Generic;
using EmployeeMange.Models;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeMange.Controllers
{

    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();



        [HttpGet]

        [Route("api/Employee/Index")]

        public IEnumerable<Employee> Index()

        {

            return objemployee.GetAllEmployees();

        }



        [HttpPost]

        [Route("api/Employee/Create")]

        public int Create([FromBody] Employee employee)

        {

            return objemployee.AddEmployee(employee);

        }



        [HttpGet]

        [Route("api/Employee/Details/{id}")]

        public Employee Details(int id)

        {

            return objemployee.GetEmployeeData(id);

        }



        [HttpPut]

        [Route("api/Employee/Edit")]

        public int Edit([FromBody]Employee employee)

        {

            return objemployee.UpdateEmployee(employee);

        }



        [HttpDelete]

        [Route("api/Employee/Delete/{id}")]

        public int Delete(int id)

        {

            return objemployee.DeleteEmployee(id);

        }



        [HttpGet]

        [Route("api/Employee/GetDepartmentList")]

        public IEnumerable<Department> Details()

        {

            return objemployee.GetDepartment();

        }
        }
    }

