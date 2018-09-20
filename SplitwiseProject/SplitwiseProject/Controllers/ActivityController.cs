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
    public class ActivityController : Controller
    {
        ActivityAccessLayer us = new ActivityAccessLayer();


        [HttpGet]

        [Route("api/Activity/Index")]

        public IEnumerable<Activity> Index()

        {

            return us.GetAllActivity();

        }



        [HttpPost]

        [Route("api/Activity/Create")]

        public int Create([FromBody] Activity activity)

        {

            return us.AddActivity(activity);

        }



        [HttpGet]

        [Route("api/Activity/Details/{id}")]

        public Activity Details(int id)

        {

            return us.GetActivityData(id);

        }



        [HttpPut]

        [Route("api/Activity/Edit")]

        public int Edit([FromBody]Activity activity)

        {

            return us.UpdateActivity(activity);

        }



        [HttpDelete]

        [Route("api/Activity/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteActivity(id);

        }
    }
}
