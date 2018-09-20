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
    public class GroupController : Controller
    {
        GroupAccessLayer us = new GroupAccessLayer();


        [HttpGet]

        [Route("api/Group/Index")]

        public IEnumerable<Group> Index()

        {

            return us.GetAllGroup();

        }



        [HttpPost]

        [Route("api/Group/Create")]

        public int Create([FromBody] Group group)

        {

            return us.AddGroup(group);

        }



        [HttpGet]

        [Route("api/Group/Details/{id}")]

        public Group Details(int id)

        {

            return us.GetGroupData(id);

        }



        [HttpPut]

        [Route("api/Group/Edit")]

        public int Edit([FromBody] Group friends)

        {

            return us.UpdateGroup(friends);

        }



        [HttpDelete]

        [Route("api/Group/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteGroup(id);

        }
    }
}
