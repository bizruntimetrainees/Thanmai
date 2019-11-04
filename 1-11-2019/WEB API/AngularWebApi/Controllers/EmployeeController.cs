using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AngularWebApi.Models;

namespace AngularWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();
            string query = @"select EmployeeID,EmployeeName,Department,MailID, convert(DATETIME,DOJ,120) as DOJ from dbo.Employees";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Employee emp)
        {
            try
            {
                DataTable table = new DataTable();
                string query = @"insert into dbo.Employees 
                                (
                                EmployeeName,
                                Department,
                                MailID,
                                DOJ)
                                Values
                                (
                                    ' " + emp.EmployeeName + @" ',
                                    ' " + emp.Department + @" ' ,
                                    ' " + emp.MailID + @"'  ,
                                    ' " +Convert.ToDateTime(emp.DOJ)+ @"'
                                )";

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Added Successfully";
            }
            catch(Exception ex)
            {
                return "Failed to Add";
            }
        }
    }
}
