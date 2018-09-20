using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class OwesAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Owes> GetAllOwes()

        {

            try

            {

                return db.Owes.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddOwes(Owes owes)

        {

            try

            {

                db.Owes.Add(owes);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateOwes(Owes owes)

        {

            try

            {

                db.Entry(owes).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public Owes GetOwesData(int id)

        {

            try

            {

                Owes owes = db.Owes.Find(id);

                return owes;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteOwes(int id)

        {

            try

            {

                Owes frd = db.Owes.Find(id);

                db.Owes.Remove(frd);

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
