using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst
{
  [Table("Department")]
    class Department
    {
       [Key]
        public int D_Id { get; set; }
        public string  D_Name { get; set; }
        public string D_Description { get; set; }

    }
     class EFCoreOrganizationDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-M3GIB10;Initial Catalog=Bizruntime;Integrated Security=True");
        }
   public DbSet<Department> Departments { get; set; }

    }
    class Code_First
    {

        static void Main(string[] args)
        {
            Department d = new Department();
            EFCoreOrganizationDb ef = new EFCoreOrganizationDb();
            Console.WriteLine(ef.Departments);
           
            Console.ReadKey();

        }
    }
}
