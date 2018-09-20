using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class UserAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<User> GetAllUser()

        {

            try

            {

                return db.User.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new User record   

        public int AddUser(User user)

        {

            try

            {

                db.User.Add(user);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }





        public int UpdateUser(User user)

        {

            try

            {

                db.Entry(user).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular user 

        public User GetUserData(int id)

        {

            try

            {

                User user = db.User.Find(id);

                return user;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular user  

        public int DeleteUser(int id)

        {

            try

            {

                User use = db.User.Find(id);

                db.User.Remove(use);

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
