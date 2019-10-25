using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhanalakshmiBank.Models;

namespace DhanalakshmiBank.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> myCustomers;


        // GET: Customer
        public ActionResult Index()
        {


            if (Session["xyz"] == null)
            {
                List<Customer> customers = new List<Customer>()
                {

                new Customer{ CustomerId =100, Name ="Tanuja", DOB = Convert.ToDateTime("02/02/1995"), Email ="tanuja@gmail.com",PAN ="TRAQK45ERT",Phone= 63783838833, LoginId="TanujaRai", Password ="tanujarai@123"},
                new Customer{ CustomerId =101, Name ="Ram", DOB = Convert.ToDateTime("12/12/1996"), Email ="ramgorthi96@gmail.com",PAN ="CAEPG4171L",Phone= 9618080279, LoginId="RamGorthi", Password ="Ram@1412"},
                new Customer{ CustomerId =102, Name ="Venkatesh", DOB = Convert.ToDateTime("10/03/1996"), Email ="venky@gmail.com",PAN ="GEAU5467IT",Phone= 9865478901, LoginId="VenkyG", Password ="venkatesh.G@123"},
                new Customer{ CustomerId =103, Name ="Rakesh", DOB = Convert.ToDateTime("08/06/1995"), Email ="rakeshg@gmail.com",PAN ="YTIOK45ERT",Phone= 9842567801, LoginId="RakeshGoteti", Password ="rakeshG@123"},
                };
                Session["xyz"] = customers;
                return View(customers);
            }
            else
            {
                myCustomers = new List<Customer>();
                myCustomers = (List<Customer>)(Session["xyz"]);
                return View(myCustomers);
            }


        }




        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Create(string CustomerId, string Name, string DOB, string PAN, string Phone, string EMail, string LoginId, string Password)
        {

            myCustomers = new List<Customer>();
            myCustomers = (List<Customer>)(Session["xyz"]);


            Customer tempcust = new Customer();
            tempcust.CustomerId = Convert.ToInt32(CustomerId);
            tempcust.Name = Name;
            tempcust.DOB = Convert.ToDateTime(DOB);
            tempcust.PAN = PAN;
            tempcust.Phone = Convert.ToInt64(Phone);
            tempcust.Email = EMail;
            tempcust.LoginId = LoginId;
            tempcust.Password = Password;

            myCustomers.Add(tempcust);

            Session["xyz"] = myCustomers;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Int32 id)
        {
            myCustomers = new List<Customer>();
            myCustomers = (List<Customer>)(Session["xyz"]);

            Customer cust = new Customer();
            cust = myCustomers.First(s => s.CustomerId == id);

            return View(cust);
        }


        [HttpPost]
        public ActionResult Edit(Customer cust)
        {
            myCustomers = new List<Customer>();
            myCustomers = (List<Customer>)(Session["xyz"]);


            myCustomers.RemoveAll(s => s.CustomerId == cust.CustomerId);
            myCustomers.Add(cust);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(Int32 id)
        {
            myCustomers = new List<Customer>();
            myCustomers = (List<Customer>)(Session["xyz"]);

            Customer cust = new Customer();
            cust = myCustomers.First(s => s.CustomerId == id);

            Session["Itemtobedeleted"] = cust;

            return View(cust);

        }

        [HttpPost]
        public ActionResult Delete()
        {
            myCustomers = new List<Customer>();
            myCustomers = (List<Customer>)(Session["xyz"]);

            Customer delcust = (Customer)Session["Itemtobedeleted"];


            myCustomers.Remove(delcust);


            return RedirectToAction("Index");

        }



    }
}