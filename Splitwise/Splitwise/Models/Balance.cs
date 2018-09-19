using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class Balance
    {
        public int BalanceId { get; set; }

        public int BalanceAmount { get; set; }
        public int FriendsId { get; set; }
        public int UserId { get; set; }
      

        [ForeignKey("FriendsId")]
        public virtual Friends friends { get; set; }

        [ForeignKey("UserId")]
        public virtual User user { get; set; }

       
    }
}
