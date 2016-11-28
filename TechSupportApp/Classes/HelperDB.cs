using System;
using System.Configuration;
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
        /// this methoud takes in no arguments and returns a List<Customer> ... 
        /// </summary>
        /// <returns> this methoud returns a List<Customer> (a list of customer objects) </returns>
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            //Van Halen: Dreams :)
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT[CustomerID],[Name],[Address],[City],[State],[ZipCode],[Phone],[Email]
FROM[TechSupport].[dbo].[Customers]
Order by [Name] asc";

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
            catch (Exception ex)
            {
                throw ex; //this is a catch all exception... i shouldn't be using this... hehe... but i like being bad... :)
            }
            finally
            {
                con.Close();
            }

            return customers;
        }
        

        public static SqlConnection GetConnectionStringAppConfig()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return con;
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
        public static bool AddOrUpdateCustomerInDB(Customer cust)
        {
            bool isInDB = false;
            //the following if statement will update the customers info if true
            //if false it will add the New Customer to the database... :)
            if (HelperDB.IsCustInDB(cust))
            {
                SqlConnection con = GetConnectionStringAppConfig();
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
                SqlConnection con = GetConnectionStringAppConfig();
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
            bool isCustInTheDB;

            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT[CustomerID]
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

        /// <summary>
        /// 
        /// Code By: BeekerMeMe
        /// 
        /// takes in a INT representing the customer ID of the customer to be deleted... it will return true if deleted successfully and false if there was an issue with the
        /// query or if 0 was delete or if more than one was deleted
        /// NOTE: because CustomerID is a primary key in the db it will NEVER delete more than one customer this is why we will can assume that
        /// this methoud will only return true=deletedSuccefully or false=NoneDeleted
        /// </summary>
        /// <param name="custID">INT</param>
        /// <returns>bool</returns>
        public static bool DeleteCustomer(int custID)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            SqlCommand cmd3 = new SqlCommand();
            cmd1.Connection = con;
            cmd2.Connection = con;
            cmd3.Connection = con;

            cmd1.CommandText = @"DELETE FROM [dbo].[Incidents]
WHERE CustomerID = @custid1";

            cmd2.CommandText = @"DELETE FROM [dbo].[Customers]
WHERE CustomerID = @custid2";

            cmd3.CommandText = @"DELETE FROM [dbo].[Registrations]
WHERE CustomerID = @custid3";

            cmd1.Parameters.AddWithValue("@custid1", custID);
            cmd2.Parameters.AddWithValue("@custid2", custID);
            cmd3.Parameters.AddWithValue("@custid3", custID);

            try
            {
                con.Open();
                int rows1 = cmd1.ExecuteNonQuery();
                int rows3 = cmd3.ExecuteNonQuery();
                int rows2 = cmd2.ExecuteNonQuery();
                if (rows2 == 1){
                    return true;
                }else{
                    return false;
                }
            }
            finally
            {
                con.Dispose();
            }
        }



        ///<summary>
        ///Code by: R. Richards
        ///Technician CRUD functionality
        /// </summary>



        ///<summary>
        ///Incidents CRUD Functionality
        /// </summary>
        ///TODO:  Connect Customer Name, Product Name and Technician Name to display for easy reference
        public static List<Incidents> GetIncidents()
        {
            using (SqlConnection con = GetConnectionStringAppConfig())
            {
               
                SqlCommand selQuery = new SqlCommand();
                selQuery.Connection = con;
                selQuery.CommandText =
                    @"
                    SELECT Incidents.IncidentID, Incidents.CustomerID, Customers.Name, Incidents.ProductCode, Products.Name,
	                    Incidents.TechID, Technicians.Name, Incidents.DateOpened, Incidents.DateClosed, Incidents.Title, Incidents.Description
                    FROM Incidents JOIN Customers
                    ON Customers.CustomerID = Incidents.CustomerID
                    JOIN Products
                    ON Incidents.ProductCode = Products.ProductCode
                    JOIN Technicians
                    ON Incidents.TechID = Technicians.TechID
                    ";
                con.Open();
                SqlDataReader rdr = selQuery.ExecuteReader();
                List<Incidents> incidents = new List<Incidents>();
                while (rdr.Read())
                {
                    Incidents tempIncident = new Incidents();
                    tempIncident.IncidentID = (int)rdr["@Incidents.IncidentID"];
                    tempIncident.CustomerID = (int)rdr["@Incidents.CustomerID"];
                    tempIncident.CustomerName = rdr["@Customers.Name"].ToString();
                    tempIncident.ProductCode = rdr["@Incidents.ProductCode"].ToString();
                    tempIncident.ProductName = rdr["@Products.Name"].ToString();
                    tempIncident.TechID = (int)rdr["@Incidents.TechID"];
                    tempIncident.TechName = rdr["@Technicians.Name"].ToString();
                    tempIncident.DateOpened = (DateTime)rdr["@Incidents.DateOpened"];
                    tempIncident.DateClosed = (DateTime)rdr["@Incidents.DateClosed"];
                    tempIncident.Title = rdr["@Incidents.Title"].ToString();
                    tempIncident.Description = rdr["@Incidents.Description"].ToString();
                    incidents.Add(tempIncident);
                }
                return incidents;
            }
        }

        public static bool DeleteIncident(int id)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand delete = new SqlCommand();
            delete.CommandText = @"
                DELETE Incidents
                WHERE IncidentID = @incidentID
                ";
            delete.Parameters.AddWithValue("@incidentID", id);

            try
            {
                con.Open();
                int rows = delete.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    ErrorMessage("delete");
                    return false;
                }
            }
            finally
            {
                con.Dispose();
            }

        }

        public static string ErrorMessage(string dbQueryType)
        {
            return "Unable to execute " + dbQueryType + ". Please try again.  If error persists, please contact IT.";//i want to change this to a c#6 string... they are so much prettier... hehe... but i won't... :P :) 
        }

        #region Products

        /// <summary>
        /// adds a product to the database
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool AddProduct(Product prod)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand insert = new SqlCommand();
            insert.Connection = con;
            bool success = false;
            insert.CommandText = @"
                                    INSERT INTO Products
                                        (ProductCode, Name, Version, ReleaseDate)
                                    VALUES
                                        (@ProdCode, @Name, @Version, @RelDate)
                                  ";
            insert.Parameters.AddWithValue("@ProdCode", prod.ProductCode);
            insert.Parameters.AddWithValue("@Name", prod.Name);
            insert.Parameters.AddWithValue("@Version", prod.Version);
            insert.Parameters.AddWithValue("@RelDate", prod.ReleaseDate);

            try
            {
                con.Open();
                int rows = insert.ExecuteNonQuery();
                if (rows == 1)
                {
                    success = true;
                }
            }
            catch (SqlException sqlex)
            {
                
                System.Windows.Forms.MessageBox.Show("Product Code is already in the database");
                
            }
            finally
            {
                con.Close();
            }
            return success;
        }
        /// <summary>
        /// takes in a product and deletes it from the database
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>true or false</returns>
        public static bool DeleteProduct(Product prod)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand delete = new SqlCommand();
            delete.Connection = con;
            delete.CommandText = @"
                                    DELETE FROM Products
                                    WHERE ProductCode = @ProdCode
                                  ";
            delete.Parameters.AddWithValue("@ProdCode", prod.ProductCode);

            try
            {
                con.Open();
                int rows = delete.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// returns a full list of all products in the database
        /// </summary>
        /// <returns>a list of products</returns>
        public static List<Product> GetProds()
        {
            List<Product> prods = new List<Product>();

            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [ProductCode]
                                        ,[Name]
                                        ,[Version]
                                        ,[ReleaseDate] 
                                FROM Products";

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.ProductCode = reader.GetString(0);
                        prod.Name = reader.GetString(1);
                        prod.Version = reader.GetDecimal(2);
                        prod.ReleaseDate = reader.GetDateTime(3);
                        
                        prods.Add(prod);
                    }
                }
                else
                {
                    Console.WriteLine("Unable to retrieve data from the database");
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

            return prods;

        }
        /// <summary>
        /// searches the database for a product
        /// mathcing the given productCode
        /// </summary>
        /// <param name="prodCode"></param>
        /// <returns>product object</returns>
        public static Product GetProdObjectFromCode(string prodCode)
        {
            Product produc = new Product();
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [ProductCode]
                                        ,[Name]
                                        ,[Version]
                                        ,[ReleaseDate] 
                                FROM Products
                                WHERE ProductCode = @prodCode";

            cmd.Parameters.AddWithValue("@prodCode", prodCode);


            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        produc.ProductCode = reader.GetString(0);
                        produc.Name = reader.GetString(1);
                        produc.Version = reader.GetDecimal(2);
                        produc.ReleaseDate = reader.GetDateTime(3);
                    }

                }
                else
                {
                    Console.WriteLine("Unable to retrieve data from the database");
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

            return produc;
        }
        /// <summary>
        /// searches the database for a product
        /// mathcing the given productName
        /// </summary>
        /// <param name="prodName"></param>
        /// <returns>product object</returns>
        public static Product GetProdObjectFromName(string prodName)
        {
            Product produc = new Product();
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [ProductCode]
                                        ,[Name]
                                        ,[Version]
                                        ,[ReleaseDate] 
                                FROM Products
                                WHERE Name = @prodName";

            cmd.Parameters.AddWithValue("@prodName", prodName);


            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        produc.ProductCode = reader.GetString(0);
                        produc.Name = reader.GetString(1);
                        produc.Version = reader.GetDecimal(2);
                        produc.ReleaseDate = reader.GetDateTime(3);
                    }

                }
                else
                {
                    Console.WriteLine("Unable to retrieve data from the database");
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

            return produc;

        }

        public static bool UpdateProduct(Product prod)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand update = new SqlCommand();
            update.Connection = con;
            update.CommandText = @"UPDATE Products SET 
                                    Name = @Name
                                    ,[Version] = @Version
                                    ,ReleaseDate = @RelDate
                                    WHERE ProductCode = @ProdCode";
            update.Parameters.AddWithValue("@ProdCode", prod.ProductCode);
            update.Parameters.AddWithValue("@Name", prod.Name);
            update.Parameters.AddWithValue("@Version", prod.Version);
            update.Parameters.AddWithValue("@RelDate", prod.ReleaseDate);

            try
            {
                con.Open();
                int rows = update.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        #endregion
        /// <summary>
        /// Searches the database for a customer
        /// matching the given customerName
        /// </summary>
        /// <param name="custName"></param>
        /// <returns>Customer object</returns>
        public static Customer GetCustObject(string custName)
        {
            Customer custom = new Customer();
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText =
                @"SELECT [CustomerID]
                            ,[Name]
                            ,[Address]
                            ,[City]
                            ,[State]
                            ,[ZipCode]
                            ,[Phone]
                            ,[Email]
                FROM[TechSupport].[dbo].[Customers]
                WHERE Name = @custName"
                ;

            cmd.Parameters.AddWithValue("@custName", custName);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    custom.CustomerID = reader.GetInt32(0);
                    custom.Name = reader.GetString(1);
                    custom.Address = reader.GetString(2);
                    custom.City = reader.GetString(3);
                    custom.State = reader.GetString(4);
                    custom.ZipCode = reader.GetString(5);
                    if (reader.GetString(6) != null)
                    {
                        custom.Phone = reader.GetString(6);
                    }
                    else
                    {
                        custom.Phone = "***no phone listed in database***";
                    }
                    if (reader.GetString(7) != null)
                    {
                        custom.Email = reader.GetString(7);
                    }
                    else
                    {
                        custom.Phone = "***no email listed in database***";
                    }
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

            return custom;


        }

        #region Registrations

        /// <summary>
        /// Adds a Registration to the database
        /// </summary>
        /// <param name="cust"></param>
        /// <param name="prod"></param>
        /// <param name="regDate"></param>
        /// <returns></returns>
        public static bool AddRegistration(Customer cust, Product prod, DateTime regDate)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand insert = new SqlCommand();
            insert.Connection = con;
            bool Success = false;
            insert.CommandText =
                @"
                    INSERT INTO Registrations
                        (CustomerID, ProductCode, RegistrationDate)
                    VALUES
                        (@CustID, @ProdCode, @regdate)
                ";

            insert.Parameters.AddWithValue("@CustID", cust.CustomerID);
            insert.Parameters.AddWithValue("@ProdCode", prod.ProductCode);
            insert.Parameters.AddWithValue("@regDate", regDate);

            try
            {
                con.Open();
                int rows = insert.ExecuteNonQuery();
                if (rows == 1)
                {
                    Success = true;
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
                System.Windows.Forms.MessageBox.Show("Customer is already registered to this product");

            }
            finally
            {
                con.Close();
            }
            return Success;

        }

        /// <summary>
        /// searches the dateabase for a registration
        /// matching the given customer and product
        /// </summary>
        /// <param name="cust"></param>
        /// <param name="prod"></param>
        /// <returns>registration object</returns>
        public static Registration GetRegObject(Customer cust, Product prod)
        {
            Registration reg = new Registration();
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT CustomerID
                                    ,ProductCode
                                    ,RegistrationDate
                                FROM Registrations
                                WHERE CustomerID = @CustID
                                        AND
                                      ProductCode = @ProdCode";
            cmd.Parameters.AddWithValue("@CustID", cust.CustomerID);
            cmd.Parameters.AddWithValue("@ProdCode", prod.ProductCode);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reg.CustomerID = reader.GetInt32(0);
                        reg.ProductCode = reader.GetString(1);
                        reg.RegistrationDate = reader.GetDateTime(2);
                    }

                }
                else
                {
                    Console.WriteLine("Unable to retrieve data from the database");
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

            return reg;
        }
        /// <summary>
        /// deletes a registration object from the database
        /// </summary>
        /// <param name="reg"></param>
        /// <returns></returns>
        public static bool DeleteRegistration(Registration reg)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand delete = new SqlCommand();
            delete.Connection = con;
            delete.CommandText = @"
                DELETE Registrations
                WHERE CustomerId = @CustID
                    AND
                    ProductCode = @ProdCode
                ";
            delete.Parameters.AddWithValue("@CustID", reg.CustomerID);
            delete.Parameters.AddWithValue("@ProdCode", reg.ProductCode);

            try
            {
                con.Open();
                int rows = delete.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Gets a list of registrations from the database
        /// for a given product
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>list of registration objects</returns>
        public static List<Registration> GetRegistrations(Product prod)
        {
            List<Registration> registrations = new List<Registration>();
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT CustomerID
                                        ,ProductCode
                                        ,RegistrationDate
                                FROM Registrations
                                WHERE ProductCode = @ProdCode";
            cmd.Parameters.AddWithValue("@ProdCode", prod.ProductCode);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Registration reg = new Registration();
                        reg.CustomerID = reader.GetInt32(0);
                        reg.ProductCode = reader.GetString(1);
                        reg.RegistrationDate = reader.GetDateTime(2);

                        registrations.Add(reg);
                    }

                }
                else
                {
                    Console.WriteLine("Unable to retrieve data from the database");
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

            return registrations;
        }
        /// <summary>
        /// Gets a list of registrations from the database
        /// for a given customer
        /// </summary>
        /// <param name="cust"></param>
        /// <returns>list of registration objects</returns>
        public static List<Registration> GetRegistrations(Customer cust)
        {
            List<Registration> registrations = new List<Registration>();
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT CustomerID
                                        ,ProductCode
                                        ,RegistrationDate
                                FROM Registrations
                                WHERE CustomerID = @CustID";
            cmd.Parameters.AddWithValue("@CustID", cust.CustomerID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Registration reg = new Registration();
                        reg.CustomerID = reader.GetInt32(0);
                        reg.ProductCode = reader.GetString(1);
                        reg.RegistrationDate = reader.GetDateTime(2);

                        registrations.Add(reg);
                    }

                }
                else
                {
                    Console.WriteLine("Unable to retrieve data from the database");
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

            return registrations;
        }

        #endregion

        ///<summary>
        ///Created by R. Richards
        ///Technicians CRUD functionality
        /// </summary>

        public static List<Technicians> GetTechnicians()
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand selQuery = new SqlCommand();
            selQuery.Connection = con;
            selQuery.CommandText =
                @"
                    SELECT TechID, Name, Email, Phone
                    FROM Technicians
                    ";
            con.Open();
            SqlDataReader rdr = selQuery.ExecuteReader();
            List<Technicians> technicians = new List<Technicians>();
            while (rdr.Read())
            {
                Technicians tempTech = new Technicians();
                tempTech.TechID = (int)rdr["@TechID"];
                tempTech.Name = rdr["@Name"].ToString();
                tempTech.Email = rdr["@Email"].ToString();
                tempTech.Phone = rdr["@Phone"].ToString();

                technicians.Add(tempTech);
            }
            return technicians;
        }

        public static bool DeleteTechnician(int id)
        {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand delete = new SqlCommand();
            delete.CommandText = @"
                DELETE Technicians
                WHERE TechID = @techID
                ";
            delete.Parameters.AddWithValue("@techID", id);

            try
            {
                con.Open();
                int rows = delete.ExecuteNonQuery();
                if(rows == 1)
                {
                    return true;
                }
                else
                {
                    ErrorMessage("delete");
                    return false;
                }
            }
            finally
            {
                con.Dispose();
            }
        }

        public static bool AddTechnician(Technicians tech) {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand insert = new SqlCommand();
            insert.Connection = con;
            insert.CommandText = @"INSERT INTO Technicians(Name, Email, Phone) VALUES (@name, @email, @phone)";
            insert.Parameters.AddWithValue("@name", tech.Name);
            insert.Parameters.AddWithValue("@email", tech.Email);
            insert.Parameters.AddWithValue("@phone", tech.Phone);
            try
            {
                con.Open();
                int rows = insert.ExecuteNonQuery();
                if (rows == 1) {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                con.Dispose();
            }
        }

        public static bool UpdateTechnician(Technicians tech) {
            SqlConnection con = GetConnectionStringAppConfig();
            SqlCommand update = new SqlCommand();
            update.Connection = con;
            update.CommandText = @"UPDATE Technicians SET Name = @name, Email = @email, Phone = @phone) WHERE TechID = @id";
            update.Parameters.AddWithValue("@id", tech.TechID);
            update.Parameters.AddWithValue("@name", tech.Name);
            update.Parameters.AddWithValue("@email", tech.Email);
            update.Parameters.AddWithValue("@phone", tech.Phone);
            try
            {
                con.Open();
                int rows = update.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
