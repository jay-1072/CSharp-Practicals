using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public class AddAccountDAL
{
    public void AddSavingAccount(List<BankAccount> accounts)
    {      
        GetName(out string ownerName, out bool IsValidName);
               
        GetInitialBalance(out string initialBalance, out bool IsValidAmount);

        if (IsValidName && IsValidAmount)
        {
            accounts.Add(new SavingAccount(ownerName, decimal.Parse(initialBalance)));
        }        
    }

    public void AddCreditAccount(List<BankAccount> accounts)
    {
        GetName(out string ownerName, out bool IsValidName);

        GetInitialBalance(out string initialBalance, out bool IsValidAmount);

        GetCreditLimit(out string creditLimit, out bool IsValidCreditLimit);

        if (IsValidName && IsValidAmount && IsValidCreditLimit)
        {
            accounts.Add(new CreditAccount(ownerName, decimal.Parse(initialBalance), decimal.Parse(creditLimit)));
        }
    }

    public static void GetName(out string ownerName, out bool IsValidName)
    {
        do
        {
            Console.Write("\nEnter your name : ");
            ownerName = Console.ReadLine();

            IsValidName = Validation.ValidateName(ownerName);
        }
        while (!IsValidName);
    }

    public static void GetInitialBalance(out string initialBalance, out bool IsValidAmount)
    {     
        do
        {
            Console.Write("Enter initial balance : ");
            initialBalance = Console.ReadLine();
            
            IsValidAmount = Validation.ValidateAmount(initialBalance);    
        }
        while (!IsValidAmount);
    }

    public static void GetCreditLimit(out string creditLimit, out bool IsValidCreditLimit)
    {    
        do
        {
            Console.Write("Enter credit limit : ");
            creditLimit = Console.ReadLine();

            IsValidCreditLimit = Validation.ValidateAmount(creditLimit);

            if (IsValidCreditLimit && decimal.Parse(creditLimit) == 0)
            {
                Console.WriteLine("\namount must be greater than zero\n");
                IsValidCreditLimit = false;
            }
        }
        while(!IsValidCreditLimit);
    }        
}