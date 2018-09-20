using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class ActivityAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Activity> GetAllActivity()

        {

            try

            {

                return db.Activities.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddActivity(Activity activity)

        {

            try

            {

                db.Activities.Add(activity);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateActivity(Activity activity)

        {

            try

            {

                db.Entry(activity).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public Activity GetActivityData(int id)

        {

            try

            {

                Activity activity = db.Activities.Find(id);

                return activity;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteActivity(int id)

        {

            try

            {

                Activity frd = db.Activities.Find(id);

                db.Activities.Remove(frd);

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
