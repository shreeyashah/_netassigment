using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitWiseDatabase.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set;}
        public Bill Bill { get; set; }
        public Owes Owes { get; set; }
        public Shared Shared { get; set; }
        public Balance Balance { get; set; }
        public SattleUp SattleUp { get; set; }
    }
}
