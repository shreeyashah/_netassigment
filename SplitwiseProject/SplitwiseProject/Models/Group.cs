using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        [ForeignKey("FriendsId")]
        public ICollection<Friends> Friends { get; set; }


        [ForeignKey("BillId")]
        public ICollection<Bill>Bills { get; set; }


        [ForeignKey("SharedId")]
        public Shared Shared { get; set; }


        
    }
}
