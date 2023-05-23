using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public static class Validation
{
    public static void ValidateAccountNumber(ref string accountNumber, ref bool IsValidAccountNumber)
    {
        accountNumber = Console.ReadLine();

        if (string.IsNullOrEmpty(accountNumber))
        {
            Console.WriteLine("\nYou have not entered your account number");
            IsValidAccountNumber = false;
        }
        else if (accountNumber.Any(c => char.IsLetter(c)))
        {
            Console.WriteLine("\nAccount number only contains digits");
            IsValidAccountNumber = false;
        }
        else if(accountNumber.Any(c => char.IsWhiteSpace(c)))
        {
            Console.WriteLine("\nWhitespace is not allowed between digits");
            IsValidAccountNumber = false;
        }
        else if (accountNumber.Length > 10 || accountNumber.Length < 10)
        {
            Console.WriteLine("\nInvalid account number it must contain 10 digits only");
            IsValidAccountNumber = false;
        }
    }

    public static void ValidateAmount( ref string amount, ref bool IsValidAmount)
    {
        amount = Console.ReadLine();

        if (string.IsNullOrEmpty(amount))
        {
            Console.WriteLine("\nYou have not entered amount please enter amount");
            IsValidAmount = false;
        }
        else if (amount.Any(c => char.IsLetter(c)))
        {
            Console.WriteLine("\namount should only contains digits please enter valid amount");
            IsValidAmount = false;
        }
        else if(amount.Any(c => char.IsWhiteSpace(c)))
        {
            Console.WriteLine("\nWhitespace is not allowed between digits");
            IsValidAmount = false;
        }
        else if (!decimal.TryParse(amount, out decimal result) || decimal.Parse(amount) > 20000)
        {
            Console.WriteLine("\namount limit is upto 20000 only");
            IsValidAmount = false;
        }
    }

    public static void ValidateMessage(ref string message, ref bool IsValidMessage)
    {
        message = Console.ReadLine();

        if (string.IsNullOrEmpty(message))
        {
            Console.WriteLine("\nPlease enter message");
            IsValidMessage = false;
        }
        else if (message.Length > 50)
        {
            Console.WriteLine("\nMessage length can be upto 50 characters");
            IsValidMessage = false;
        }
    }

    public static void ValidateName(ref string name, ref bool IsValidName)
    {
        name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("\nName is required to open an account");
            IsValidName = false;
        }
        else if (name.Any(c => char.IsNumber(c)))
        {
            Console.WriteLine("\nName should only contains alphabets");
            IsValidName = false;
        }
        else if (name.Length > 15)
        {
            Console.WriteLine("\nName should be upto 15 character long");
            IsValidName = false;
        }
    }
}
