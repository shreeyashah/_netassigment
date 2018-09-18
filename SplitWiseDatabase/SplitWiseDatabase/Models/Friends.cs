using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitWiseDatabase.Models
{
    public class Friends
    {
        public int FriendsId { get; set; } 
        public string FriendName { get; set; }
        public string FriendEmail { get; set; }

        public Activity Activity { get; set; }
        public Payment Payment { get; set; }
        public Shared Shared { get; set; }
        public Group Group { get; set; }
        public Owes Owes { get; set; }
        public SattleUp SattleUp { get; set; }
    }
}
