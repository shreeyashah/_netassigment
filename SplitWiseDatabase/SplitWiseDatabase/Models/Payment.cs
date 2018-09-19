using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitWiseDatabase.Models
{
    public class Payment
    {
      public int  PaymentId { get; set; }
      public int  Paymentmade { get; set; }
      public int PaymentReceive { get; set; }
      public string PayMode { get; set; }
      public int PaymentModeId { get; set; }


        [ForeignKey("PaymentModeId")]
      public PaymentMode paymentMode { get; set; }



        
     }
}
