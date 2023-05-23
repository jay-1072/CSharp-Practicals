using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;
public abstract class BankAccount:IBankAccount
{
    private static int s_accountNumberSeed = 1234567890;

    public string AccountNumber { get; }
    public string OwnerName { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var transaction in allTransactions)
            {
                balance += transaction.Amount;
            }
            return balance;
        }
    }

    private readonly decimal _minimumBalance;

    public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0)
    {
    }

    public BankAccount(string ownerName, decimal initialBalance, decimal minimumBalance)
    {
        this.AccountNumber = (s_accountNumberSeed++).ToString();
        this.OwnerName = ownerName;
        this._minimumBalance = minimumBalance;

        if (initialBalance > 0)
        {
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        Console.WriteLine($"\nAccount created for {OwnerName} with account number {this.AccountNumber} and initial balance {initialBalance}");
    }

    private List<Transaction> allTransactions = new List<Transaction>();

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        try
        {
            if (amount <= 0)
            {
                throw new Exception("Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n{ex.Message}");
        }
    }

    public void MakeWithdrawal(decimal amount, DateTime date, String note)
    {
        try
        {
            if (amount <= 0)
            {
                throw new Exception("Amount of withdrawal must be positive");
            }
            Transaction overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance, amount);

            if (this.GetType().Name.Equals("CreditAccount"))
            {
                Transaction withdrawal = new Transaction(-amount, date, note);
                allTransactions.Add(withdrawal);
            }
            else if (Balance - amount >= 0)
            {
                Transaction withdrawal = new Transaction(-amount, date, note);
                allTransactions.Add(withdrawal);
            }

            if (overdraftTransaction is not null)
            {
                allTransactions.Add(overdraftTransaction);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n{ex.Message}");
        }
    }

    protected virtual Transaction CheckWithdrawalLimit(bool isOverdrawn, decimal amount)
    {
        if (isOverdrawn)
        {
            Console.WriteLine($"\nNot sufficient funds to withdraw rupees {amount} current balance is rupees {Balance}");
        }
        return default;
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();

        if (allTransactions.Count == 0)
        {
            report.Append($"\nYou have not done any transaction yet");
        }
        else
        {
            decimal balance = 0;
            report.AppendLine("\nDate\t\tAmount\tBalance\tNote");
            foreach (var transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.Append($"{transaction.Date.ToShortDateString()}");
                report.Append($"\t{transaction.Amount}");
                report.Append($"\t{balance}");
                report.Append($"\t{transaction.Note}\n");
            }
        }

        return report.ToString();
    }
}
