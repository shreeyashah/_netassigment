using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int FriendsId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("FriendsId")]
        public virtual  ICollection<Friends> Friends { get; set; }


        [ForeignKey("UserId")]
        public virtual User user { get; set; }


    }
}
