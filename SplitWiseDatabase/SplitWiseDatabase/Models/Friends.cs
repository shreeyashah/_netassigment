using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitWiseDatabase.Models
{
    public class Friends
    {
        public int FriendsId { get; set; } 
        public string FriendName { get; set; }
        public string FriendEmail { get; set; }

        public int ActivityId { get; set; }
        public int PaymentId { get; set; }
        public int SharedId { get; set; }
        public int GroupId { get; set; }
        public int OwesId { get; set; }
        public int SattleUpId { get; set; }

        [ForeignKey("ActivityId")]
        public virtual Activity activity { get; set; }

        [ForeignKey("PaymentId")]
        public virtual Payment payment { get; set; }

        [ForeignKey("SharedId")]
        public virtual Shared shared { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group group { get; set; }

        [ForeignKey("OwesId")]
        public virtual Owes owes { get; set; }

        [ForeignKey(" SattleUpId")]
        public virtual SattleUp sattleUp { get; set; }
    }
}
