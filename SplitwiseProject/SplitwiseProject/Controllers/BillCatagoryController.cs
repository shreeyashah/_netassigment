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
    public class BillCatagoryController : Controller
    {
         BillCatagoryAccessLayer us = new BillCatagoryAccessLayer();


        [HttpGet]

        [Route("api/BillCatagory/Index")]

        public IEnumerable<BillCatagory> Index()

        {

            return us.GetAllBillCatagory();

        }



        [HttpPost]

        [Route("api/BillCatagory/Create")]

        public int Create([FromBody] BillCatagory billCatagory)

        {

            return us.AddBillCatagory(billCatagory);

        }



        [HttpGet]

        [Route("api/BillCatagory/Details/{id}")]

        public BillCatagory Details(int id)

        {

            return us.GetBillCatagoryData(id);

        }


        [HttpDelete]

        [Route("api/BillCatagory/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteBillCatagory(id);

        }


        [Route("api/BillCatagory/GetCatagoryOption")]
        public IEnumerable<CatagoryOption> GetCatagoryOptionDetail()

        {

            return us.GetCatagoryOption();

        }
    }
}
