using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elementes are....");

            ICustomer cus = new Customer();
            List<Customer> c = new List<Customer>()
            {   new Customer { Id = 100, Name = "Anitha", num = 895623},
                new Customer { Id = 101, Name = "Bhanu", num = 895624},
                new Customer { Id = 102, Name = "Chandana", num = 895625},
                new Customer { Id = 103, Name = "Dhanush", num = 895626},
            };

            foreach (var s in c)
            {
                Console.WriteLine(s.Id+" "+s.Name+"   "+s.num);
            }
            Console.WriteLine();
            Console.WriteLine("Total Customers: {0}", c.Count);


            Console.WriteLine();
            Console.WriteLine("Method is called");
            Console.WriteLine(cus.GetCustomerDetails(105,"Ganesh",895627));

            Console.ReadKey();

        }
    }
}
