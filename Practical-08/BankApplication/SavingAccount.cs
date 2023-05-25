using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public sealed class SavingAccount : BankAccount
{
    public SavingAccount(string ownerName, decimal initialBalance) : base(ownerName, initialBalance) { }

    protected override Transaction CheckWithdrawalLimit(bool isOverdrawn, decimal amount)
    {
        if(isOverdrawn)
        {
            Console.WriteLine($"\nNot sufficient funds to withdraw rupees {amount} current balance is rupees {Balance}");
        }
        return default;
    }
}