using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
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
        public string BillCatagoryName { get; set; }
        public string CatagoryOptionName { get; set; }
        public string BillReminder { get; set; }
        public string BillRepeats { get; set; }
        public int ReminderName { get; set; }
        public int RepeatsName { get; set; }
        public int UserId { get; set; }

        [ForeignKey("CatagoryOptionId")]
        public CatagoryOption catagoryOption { get; set; }

        [ForeignKey(" ReminderId")]
        public Reminder reminder { get; set; }

        [ForeignKey(" RepeatsId")]
        public Repeats repeats { get; set; }

        [ForeignKey("UserId")]
        public virtual User user { get; set; }

    }
}
