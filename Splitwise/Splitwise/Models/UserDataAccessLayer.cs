using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class UserDataAccessLayer
    {
        SplitwiseContext db = new SplitwiseContext();

        public IEnumerable<User> GetAllUser()

        {

            try

            {

                return db.user.ToList();

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

                db.user.Add(user);

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

                User employee = db.user.Find(id);

                return employee;

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

                User use = db.user.Find(id);

                db.user.Remove(use);

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
