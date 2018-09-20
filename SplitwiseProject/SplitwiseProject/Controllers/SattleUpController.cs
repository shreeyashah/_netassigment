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
    public class SattleUpController : Controller
    {
        SattleUpAccessLayer us = new SattleUpAccessLayer();


        [HttpGet]

        [Route("api/SattleUp/Index")]

        public IEnumerable<SattleUp> Index()

        {

            return us.GetAllSattleUp();

        }



        [HttpPost]

        [Route("api/SattleUp/Create")]

        public int Create([FromBody] SattleUp sattleUp)

        {

            return us.AddSattleUp(sattleUp);

        }



        [HttpGet]

        [Route("api/Bill/SattleUp/{id}")]

        public SattleUp Details(int id)

        {

            return us.GetSattleUpData(id);

        }


        [HttpDelete]

        [Route("api/Bill/SattleUp/{id}")]

        public int Delete(int id)

        {

            return us.DeleteSattleUp(id);

        }

        [Route("api/SattleUp/GetRepeatsList")]

        public IEnumerable<PaymentMode> GetPaymentModeDetail()

        {

            return us.GetPaymentMode();

        }
    }
}
