using System.Text.RegularExpressions;

namespace Day_19_Practice_Problem_Email_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lastName = GetUserInput();

            if (IsValidLastName(lastName))
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name.");
            }
        }

        public static string GetUserInput()
        {
            Console.WriteLine("Enter a last name:");
            return Console.ReadLine();
        }

        public static bool IsValidLastName(string lastName)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(lastName, pattern);
        }

    }

}