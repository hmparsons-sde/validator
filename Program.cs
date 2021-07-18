using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //PIN Validator
            Console.WriteLine("Enter a PIN between 4 and 8 digits inclusive.");
            string pin = Console.ReadLine(); // reads user input
            bool isDigit = true; // digit is a boolean; isDigit is a method to determine if the char is a number
            while (true)
            {
                foreach (var digit in pin) // checks each entered digit char
                {
                    if (Char.IsDigit(digit))
                    {
                        isDigit = true;
                    }
                    else
                    {
                        isDigit = false;
                        break;
                    }
                    break;
                }
                break;
            }
            bool validPin = pin.Length >= 4 && pin.Length <= 8 && isDigit == true; // conditions for a valid pin, per instructions in Notion

            if (validPin == true)
            {
                Console.WriteLine("Your PIN number is valid");
            }
            else
            {
                Console.WriteLine("Your PIN number is invalid");
            }

            //Phone Number Validator
            Console.WriteLine("Enter a phone number");
            var userNumber = Console.ReadLine(); // read user input
            bool isPhoneDigit = true;
            var phoneNumber = userNumber.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", ""); // replace any extraneous characters with empty
            while (true)
            {
                foreach (var digit in phoneNumber) // checks that each remaining char is a number
                {
                    if (Char.IsDigit(digit))
                    {
                        isPhoneDigit = true;
                    }
                    else
                    {
                        isPhoneDigit = false;
                        break;
                    }
                    break;
                }
                break;
            }
            bool validPhone = phoneNumber.Length == 10 && isPhoneDigit == true; // conditions for valid phone number

            if (validPhone == true) // command line output
            {
                Console.WriteLine("Your phone number is valid");
            }
            else
            {
                Console.WriteLine("Your phone number is invalid");
            }

            //Email Validator
            Console.WriteLine("Enter an email address");
            var userEmail = Console.ReadLine();

            bool IsValidEmail(string email) // same as above; check for email format; using try/catch as practice :)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            if (IsValidEmail(userEmail) == true)
            {
                Console.WriteLine("Your email is valid");
            }
            else
            {
                Console.WriteLine("Your email is invalid");
            }
        }
    }
}