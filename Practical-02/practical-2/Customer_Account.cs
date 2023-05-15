using System;

namespace practical_2
{
    public class Customer_Account
    {
        public string? bank_name;
        public long customer_accountNo;
        public string? customer_name;

        public Customer_Account(long accountNo, string customerName)
        {
            customer_accountNo = accountNo;
            customer_name = customerName;
        }

        /* PrintInfo */
        // This method will print the customer account details
        // Return type of this method is void
        public void PrintInfo()
        {
            Console.WriteLine($"\nBank name\t\tAccount number\t\tCustomer name");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{this.bank_name}\t{this.customer_accountNo}\t\t{this.customer_name}");
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}