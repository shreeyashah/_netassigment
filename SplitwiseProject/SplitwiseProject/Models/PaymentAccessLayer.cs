using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class PaymentAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<Payment> GetAllPayment()

        {

            try

            {

                return db.Payments.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddPayment(Payment payment)

        {

            try

            {

                db.Payments.Add(payment);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar friend  

        public int UpdatePayment(Payment payment)

        {

            try

            {

                db.Entry(payment).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular friend 

        public Payment GetPaymentData(int id)

        {

            try

            {

                Payment payment = db.Payments.Find(id);

                return payment;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular employee  

        public int DeletePayment(int id)

        {

            try

            {

                Payment frd = db.Payments.Find(id);

                db.Payments.Remove(frd);

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
