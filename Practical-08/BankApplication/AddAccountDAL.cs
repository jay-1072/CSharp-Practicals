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
        GetName(out string ownerName, out bool IsValidName); ;

        GetInitialBalance(out string initialBalance, out bool IsValidAmount);

        GetCreditLimit(out string creditLimit, out bool IsValidCreditLimit);

        if (IsValidName && IsValidAmount && IsValidCreditLimit)
        {
            accounts.Add(new CreditAccount(ownerName, decimal.Parse(initialBalance), decimal.Parse(creditLimit)));
        }
    }

    public void GetName(out string ownerName, out bool IsValidName)
    {
        ownerName = string.Empty;
        
        do
        {
            Console.Write("\nEnter your name : ");
            IsValidName = true;
            Validation.ValidateName(ref ownerName, ref IsValidName);
        }
        while (!IsValidName);
    }

    public void GetInitialBalance(out string initialBalance, out bool IsValidAmount)
    {
        initialBalance = string.Empty;

        do
        {
            Console.Write("Enter initial balance : ");
            IsValidAmount = true;
            Validation.ValidateAmount(ref initialBalance, ref IsValidAmount);
            
            if(IsValidAmount && decimal.Parse(initialBalance) < 0 )
            {
                Console.WriteLine("\nInitial balance must be positive\n");
                IsValidAmount = false;
            }            
        }
        while (!IsValidAmount);
    }

    public void GetCreditLimit(out string creditLimit, out bool IsValidCreditLimit)
    {
        creditLimit = string.Empty;
        
        do
        {
            Console.Write("Enter credit limit : ");
            IsValidCreditLimit = true;
            Validation.ValidateAmount(ref creditLimit, ref IsValidCreditLimit);

            if (IsValidCreditLimit && decimal.Parse(creditLimit) <= 0)
            {
                Console.WriteLine("\ncredit limit must be positive and greater than zero\n");
                IsValidCreditLimit = false;
            }
        }
        while(!IsValidCreditLimit);
    }        
}