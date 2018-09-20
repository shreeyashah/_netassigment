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
    public class BillController : Controller
    {
        BillAccessLayer us = new BillAccessLayer();


        [HttpGet]

        [Route("api/Bill/Index")]

        public IEnumerable<Bill> Index()

        {

            return us.GetAllBill();

        }



        [HttpPost]

        [Route("api/Bill/Create")]

        public int Create([FromBody] Bill bill)

        {

            return us.AddBills(bill);

        }



        [HttpGet]

        [Route("api/Bill/Details/{id}")]

        public Bill Details(int id)

        {

            return us.GetBillData(id);

        }


        [HttpDelete]

        [Route("api/Bill/Delete/{id}")]

        public int Delete(int id)

        {

            return us.DeleteBill(id);

        }

        [Route("api/Bill/GetRepeatsList")]

        public IEnumerable<Repeats> GetReminderDetail()

        {
   
            return us.GetRepeats();

        }

        [Route("api/Bill/GetReminderList")]
        public IEnumerable<Reminder> GetRepeatsDetail()

        {

            return us.GetReminder();

        }

        [Route("api/Bill/GetBillCatagory")]
        public IEnumerable<BillCatagory> GetBillCatagoryDetail()

        {

            return us.GetBillCatagory();

        }
    }
}
