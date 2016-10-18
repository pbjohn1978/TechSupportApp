using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport;

namespace TechSupportApp.Classes
{
    public static class HelperDB
    {
        /// <summary>
        /// Code By: BeekerMeMeMe
        /// this methoud takes in no arguments and returns a List<Customer> ... :)
        /// </summary>
        /// <returns> this methoud returns a List<Customer> (a list of customer objects) </returns>
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            //Van Halen: Dreams :)
            SqlConnection con = new SqlConnection( GetConnectionString() );
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT[CustomerID],[Name],[Address],[City],[State],[ZipCode],[Phone],[Email]
FROM[TechSupport].[dbo].[Customers]";

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Customer cust = new Customer();
                        cust.CustomerID = rdr.GetInt32(0);
                        cust.Name = rdr.GetString(1);
                        cust.Address = rdr.GetString(2);
                        cust.City = rdr.GetString(3);
                        cust.State = rdr.GetString(4);
                        cust.ZipCode = rdr.GetString(5);
                        if (rdr.GetString(6) != null)
                        {
                            cust.Phone = rdr.GetString(6);
                        }
                        else
                        {
                            cust.Phone = "***no phone listed in database***";
                        }
                        if (rdr.GetString(7) != null)
                        {
                            cust.Email = rdr.GetString(7);
                        }
                        else
                        {
                            cust.Phone = "***no email listed in database***";
                        }
                        customers.Add(cust);
                    }
                }
                else
                {
                    Console.WriteLine("umm, so ya... something messed up... i wasn't able to get anything from the db... sorry! :(");
                }
            }
            catch(Exception ex)
            {
                throw ex; //this is a catch all exception... i shouldn't be using this... hehe... but i like being bad... :)
            }
            finally
            {
                con.Close();
            }

            return customers;
        }
        /// <summary>
        /// Code By: BeekerMeMe
        /// this code takes in no arguments and returns the connection string to Database server...
        /// 
        /// Future Note: for the production version we will need to change the connection string to the Production Servers connection string
        ///     this string is for LocalHost during the devolpment process... :)
        /// 
        /// </summary>
        /// <returns>String representing the Connection String to the Database Sever :) </returns>
        public static string GetConnectionString()
        {
            return @"Data Source=DESKTOP-GNOQRKG\SQLEXPRESS;Initial Catalog=TechSupport;Integrated Security=True";
        }
    }
}
