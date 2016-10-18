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
            //TODO: make the connection to db and populate the list here... :)
            //Van Halen: Dreams :)



            return customers;
        }
        /// <summary>
        /// Code By: BeekerMeMe
        /// this code takes in no arguments and returns a string representing the Connection string for the Database... 
        /// Currentlly it is returning a connection to personal computers for development purposses... for the production version this methoud will be the only place
        /// that code needs to be changed (whatever db server we are using in the futureseses...) :)
        /// </summary>
        /// <returns>String representing the Connection String to the Database Sever :) </returns>
        public static string GetConnectionString()
        {
            return "Data Source=DESKTOP-GNOQRKG\\SQLEXPRESS;Initial Catalog=TechSupport;Integrated Security=True";
        }
    }
}
