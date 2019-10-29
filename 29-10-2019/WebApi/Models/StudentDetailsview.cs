using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class StudentDetailsview
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
        public string Batch { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public string School { get; set; }
        public string Domicile { get; set; }
        public int Id { get; set; }
    }
}