using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhanalakshmiBank.Models;

namespace DhanalakshmiBank.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        //Action method.
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult EmployeeDetails()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id = 108, Name ="Puneeth",Phone="6378398133",EMail="puneeth.reddy@gmail.com",Address="Whitefield,  Bengaluru"},
                new Employee{ Id = 109, Name ="Ram Gorthi",Phone="6378398133",EMail="puneeth.reddy@gmail.com",Address="Whitefield,Bengaluru"},
                new Employee{ Id = 109, Name ="Likhitha",Phone="3442424222",EMail="sddsds@gmail.com",Address="Whitefield,  Bengaluru" },
                new Employee{ Id = 109, Name ="Kanith",Phone="6378398133",EMail="puneeth.reddy@gmail.com",Address="Whitefield,  Bengaluru" },
                new Employee{ Id = 109, Name ="Tanmai",Phone="6378398133",EMail="puneeth.reddy@gmail.com",Address="Whitefield,  Bengaluru" },
                new Employee{ Id = 109, Name ="Tanuja Rai",Phone="6378398133",EMail="puneeth.reddy@gmail.com",Address="Whitefield,  Bengaluru" }

            };

            ViewBag.Employees = employees;

            return View();
        }


        public ActionResult CustomerDetail()
        {
            return View();

        }



    }
}
