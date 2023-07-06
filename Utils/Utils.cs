using Repository.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ProjectPRN211
{

    public class Utils
    {

        public static List<string> errorMes;

        public static void resetErrorMes()
        {
            errorMes = new List<string>();
        }
        public static bool isEmpty(String str)
        {
            try
            {
                if (!errorMes.Contains("All field must not be empty") && string.IsNullOrWhiteSpace(str) &&
                    !errorMes.Contains("No special characters allowed in name") &&
                    !errorMes.Contains("No number at the first character in name"))
                    errorMes.Add("All field must not be empty");
                return string.IsNullOrWhiteSpace(str);
            }
            catch (Exception e)
            {
                errorMes = new List<string>();
                errorMes.Add("All field must not be empty");
                return false;
            }
        }


        public static string ProcessName(String txtName)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            if (Regex.IsMatch(txtName, @"[^a-zA-Z\s\d]"))
            {
                errorMes.Add("No special characters allowed in name");
                return "";
            }

            if (char.IsDigit(txtName, 0))
            {
                errorMes.Add("No number at the first character in name");
                return "";
            }
            String name = textInfo.ToTitleCase(ProcessDes(txtName));
            return name;
        }
        public static String ProcessDes(String txtDes)
        {
            String pattern = @"\s+";
            String des = Regex.Replace(txtDes, pattern, " ");
            return des.Trim();
        }

        public static int ProcessHourlyWage(String txtHourlyWage)
        {
            try
            {
                int hourlyWage = int.Parse(txtHourlyWage);
                return hourlyWage;
            }
            catch
            {
                errorMes.Add("Hourly Wage must be a natural number");
                return -1;
            }
        }


        public static bool ProcessEmail(String txtEmail)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Match the email against the regular expression
            Match match = regex.Match(txtEmail);
            if (!match.Success) errorMes.Add("Email must follow this format 'email@email.com'");
            // Check if the email matches the pattern
            return match.Success;
        }

        public static bool ProcessPhone(String txtPhone)
        {
            String numWithoutSpace = txtPhone.Replace(" ", "");
            String pattern = @"^[0-9]{9,11}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(numWithoutSpace);
            if (!match.Success) errorMes.Add("Phone Number lenght is between 9 and 11");
            return match.Success;
        }
        public static Boolean  ProcessInput(string txtName, string txtHourlyWage, string txtPhone, string txtEmail)
        {
            Boolean result = false;
            string name = "";
            int hourlyWage = -1;
            string phone = "";
            string email = "";

            if (!isEmpty(txtName))
            {
                name = ProcessName(txtName);
            }

            if (!isEmpty(txtPhone) && ProcessPhone(txtPhone))
            {
                phone = txtPhone;
            }
            if (!isEmpty(txtHourlyWage))
            {
                hourlyWage = ProcessHourlyWage(txtHourlyWage);
            }

            if (!isEmpty(txtEmail) && ProcessEmail(txtEmail))
            {
                email = txtEmail;
            }

            if (isEmpty(name)|| isEmpty(phone) || isEmpty(email) || hourlyWage == -1)
                result = true;
            return result;
        }

    }
}
