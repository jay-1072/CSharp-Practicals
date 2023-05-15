using System;
using Abstraction;

public class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop = new Laptop();
        laptop.Brand = "HP";
        laptop.Model = "E27440";

        laptop.LaptopDetails();
        //laptop.MotherBoardInfo(); // Inaccessible because of private access
    }
}