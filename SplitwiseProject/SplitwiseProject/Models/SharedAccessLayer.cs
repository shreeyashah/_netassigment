using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class SharedAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Shared> GetAllShared()

        {

            try

            {

                return db.Shareds.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddShared(Shared shared)

        {

            try

            {

                db.Shareds.Add(shared);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateShared(Shared shared)

        {

            try

            {

                db.Entry(shared).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public Shared GetSharedData(int id)

        {

            try

            {

                Shared shared = db.Shareds.Find(id);

                return shared;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteShared(int id)

        {

            try

            {

                Shared frd = db.Shareds.Find(id);

                db.Shareds.Remove(frd);

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
