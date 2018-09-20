using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class BillCatagoryAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<BillCatagory> GetAllBillCatagory()

        {

            try

            {

                return db.BillCatagories.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddBillCatagory(BillCatagory billCatagory)

        {

            try

            {

                db.BillCatagories.Add(billCatagory);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateBillCatagory(BillCatagory billCatagory)

        {

            try

            {

                db.Entry(billCatagory).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public BillCatagory GetBillCatagoryData(int id)

        {

            try

            {

                BillCatagory billCatagory = db.BillCatagories.Find(id);

                return billCatagory;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteBillCatagory(int id)

        {

            try

            {

                BillCatagory brd = db.BillCatagories.Find(id);

                db.BillCatagories.Remove(brd);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }

        public List<CatagoryOption> GetCatagoryOption()

        {

            List<CatagoryOption> lstCatagoryOption = new List<CatagoryOption>();

            lstCatagoryOption = (from CatagoryOptionList in db.CatagoryOptions select CatagoryOptionList).ToList();

        return lstCatagoryOption;

        }
    }
}
