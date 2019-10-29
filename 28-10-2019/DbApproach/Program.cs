using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BizruntimeEntities())
            {

                var query = from b in db.StudentDetails
                            select b;

                Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine( item.StudentId+ " " +item.FirstName + " " + item.LastName + " " + item.Age + " " + item.Gender + " " + item.Batch + " " + item.Address+ " " + item.Class+ " " + item.Domicile);
                }

                Console.WriteLine("Press any key to exit...");
            }
            Console.ReadKey();

        }
    }
}
