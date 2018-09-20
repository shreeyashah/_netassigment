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
    public class OwesController : Controller
    {
        OwesAccessLayer us = new OwesAccessLayer();


        [HttpGet]

        [Route("api/Owes/Index")]

        public IEnumerable<Owes> Index()

        {

            return us.GetAllOwes();

        }



        [HttpPost]

        [Route("api/Owes/Create")]

        public int Create([FromBody] Owes owes)

        {

            return us.AddOwes(owes);

        }



        [HttpGet]

        [Route("api/Owes/Details/{id}")]

        public Owes Details(int id)

        {

            return us.GetOwesData(id);

        }



        [HttpPut]

        [Route("api/Owes/Edit")]

        public int Edit([FromBody]Owes owes)

        {

            return us.UpdateOwes(owes);

        }



        [HttpDelete]

        [Route("api/Owes/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteOwes(id);

        }
    }
}
