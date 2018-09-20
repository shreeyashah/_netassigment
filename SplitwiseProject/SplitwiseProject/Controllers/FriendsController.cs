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
    public class FriendsController : Controller
    {
        FriendAccessLayer us = new FriendAccessLayer();


        [HttpGet]

        [Route("api/Friends/Index")]

        public IEnumerable<Friends> Index()

        {

            return us.GetAllFriends();

        }



        [HttpPost]

        [Route("api/Friends/Create")]

        public int Create([FromBody] Friends friends)

        {

            return us.AddFriends(friends);

        }



        [HttpGet]

        [Route("api/Friends/Details/{id}")]

        public Friends Details(int id)

        {

            return us.GetFriendsData(id);

        }



        [HttpPut]

        [Route("api/Friends/Edit")]

        public int Edit([FromBody]Friends friends)

        {

            return us.UpdateFriends(friends);

        }



        [HttpDelete]

        [Route("api/Friends/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteFriends(id);

        }
    }

    
}
