﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int CatagoryOptionId { get; set; }
        public int BillCatagoryId { get; set; }
        public int PaymentId { get; set; }
        public int ReminderId { get; set; }
        public int RepeatsId { get; set; }

        [ForeignKey("CatagoryOptionId")]
        public  CatagoryOption CatagoryOption { get; set; }

        [ForeignKey("BillCatagoryId")]
        public BillCatagory BillCatagory { get; set; }

        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }

        [ForeignKey(" ReminderId")]
        public Reminder Reminder { get; set; }

        [ForeignKey(" RepeatsId")]
        public Repeats Repeats { get; set; }


    }
}
