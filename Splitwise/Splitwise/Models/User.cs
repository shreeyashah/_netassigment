using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class User
    {
        
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string EmailId { get; set; }
    }
}
