using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //PIN Validator
            Console.WriteLine("Enter a PIN between 4 and 8 digits inclusive.");
            string pin = Console.ReadLine();
            bool isDigit = true;
            while (true)
            {
                foreach (var digit in pin)
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
            bool validPin = pin.Length >= 4 && pin.Length <= 8 && isDigit == true;

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
            var userNumber = Console.ReadLine();
            bool isPhoneDigit = true;
            var phoneNumber = userNumber.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            while (true)
            {
                foreach (var digit in phoneNumber)
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
            bool validPhone = phoneNumber.Length == 10 && isPhoneDigit == true;

            if (validPhone == true)
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

            bool IsValidEmail(string email)
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