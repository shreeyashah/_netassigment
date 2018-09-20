using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class FriendAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Friends> GetAllFriends()

        {

            try

            {

                return db.Friends.ToList();

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

                db.Friends.Add(friends);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

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



        //Get the details of a particular friend 

        public Friends GetFriendsData(int id)

        {

            try

            {

                Friends friends = db.Friends.Find(id);

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

                Friends frd = db.Friends.Find(id);

                db.Friends.Remove(frd);

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
