using System;
using practical_2;

public class Program
{
    public static void Main(string[] args)
    {
        Customer_Account customerAccount1 = new Customer_Account(190170116026, "Jay Koshti");
        customerAccount1.bank_name = "State Bank Of India";

        customerAccount1.PrintInfo();

        Console.ReadLine();
    }
}