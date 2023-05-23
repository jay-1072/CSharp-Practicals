using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;
public class CommonFunctionalityDAL
{
    public void Withdraw(List<BankAccount> accounts)
    {
        BankAccount myAccount = TakeAccountNumber(accounts);

        if (myAccount is not null)
        {
            GetAmount(out string amount, out bool IsValidAmount);
            GetMessage(out string message, out bool IsValidMessage);
            myAccount.MakeWithdrawal(decimal.Parse(amount), DateTime.Now, message);
        }
        else
        {
            Console.WriteLine("\nAccount not exist");
        }
    }

    public void Deposit(List<BankAccount> accounts)
    {
        BankAccount myAccount = TakeAccountNumber(accounts);

        if (myAccount is not null)
        {
            GetAmount(out string amount, out bool IsValidAmount);
            GetMessage(out string message, out bool IsValidMessage);

            myAccount.MakeDeposit(decimal.Parse(amount), DateTime.Now, message);
        }
        else
        {
            Console.WriteLine("\nAccount not exist");
        }
    }

    public void Audit(List<BankAccount> accounts)
    {
        BankAccount myAccount = TakeAccountNumber(accounts);
        if(myAccount is not null)
        {
            Console.WriteLine(myAccount.GetAccountHistory());
        }
        else
        {
            Console.WriteLine("\nAccount doesn't exist");
        }        
    }   

    public BankAccount TakeAccountNumber(List<BankAccount> accounts)
    {
        string accountNumber = string.Empty;
        bool IsValidAccountNumber;

        do
        {
            Console.Write("\nEnter your account number : ");
            IsValidAccountNumber = true;
            Validation.ValidateAccountNumber(ref accountNumber, ref IsValidAccountNumber);
        }
        while(!IsValidAccountNumber);

        BankAccount myAccount = null;

        if (IsValidAccountNumber)
        {
            myAccount = FindAccount(accountNumber, accounts);
        }

        return myAccount;
    }

    public BankAccount FindAccount(string accountNumber, List<BankAccount> accounts)
    {

        BankAccount bankAccount = null;

        foreach (var account in accounts)
        {
            if (account.AccountNumber.Equals(accountNumber))
            {
                bankAccount = account;
                break;
            }
        }
        return bankAccount;
    }

    public void GetAmount(out string amount, out bool IsValidAmount)
    {
        amount = string.Empty;
        
        do
        {
            Console.Write("Enter amount : ");
            IsValidAmount = true;
            Validation.ValidateAmount(ref amount, ref IsValidAmount);
        }
        while (!IsValidAmount);
    }

    public void GetMessage(out string message, out bool IsValidMessage)
    {
        message = string.Empty;

        do
        {
            Console.Write("Enter message : ");
            IsValidMessage = true;
            Validation.ValidateMessage(ref message, ref IsValidMessage);
        }
        while (!IsValidMessage);
    }   
}