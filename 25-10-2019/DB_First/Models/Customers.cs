using System;
using System.Collections.Generic;

namespace DB_First
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime? Dob { get; set; }
    }
}
