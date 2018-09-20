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
    public class SharedController : Controller
    {
        SharedAccessLayer us = new SharedAccessLayer();


        [HttpGet]

        [Route("api/Shared/Index")]

        public IEnumerable<Shared> Index()

        {

            return us.GetAllShared();

        }



        [HttpPost]

        [Route("api/Shared/Create")]

        public int Create([FromBody] Shared shared)

        {

            return us.AddShared(shared);

        }



        [HttpGet]

        [Route("api/Shared/Details/{id}")]

        public Shared Details(int id)

        {

            return us.GetSharedData(id);

        }



        [HttpPut]

        [Route("api/Shared/Edit")]

        public int Edit([FromBody] Shared shared)

        {

            return us.UpdateShared(shared);

        }



        [HttpDelete]

        [Route("api/Shared/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteShared(id);

        }
    }
}
