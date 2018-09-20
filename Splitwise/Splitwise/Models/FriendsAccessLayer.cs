using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class FriendsAccessLayer
    {
        SplitwiseContext db = new SplitwiseContext();

           public IEnumerable<Friends> GetAllFriends()

        {

            try

            {

                return db.friends.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddFriends(Friends friends)

        {

            try

            {

                db.friends.Add(friends);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar employee  

        public int UpdateFriends(Friends friends)

        {

            try

            {

                db.Entry(friends).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular employee  

        public Friends GetFriendsData(int id)

        {

            try

            {

                Friends friends = db.friends.Find(id);

                return friends;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteFriends(int id)

        {

            try

            {

                Friends frd = db.friends.Find(id);

                db.friends.Remove(frd);

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
