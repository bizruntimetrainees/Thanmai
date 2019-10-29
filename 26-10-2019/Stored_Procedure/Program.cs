using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stored_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-M3GIB10; Initial Catalog = Bizruntime; Integrated Security = True");
            
        /*    string query = @"create procedure Insert_records
                            (
                              @Id int,
                              @Name varchar(50),
                              @Subject varchar(50) 
                            )

                            as

                            insert into Student (Id,Name,Subject) values(@Id,@Name,@Subject)";


            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored procedure created Successfulley for inserting");

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                con.Close();
                Console.ReadKey();
            }*/

            
            /* string query2 = @" create procedure Retrieve_Record_Proc
                               (
                                @Id int,
                                @Name varchar(50),
                                @Subject varchar(50) 
                               )
                                AS
                            select * from Student where Name=@Name";
            SqlCommand cmd = new SqlCommand(query2, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored procedure created Successfulley for inserting");

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                con.Close();
                Console.ReadKey();
            }
            */


          SqlCommand cmd2 = new SqlCommand("Insert_records", con);
            try
            {
                con.Open();
                cmd2.CommandType = CommandType.StoredProcedure;
                
                cmd2.Parameters.Add(new SqlParameter("@Id", 200));
                cmd2.Parameters.Add(new SqlParameter("@Name", "Raaj"));
                cmd2.Parameters.Add(new SqlParameter("@Subject", "Maathss"));
                int i = cmd2.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Records Inserted Successfully.");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }

            try
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("Retrieve_Record_Proc", con);
                cmd3.CommandType = CommandType.StoredProcedure;
              cmd3.Parameters.Add(new SqlParameter("@Name", "Ram"));
                SqlDataReader dr = cmd3.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Id : " + dr[0]);
                    Console.WriteLine("Name : " + dr[1].ToString());
                    Console.WriteLine("Subject : " + dr[2].ToString());

                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }

        }
    }
}
