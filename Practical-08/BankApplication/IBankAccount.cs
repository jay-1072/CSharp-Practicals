using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;
public interface IBankAccount
{
    void MakeWithdrawal(decimal amount, DateTime date, String note);
    void MakeDeposit(decimal amount, DateTime date, String note);
}