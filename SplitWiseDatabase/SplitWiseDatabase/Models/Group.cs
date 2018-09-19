using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitWiseDatabase.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set;}
        public int BillId { get; set; }

        public int OwesId { get; set; }
        public int SharedId { get; set; }
        public int BalanceId { get; set; }
        public int SattleUp { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill bill { get; set; }

        [ForeignKey("OwesId")]
        public virtual Owes owes { get; set; }

        [ForeignKey("SharedId")]
        public virtual Shared shared { get; set; }

        [ForeignKey("BalanceId")]
        public virtual Balance balance { get; set; }

        [ForeignKey("SattleUpId")]
        public virtual SattleUp sattleUp { get; set; }
    }
}
