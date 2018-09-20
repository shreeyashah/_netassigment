using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class Owes
    {
        public int OwesId { get; set; }
        public int OwesAmmount { get; set; }

        [ForeignKey("FriendsId")]
        public Friends Friends { get; set; }
      }
}
