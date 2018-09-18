using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitWiseDatabase.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
       public string EmailId { get; set; }

        public Friends friends { get; set; }
        public Bill bill { get; set; }
        public Payment payment { get; set; }
        public SattleUp sattleUp { get; set;}
        public Shared shared { get; set; }
        public Owes owes { get; set; }
        public Activity activity { get; set; }
        public Group group { get; set; }
        public Balance balance { get; set; }



    }
}
