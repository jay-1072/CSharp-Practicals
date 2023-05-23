using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication;

public class Program
{
    public static void Main(String[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>();

        AddAccountDAL addAccountDAL = new AddAccountDAL();
        CommonFunctionalityDAL commonFunctionalityDAL = new CommonFunctionalityDAL();    

        Console.WriteLine("\nSimple Bank Application");
        bool flag = false;

        while (true)
        {
            Console.WriteLine($"\n1-Open new saving account");
            Console.WriteLine($"2-Open new credit account");
            Console.WriteLine($"3-Deposit");
            Console.WriteLine($"4-Withdraw");
            Console.WriteLine($"5-List all transaction");
            Console.WriteLine($"6-Clear Console");
            Console.WriteLine($"7-Exit");

            int choice;
            do
            {
                if (flag)
                {
                    Console.WriteLine("\nPlease Enter Valid Choice");
                }
                Console.Write($"\nEnter your choice : ");
            }
            while (flag = !int.TryParse(Console.ReadLine(), out choice));

            switch (choice)
            {
                case 1:
                    addAccountDAL.AddSavingAccount(accounts);
                    break;
                case 2:
                    addAccountDAL.AddCreditAccount(accounts);
                    break;
                case 3:
                    commonFunctionalityDAL.Deposit(accounts);
                    break;
                case 4:
                    commonFunctionalityDAL.Withdraw(accounts);
                    break;
                case 5:
                    commonFunctionalityDAL.Audit(accounts);
                    break;
                case 6:
                    Console.Clear();
                    break;
                case 7:
                    flag = true;
                    break;
                default:
                    Console.WriteLine("\nWrong option choosen");
                    break;
            }
            if (flag)
                break;
        }
    }
}
