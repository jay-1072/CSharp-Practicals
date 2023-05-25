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
            GetAmount(out string amount);
            GetMessage(out string message);
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
            GetAmount(out string amount);
            GetMessage(out string message);

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
        string accountNumber;
        bool isValidAccountNumber;

        do
        {
            Console.Write("\nEnter your account number : "); 
            accountNumber = Console.ReadLine();

            isValidAccountNumber = Validation.ValidateAccountNumber(accountNumber);
        }
        while(!isValidAccountNumber);

        if (isValidAccountNumber)
        {
            return FindAccount(accountNumber, accounts);
        }

        return default;
    }

    public BankAccount FindAccount(string accountNumber, List<BankAccount> accounts)
    {
        foreach (var account in accounts)
        {
            if (account.AccountNumber.Equals(accountNumber))
            {
                return account;
            }
        }
        return default;
    }

    public void GetAmount(out string amount)
    {        
        do
        {
            Console.Write("Enter amount : ");
            amount = Console.ReadLine();
        }
        while (!Validation.ValidateAmount(amount));
    }

    public void GetMessage(out string message)
    {
        do
        {
            Console.Write("Enter message : ");
            message = Console.ReadLine();
        }
        while (!Validation.ValidateMessage(message));
    }   
}