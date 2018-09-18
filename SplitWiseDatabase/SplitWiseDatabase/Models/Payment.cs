using System;
using System.Collections.Generic;
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

      public PaymentMode PaymentMode { get; set; }



        
     }
}
