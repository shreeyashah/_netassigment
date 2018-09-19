using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int Paymentmade { get; set; }
        public int PaymentReceive { get; set; }
        public int FriendsId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("FriendsId")]
        public virtual Friends friends { get; set; }

        [ForeignKey("UserId")]
        public virtual User user { get; set; }
    }
}
