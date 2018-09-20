﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class Friends
    {
        public int FriendsId { get; set; }
        public string FriendName { get; set; }
        public string FriendEmail { get; set; }


        [ForeignKey("PaymentId")]
        public ICollection<Payment>Payments  { get; set; }


    }
}
