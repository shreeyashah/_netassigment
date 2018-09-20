﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class BillCatagory
    {
        public int BillCatagoryId { get; set; }
        public string BillCatagoryName { get; set; }
        public string CatagoryOptionName { get; set; }

        [ForeignKey("CatagoryOptionId")]
        public CatagoryOption CatagoryOption { get; set; }
    }
}
