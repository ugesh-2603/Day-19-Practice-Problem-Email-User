using System.Text.RegularExpressions;

namespace Day_19_Practice_Problem_Email_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Email & User Registration");
            string firstName = GetUserInput("Enter a first name:");
            string lastName = GetUserInput("Enter a last name:");
            string email = GetUserInput("Enter an email address:");
            string mobileNumber = GetUserInput("Enter a mobile number (with country code):");
            string password = GetUserInput("Enter a password:");

            if (IsValidFirstName(firstName) && IsValidLastName(lastName) && IsValidEmail(email) && IsValidMobileNumber(mobileNumber) && IsValidPassword(password))
            {
                Console.WriteLine("Valid inputs.");
            }
            else
            {
                Console.WriteLine("Invalid inputs.");
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static bool IsValidFirstName(string firstName)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(firstName, pattern);
        }

        public static bool IsValidLastName(string lastName)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(lastName, pattern);
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-]?[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidMobileNumber(string mobileNumber)
        {
            string pattern = @"^\+\d{1,3}\d{9}$";
            return Regex.IsMatch(mobileNumber, pattern);
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8;
            return false;

            bool hasUppercase = false;
            bool hasNumericDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    if (char.IsUpper(c))
                        hasUppercase = true;

                    if (char.IsDigit(c))
                        hasNumericDigit = true;

                    if (hasUppercase && hasNumericDigit)
                        break;
                }

                return hasUppercase && hasNumericDigit;
            }
        }
    }

}


    
