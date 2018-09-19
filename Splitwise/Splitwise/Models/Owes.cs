using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class Owes
    {
        public int OwesId { get; set; }
        public int OwesAmmount { get; set; }
        public int FriendsId { get; set; }
        
       
       

      [ForeignKey("FriendsId")]
       public virtual Friends friends { get; set; }

    
    }
}
