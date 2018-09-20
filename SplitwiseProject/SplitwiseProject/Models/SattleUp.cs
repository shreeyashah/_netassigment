using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class SattleUp
    {

        public int SattleUpId { get; set; }
        public int SattleAmount { get; set; }
        public int PaymentModeId { get; set; }

        [ForeignKey("PaymentModeId")]
        public PaymentMode PaymentMode { get; set; }
    }
}
