using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class BillAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Bill> GetAllBill()

        {

            try

            {

                return db.Bills.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddBills(Bill bills)

        {

            try

            {

                db.Bills.Add(bills);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }






        public Bill GetBillData(int id)

        {

            try

            {

                Bill bills = db.Bills.Find(id);

                return bills;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular bill  

        public int DeleteBill(int id)

        {

            try

            {

                Bill bills = db.Bills.Find(id);

                db.Bills.Remove(bills);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }
        public List<BillCatagory> GetBillCatagory()

        {

            List<BillCatagory> lstCatagory = new List<BillCatagory>();

            lstCatagory = (from BillCatagoryList in db.BillCatagories select BillCatagoryList).ToList();



            return lstCatagory;

        }
        public List<Reminder> GetReminder()

        {

            List<Reminder> lstReminder = new List<Reminder>();

            lstReminder = (from ReminderList in db.Reminders select ReminderList).ToList();



            return lstReminder;

        }
        public List<Repeats> GetRepeats()

        {

            List<Repeats> lstRepeats = new List<Repeats>();

            lstRepeats = (from RepeatsList in db.Repeats select RepeatsList).ToList();



            return lstRepeats;

        }

    }
}
