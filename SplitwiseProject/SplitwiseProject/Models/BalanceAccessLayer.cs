using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class BalanceAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Balance> GetAllBalance()

        {

            try

            {

                return db.Balances.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddBalance(Balance balance)

        {

            try

            {

                db.Balances.Add(balance);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdateBalance(Balance balance)

        {

            try

            {

                db.Entry(balance).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public Balance GetBalanceData(int id)

        {

            try

            {

                Balance activity = db.Balances.Find(id);

                return activity;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeleteBalance(int id)

        {

            try

            {

                Balance frd = db.Balances.Find(id);

                db.Balances.Remove(frd);

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
