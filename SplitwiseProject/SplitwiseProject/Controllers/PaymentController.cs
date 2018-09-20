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
    public class PaymentController : Controller
    {
        PaymentAccessLayer us = new PaymentAccessLayer();


        [HttpGet]

        [Route("api/Payment/Index")]

        public IEnumerable<Payment> Index()

        {

            return us.GetAllPayment();

        }



        [HttpPost]

        [Route("api/payment/Create")]

        public int Create([FromBody] Payment payment)

        {

            return us.AddPayment(payment);

        }



        [HttpGet]

        [Route("api/Payment/Details/{id}")]

        public Payment Details(int id)

        {

            return us.GetPaymentData(id);

        }



        [HttpPut]

        [Route("api/Payment/Edit")]

        public int Edit([FromBody]Payment payment)

        {

            return us.UpdatePayment(payment);

        }



        [HttpDelete]

        [Route("api/Payment/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeletePayment(id);

        }
    }
}
