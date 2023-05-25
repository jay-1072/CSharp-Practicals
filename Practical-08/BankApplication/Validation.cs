using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public static class Validation
{
    public static bool ValidateAccountNumber(string accountNumber)
    {
        bool isValidAccountNumber;

        if (string.IsNullOrEmpty(accountNumber))
        {
            Console.WriteLine("\nYou have not entered your account number");
            isValidAccountNumber = false;
        }
        else if (accountNumber.Any(c => char.IsLetter(c)))
        {
            Console.WriteLine("\nAccount number only contains digits");
            isValidAccountNumber = false;
        }
        else if(accountNumber.Any(c => char.IsWhiteSpace(c)))
        {
            Console.WriteLine("\nWhitespace is not allowed between digits");
            isValidAccountNumber = false;
        }
        else if (accountNumber.Length > 10 || accountNumber.Length < 10)
        {
            Console.WriteLine("\nInvalid account number it must contain 10 digits only");
            isValidAccountNumber = false;
        }
        else
        {
            isValidAccountNumber = true;
        }

        return isValidAccountNumber;
    }

    public static bool ValidateAmount(string amount)
    {
        bool IsValidAmount;
        decimal result;

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
        else if(!decimal.TryParse(amount, out result) || decimal.Parse(amount) < 0)
        {
            Console.WriteLine("\namount must be positive\n");
            IsValidAmount = false;
        }
        else if (!decimal.TryParse(amount, out result) || decimal.Parse(amount) >20000)
        {
            Console.WriteLine($"\namount must be between 0 and 20000\n");
            IsValidAmount = false;
        }
        else
        {
            IsValidAmount = true;
        }

        return IsValidAmount;
    }

    public static bool ValidateMessage(string message)
    {
        bool isValidMessage;

        if (string.IsNullOrEmpty(message))
        {
            Console.WriteLine("\nPlease enter message");
            isValidMessage = false;
        }
        else if (message.Length > 50)
        {
            Console.WriteLine("\nMessage length can be upto 50 characters");
            isValidMessage = false;
        }
        else
        {
            isValidMessage = true;
        }

        return isValidMessage;
    }

    public static bool ValidateName(string name)
    {
        bool isValidName;

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("\nName is required to open an account");
            isValidName = false;
        }
        else if (name.Any(c => char.IsNumber(c)))
        {
            Console.WriteLine("\nName should only contains alphabets");
            isValidName = false;
        }
        else if (name.Length > 15)
        {
            Console.WriteLine("\nName should be upto 15 character long");
            isValidName = false;
        }
        else
        {
            isValidName = true;
        }

        return isValidName;
    }
}
