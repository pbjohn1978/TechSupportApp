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

        /// <summary>
        /// Code By: BeekerMeMe
        /// 
        ///     THROWS NOT IMPLEMENTED EXCEPTION!!!!!!
        /// 
        /// this methoud will take in a Customer Object and add it to the database... Please ensure that the Customer object is a valid Customer object 
        ///     AND THAT THE CUSTOMER ID NUMBER IS NOT TAKEN BEFORE CALLING THIS METHOUD... :)
        /// this methoud will work for updating a current customer or adding a new customer... just give it a customer object it'll take care of it for ya... :)
        /// </summary>
        /// <param name="cust"></param>
        /// <returns> bool : true = Customer added, False = Customer was NOT added</returns>
        public static bool AddCustomerToDB(Customer cust)
        {
            throw new NotImplementedException();
            bool isInDB = false;
            //the following if statement will update the customers info if true
            //if false it will add the New Customer to the database... :)
            if (HelperDB.IsCustInDB(cust))
            {   
                
                SqlConnection con = new SqlConnection(GetConnectionString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"UPDATE[dbo].[Customers] SET [Name] = @name , [Address] = @addre, [City] = @city , [State] = @state , [ZipCode] = @zipco , [Phone] = @phone , [Email] = @email
WHERE CustomerID = @id ";
                cmd.Parameters.AddWithValue("@id", cust.CustomerID.ToString());
                cmd.Parameters.AddWithValue("@addre", cust.Address);
                cmd.Parameters.AddWithValue("@city", cust.City);
                cmd.Parameters.AddWithValue("@email", cust.Email);
                cmd.Parameters.AddWithValue("@name", cust.Name);
                cmd.Parameters.AddWithValue("@phone", cust.Phone);
                cmd.Parameters.AddWithValue("@state", cust.State);
                cmd.Parameters.AddWithValue("@zipco", cust.ZipCode);
                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                        isInDB = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return isInDB;
            }
            else
            {
                SqlConnection con = new SqlConnection(GetConnectionString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"INSERT INTO [dbo].[Customers]([Name],[Address],[City],[State],[ZipCode],[Phone],[Email])
VALUES(@name,@addre,@city,@state,@zipco,@phone,@email)";

                cmd.Parameters.AddWithValue("@addre", cust.Address);
                cmd.Parameters.AddWithValue("@city", cust.City);
                cmd.Parameters.AddWithValue("@email", cust.Email);
                cmd.Parameters.AddWithValue("@name", cust.Name);
                cmd.Parameters.AddWithValue("phone", cust.Phone);
                cmd.Parameters.AddWithValue("@state", cust.State);
                cmd.Parameters.AddWithValue("zipco", cust.ZipCode);

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                        isInDB = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return isInDB;
            }
        }

        /// <summary>
        /// Code By: BeekerMeMe
        /// 
        ///     THROWS NOT IMPLEMENTED EXCEPTION!!!!!
        /// 
        /// this methoud will take in a Customer object an will return a bool representing weather or not the Customer is already in the db... :)
        ///     Please ensure the Customer is a valid Customer object before calling this methoud... :)
        /// </summary>
        /// <param name="cust">Customer Object</param>
        /// <returns>bool representing weather or not the customer is in the database</returns>
        public static bool IsCustInDB(Customer cust)
        {
            throw new NotImplementedException();
            bool isCustInTheDB;

            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT[CustomerID],[Name],[Address],[City],[State],[ZipCode],[Phone],[Email]
FROM[TechSupport].[dbo].[Customers]
where CustomerID=@custid";

            cmd.Parameters.AddWithValue("@custid", cust.CustomerID);

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    isCustInTheDB = true;
                }
                else
                {
                    isCustInTheDB = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return isCustInTheDB;
        }



    }
}
