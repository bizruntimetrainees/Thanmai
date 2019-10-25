using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DhanalakshmiBank.Models
{
    public class Transaction
    {
        public Int32 Id {get; set;}
        public Account Account { get; set; }
        public DateTime TranDate { get; set; }
        public string Narration { get; set; }
        public Int64 ChqNo { get; set; }
        public DateTime ChqDate { get; set; }
        public string ChqDraweeBank { get; set; }
        public double Amount { get; set; }
        public bool Debit { get; set; }
        public bool Credit { get; set; }

        public string ChequeDetails()
        {
            return this.ChqNo + "  " + this.ChqDate + "  " + this.ChqDraweeBank; 
        }

    }
}