using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Splitwise.Models;

namespace Splitwise.Controllers
{
   
    public class FriendsController : ControllerBase
    {
        FriendsAccessLayer us = new FriendsAccessLayer();


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