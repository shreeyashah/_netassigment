using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class User
    {
        public int UserId { get; set; }

        
        public string UserName { get; set; }

        
        public string EmailId { get; set; }

        [ForeignKey("ActivityId")]
        public ICollection <Activity> Activities { get; set; }
 
        [ForeignKey("SattleUpId")]
        public ICollection<SattleUp> SattleUps { get; set; }

        [ForeignKey("SharedId")]
        public ICollection<Shared> Shareds { get; set; }

        [ForeignKey("OwesId")]
        public ICollection<Owes> Owes { get; set; }

        [ForeignKey("PaymentId")]
        public ICollection<Payment> Payments { get; set; }







    }
}
