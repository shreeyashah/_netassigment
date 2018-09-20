using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class CatagoryOptionAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<CatagoryOption> GetAllCatagoryOption()

        {

            try

            {

                return db.CatagoryOptions.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddCatagoryOption(CatagoryOption catagoryOption)

        {

            try

            {

                db.CatagoryOptions.Add(catagoryOption);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateCatagoryOption(CatagoryOption catagoryOption)

        {

            try

            {

                db.Entry(catagoryOption).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public CatagoryOption GetCatagoryOptionData(int id)

        {

            try

            {

                CatagoryOption catagoryOption = db.CatagoryOptions.Find(id);

                return catagoryOption;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteCatagoryOption(int id)

        {

            try

            {

                CatagoryOption frd = db.CatagoryOptions.Find(id);

                db.CatagoryOptions.Remove(frd);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }
    }
}
