using System.Text.RegularExpressions;

namespace Day_19_Practice_Problem_Email_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Email & User Registration");

            string firstName = GetUserInput();

            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }
        }

        public static string GetUserInput()
        {
            Console.WriteLine("Enter a first name:");
            return Console.ReadLine();
        }

        public static bool IsValidFirstName(string firstName)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(firstName, pattern);
        }
    }
    
}