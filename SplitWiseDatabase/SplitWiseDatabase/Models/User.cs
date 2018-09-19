using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitWiseDatabase.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
       public string EmailId { get; set; }

        public int FriendsId { get; set; }
        public int BillId { get; set; }
        public int PaymentId { get; set; }
        public int SattleupId { get; set; }
        public int SharedId { get; set; }
        public int OwesId { get; set; }
        public int ActivityId { get; set; }
        public int GroupId { get; set; }
        public int BalanceId { get; set; }



        [ForeignKey("FriendsId")]
        public virtual Friends friends { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill bill { get; set; }

        [ForeignKey("PaymentId")]
        public virtual Payment payment { get; set; }

        [ForeignKey("SattleupId")]
        public virtual SattleUp sattleUp { get; set;}

        [ForeignKey("SharedId")]
        public Shared shared { get; set; }

        [ForeignKey("OwesId")]
        public virtual Owes owes { get; set; }

        [ForeignKey("ActivityId")]
        public virtual Activity activity { get; set; }

        [ForeignKey("GroupId")]
        public Group group { get; set; }

        [ForeignKey("BalanceId")]
        public Balance balance { get; set; }



    }
}
