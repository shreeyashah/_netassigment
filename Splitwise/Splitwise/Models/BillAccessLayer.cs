using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class BillAccessLayer
    {
        SplitwiseContext db = new SplitwiseContext();

        public IEnumerable<Bill> GetAllBill()

        {

            try

            {

                return db.bills.ToList();

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

                db.bills.Add(bills);

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

                Bill bills = db.bills.Find(id);

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

                Bill bills = db.bills.Find(id);

                db.bills.Remove(bills);

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

            lstCatagory= (from BillCatagoryList in db.BillCatagories select BillCatagoryList).ToList();



            return lstCatagory;

        }

    }
}
