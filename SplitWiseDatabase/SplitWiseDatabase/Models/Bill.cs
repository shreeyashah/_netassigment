using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SplitWiseDatabase.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillName { get; set; }
        public int BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string BillImage { get; set; }
        public string BillNote { get; set; }
        public string Catagory { get; set; }
        public string catagoryOption { get; set; }
        public string BillReminder { get; set; }
        public string BillRepeats { get; set; }


       
        public CatagoryOption CatagoryOption { get; set; }
        public BillCatagory BillCatagory { get; set; }
        public Payment Payment { get; set; }
        public Reminder Reminder { get; set; }
        public Repeats Repeats { get; set; }


    }
}
