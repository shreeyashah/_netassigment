using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class GroupAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Group> GetAllGroup()

        {

            try

            {

                return db.Groups.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddGroup(Group group)

        {

            try

            {

                db.Groups.Add(group);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateGroup(Group group)

        {

            try

            {

                db.Entry(group).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public Group GetGroupData(int id)

        {

            try

            {

                Group group = db.Groups.Find(id);

                return group;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteGroup(int id)

        {

            try

            {

                Group frd = db.Groups.Find(id);

                db.Groups.Remove(frd);

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
