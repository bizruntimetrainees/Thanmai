using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DhanalakshmiBank.Models
{
    public class Customer
    {
        public Int32 CustomerId {get; set;}
        public string Name { get; set; }

        public DateTime DOB { get; set; }
        public string PAN { get; set; }

        public Int64 Phone { get; set; }
        public string Email { get; set; }

        public string LoginId { get; set; }
        public string Password { get; set; }

    }
}