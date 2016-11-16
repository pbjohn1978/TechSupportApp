using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechSupport;

namespace TechSupportApp.Classes
{
    public class Validation
    {
        public static bool IsValidCustomer(Customer customer)
        {
            bool isValidInfo = true;

           

            return isValidInfo;
        }
        public static bool IsValidZipCode(string zipCode)
        {
            string regexPattern = @"^(\d{5})(-\d{4})?$";
            Match validZipCode = Regex.Match(zipCode, regexPattern);
            if (!validZipCode.Success)
            {
                MessageBox.Show("Invalid email address. Please enter valid zip code");
                return false;
            }
            return true;
        }
        public static bool IsValidEmail(string email)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Match validEmail = Regex.Match(email, regexPattern);
            if (!validEmail.Success)
            {
                MessageBox.Show("Invalid email address");
                return false;
            }
            return true;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string regexPattern = "^(?([0-9]{3}))?[-]?([0-9]{3})[-]?([0-9]{4})$";
            Match validPhoneNumber = Regex.Match(phoneNumber, regexPattern);
            if (!validPhoneNumber.Success)
            {
                MessageBox.Show("Invalid phone number.  Please enter in valid format:  xxx-xxx-xxxx");
                return false;
            }
            return true;
        }

    }

}
