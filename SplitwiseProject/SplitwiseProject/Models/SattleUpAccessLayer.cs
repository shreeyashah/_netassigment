using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class SattleUpAccessLayer
    {
        SplitwiseProjectContext db = new SplitwiseProjectContext();

        public IEnumerable<SattleUp> GetAllSattleUp()

        {

            try

            {

                return db.SattleUps.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new employee record   

        public int AddSattleUp(SattleUp sattleUp)

        {

            try

            {

                db.SattleUps.Add(sattleUp);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }






        public SattleUp GetSattleUpData(int id)

        {

            try

            {

                SattleUp sattleUp = db.SattleUps.Find(id);

                return sattleUp;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular bill  

        public int DeleteSattleUp(int id)

        {

            try

            {

                SattleUp sattleUp = db.SattleUps.Find(id);

                db.SattleUps.Remove(sattleUp);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }
        public List<PaymentMode> GetPaymentMode()

        {

            List<PaymentMode> lstmode= new List<PaymentMode>();

            lstmode = (from PaymentModeList in db.PaymentModes select PaymentModeList).ToList();



            return lstmode;

        }
        
    }
}
