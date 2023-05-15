using System;
using practical_6;
public class Program
{
    public static void Main(string[] args)
    {
        ProcessBuissnessLogic processBuissnessLogic = new ProcessBuissnessLogic();
        processBuissnessLogic.ProcessCompleted += bl_ProcessCompleted;

        processBuissnessLogic.StartProcess();        
    }

    public static void bl_ProcessCompleted(object source, EventArgs e)
    {
        Console.WriteLine($"\nMethod Invoked");
    }
}