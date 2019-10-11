using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Interface
{
    public interface IBankOperations
    {
        string Withdraw(Int32 withdrawalAmount);
        Int32 Deposit(Int32 depositAmount);
    }


    public class ICICIBank : IBankOperations
    {

        public Int32 BalanceAmount { get; set; }

        public string Withdraw(Int32 withdrawalAmount)
        {
            if (withdrawalAmount >= BalanceAmount)
            {
                return "Sorry /!.. Cannot Withdraw Amount as " + withdrawalAmount.ToString() + " is greater than " + BalanceAmount.ToString();
            }
            else
            {
                BalanceAmount -= withdrawalAmount;
                return BalanceAmount.ToString();
            }
        }


        public Int32 Deposit(Int32 depositAmount)
        {

            BalanceAmount += depositAmount;
            return BalanceAmount;
        }


    }


    public class CanaraBank : IBankOperations
    {

      

        public Int32 BalanceAmount
        {
            get;
            set;
        }

        public string Withdraw(Int32 withdrawalAmount)
        {
            if (withdrawalAmount >= BalanceAmount)
            {
                return "Sorry /!.. Cannot Withdraw Amount as " + withdrawalAmount.ToString() + " is greater than " + BalanceAmount.ToString();
            }
            else
            {
                BalanceAmount -= withdrawalAmount;
                return "Withdrawn successfully......Balance Amount: " + BalanceAmount.ToString();
            }
        }

        public Int32 Deposit(Int32 depositAmount)
        {
            BalanceAmount += depositAmount;
            return BalanceAmount;
        }

    }
    class Collection_Demo
    {
        static void Main(string[] args)
        {
            IBankOperations canara = new CanaraBank();
            IBankOperations icici = new ICICIBank();


            // ...DEPOSITS...
            Console.WriteLine("Canara Bank deposit is..");
            Console.WriteLine(canara.Deposit(100000));
            Console.WriteLine("ICICI Bank deposit is..");
            Console.WriteLine(icici.Deposit(100000));

            //...OPERATIONS...
            Console.WriteLine("ICICI Bank Withdraw is..");
            Console.WriteLine(canara.Withdraw(40000));
            Console.WriteLine("Canara Bank Withdraw is..");
            Console.WriteLine(canara.Withdraw(100001));
                
            Console.ReadLine();
        }
    }
}
