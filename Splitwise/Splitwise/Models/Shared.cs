using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class Shared
    {
        public int SharedId { get; set; }
        public int SharedAmmount { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User user { get; set; }
    }


}


