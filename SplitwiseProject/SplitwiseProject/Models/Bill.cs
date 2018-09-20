using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillName { get; set; }
        public int BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string BillImage { get; set; }
        public string BillNote { get; set; }
        public string BillCatagoryName { get; set; }
        public string ReminderNmae { get; set; }
        public string RepeatsName { get; set; }

      [ForeignKey("BillCatagoryId")]
        public BillCatagory BillCatagory { get; set; }

        [ForeignKey("OwesId")]
        public ICollection<Owes> Owes { get; set; }

        [ForeignKey("ReminderId")]
        public Reminder Reminder { get; set; }

        [ForeignKey("RepeatsId")]
        public Repeats Repeats { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
