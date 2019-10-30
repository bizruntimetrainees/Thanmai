using System;
using System.Collections.Generic;

namespace Database_First.Models
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime? Dob { get; set; }
    }
}
