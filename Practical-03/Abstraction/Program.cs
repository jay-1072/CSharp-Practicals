using System;
using polymorphism;

namespace polymorphism
{
    class Bird
    {
        public virtual void Voice()
        {
            Console.WriteLine("\nTurr Turr");
        }
    }

    class Duck : Bird
    {
        public override void Voice()
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
        Duck myDuck = new Bird();

        myBird.Voice();
        myDuck.Voice();
    }
}