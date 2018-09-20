using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SplitwiseProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SplitwiseProject.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        UserAccessLayer us = new UserAccessLayer();


        [HttpGet]

        [Route("api/User/Index")]

        public IEnumerable<User> Index()

        {

            return us.GetAllUser();

        }



        [HttpPost]

        [Route("api/User/Create")]

        public int Create([FromBody] User user)

        {

            return us.AddUser(user);

        }



        [HttpGet]

        [Route("api/User/Details/{id}")]

        public User Details(int id)

        {

            return us.GetUserData(id);

        }



        [HttpPut]

        [Route("api/User/Edit")]

        public int Edit([FromBody]User user)

        {

            return us.UpdateUser(user);

        }



        [HttpDelete]

        [Route("api/User/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteUser(id);

        }

    }
}
