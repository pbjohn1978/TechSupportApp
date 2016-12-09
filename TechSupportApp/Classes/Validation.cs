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
        public IEnumerable<Control> Controls { get; private set; }
        private static String states = "|AL|AK|AS|AZ|AR|CA|CO|CT|DE|DC|FM|FL|GA|GU|HI|ID|IL|IN|IA|KS|KY|LA|ME|MH|MD|MA|MI|MN|MS|MO|MT|NE|NV|NH|NJ|NM|NY|NC|ND|MP|OH|OK|OR|PW|PA|PR|RI|SC|SD|TN|TX|UT|VT|VI|VA|WA|WV|WI|WY|";


        public static bool IsValidCustomer(Customer customer)
        {
            if (!isStateAbbreviation(customer.State.ToString()))
            {
                MessageBox.Show("The state entered is not a Valid state code.");
                return false;
            }
            if( !customer.Email.Equals("") )
                if( !IsValidEmail(customer.Email) )
                     return false;
            return true;
        }
        
        public static bool isStateAbbreviation(String state)
        {
            return state.Length == 2 && states.IndexOf(state) > 0;
        }


        public bool IsValidTechnician(Technicians tech)
        {
            if(!IsValidEmail(tech.Email.ToString()))
            {
                return false;
            }
            if(!IsValidPhoneNumber(tech.Phone.ToString()))
            {
                return false;
            }
            return true;
        }

        public bool CheckForNullTextBoxes()
        {
            string emptyTextBoxList = "";
            bool notNullField = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        emptyTextBoxList += c + Environment.NewLine;
                        notNullField = false;
                    }
                }
            }
            if (!notNullField)
            {
                MessageBox.Show("The following fields are required: " + Environment.NewLine + emptyTextBoxList);
                return false;
            }
            return true;
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

        #region Product Validation

        public static bool IsValidProduct(string prodCode, string prodName, decimal version, DateTime relDate)
        {
            if (!IsValidProductCode(prodCode))
            {
                return false;
            }
            if (!IsValidProductName(prodName))
            {
                return false;
            }
            if (!IsValidProductVersion(version))
            {
                return false;
            }
            if (!IsValidProductReleaseDate(relDate))
            {
                return false;
            }
            return true;          

        }

        public static bool IsValidProductCode(string prodCode)
        {
            Regex r = new Regex("^[A-Z0-9]*$");
            if (r.IsMatch(prodCode))
            {
                return true;
            }
            MessageBox.Show("Please make sure Product code is all caps and only contains alphanumeric characters.");
            return false;
        }

        public static bool IsValidProductName(string prodName)
        {
            Regex r = new Regex("^[^±!@£$%^&*_+§¡€#¢§¶•ªº«\\/<>?:;|=,]{1,30}$");
            if (r.IsMatch(prodName))
            {
                return true;
            }
            MessageBox.Show("Please make sure Name doesn't contain any special characters and is between 1 and 30 characters in length.");
            return false;
        }

        public static bool IsDecimal(string version)
        {
            decimal number;
            if (!decimal.TryParse(version, out number))
            {
                MessageBox.Show("Version must only contain numbers");
                return false;
            }
            int num;
            if (int.TryParse(version, out num))
            {
                MessageBox.Show("Version number must be in decimal format.");
                return false;
            }
            return true;
        }

        public static bool IsValidProductVersion(decimal version)
        {
            

            if (version <= 0)
            {
                MessageBox.Show("Version number must be greater than 0");
                return false;
            }
            return true;
            
        }

        public static bool IsValidProductReleaseDate(DateTime relDate)
        {
            if (relDate.Year < 2000 && relDate.Year > (DateTime.Now.Year + 10))
            {
                MessageBox.Show("Please enter a reasonable year :)");
                return false;
            }
            return true;
        }

        #endregion


    }

}
