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
    public class BalanceController : Controller
    {
        BalanceAccessLayer us = new BalanceAccessLayer();


        [HttpGet]

        [Route("api/Balance/Index")]

        public IEnumerable<Balance> Index()

        {

            return us.GetAllBalance();

        }



        [HttpPost]

        [Route("api/Balance/Create")]

        public int Create([FromBody] Balance balance)

        {

            return us.AddBalance(balance);

        }



        [HttpGet]

        [Route("api/Balance/Details/{id}")]

        public Balance Details(int id)

        {

            return us.GetBalanceData(id);

        }



        [HttpPut]

        [Route("api/Balance/Edit")]

        public int Edit([FromBody]Balance balance)

        {

            return us.UpdateBalance(balance);

        }



        [HttpDelete]

        [Route("api/Balance/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteBalance(id);

        }
    }
}
