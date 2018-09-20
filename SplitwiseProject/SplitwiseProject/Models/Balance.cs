using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class Balance
    {
        public int BalanceId { get; set; }

        public int BalanceAmount { get; set; }

        [ForeignKey("FriendsId")]
        public Friends Friends { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
