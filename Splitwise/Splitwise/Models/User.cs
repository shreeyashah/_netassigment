using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }




    }
}
