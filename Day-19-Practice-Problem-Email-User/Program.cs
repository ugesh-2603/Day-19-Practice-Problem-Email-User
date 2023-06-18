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
            

            if (IsValidFirstName(firstName) && IsValidLastName(lastName))
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

       
    }
}