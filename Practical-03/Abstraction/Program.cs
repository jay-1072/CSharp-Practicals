using System;
using polymorphism;

namespace polymorphism
{
    class Bird
    {
        public void Voice()
        {
            Console.WriteLine("\nTurr Turr");
        }
    }

    class Duck : Bird
    {
        public void Voice()
        {
            Console.WriteLine("\nQuack Quack");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Bird myBird = new Bird();
        myBird.Voice();

        myBird = new Duck();
        myBird.Voice();
    }
}