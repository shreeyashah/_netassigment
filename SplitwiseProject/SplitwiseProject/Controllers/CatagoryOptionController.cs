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
    public class CatagoryOptionController : Controller
    {
        CatagoryOptionAccessLayer us = new CatagoryOptionAccessLayer();


        [HttpGet]

        [Route("api/Activity/Index")]

        public IEnumerable<CatagoryOption> Index()

        {

            return us.GetAllCatagoryOption();

        }



        [HttpPost]

        [Route("api/Activity/Create")]

        public int Create([FromBody] CatagoryOption catagoryOption)

        {

            return us.AddCatagoryOption(catagoryOption);

        }



        [HttpGet]

        [Route("api/Activity/Details/{id}")]

        public CatagoryOption Details(int id)

        {

            return us.GetCatagoryOptionData(id);

        }



        [HttpPut]

        [Route("api/Activity/Edit")]

        public int Edit([FromBody]CatagoryOption catagoryOption)

        {

            return us.UpdateCatagoryOption(catagoryOption);

        }



        [HttpDelete]

        [Route("api/Activity/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteCatagoryOption(id);

        }
    }
}
