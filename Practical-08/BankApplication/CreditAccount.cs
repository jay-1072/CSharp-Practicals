using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public sealed class CreditAccount:BankAccount
{
    public CreditAccount(string ownerName, decimal initialBalance, decimal creditLimit) : base(ownerName, initialBalance, creditLimit) { }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn, decimal amount) => isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;
}
