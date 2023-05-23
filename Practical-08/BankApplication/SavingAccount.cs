using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public sealed class SavingAccount : BankAccount
{
    public SavingAccount(string ownerName, decimal initialBalance) : base(ownerName, initialBalance) { }
}