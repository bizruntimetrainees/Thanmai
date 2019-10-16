 

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Asynchronious

{

    class Program

    {

        public static void Main(String [] args)

        {
			
			 Task t1= new Task(

                () => {

                       System.Threading.Thread.Sleep(5000);

                       Console.WriteLine("Huge Task Finish"); 

                     }

                );

 


            t1.Start();

            //Wait for finish the Task

            t2.Wait();

            Console.ReadLine();
			

            Task t2 = new Task(

                () => {

                       System.Threading.Thread.Sleep(5000);

                       Console.WriteLine("Huge Task Finish"); 

                     }

                );

 


            t2.Start();

            //Wait for 1 second

            bool rValue = t.Wait(1000);

            Console.WriteLine("Main Process Finished");

            Console.ReadLine();

        }

    }

}