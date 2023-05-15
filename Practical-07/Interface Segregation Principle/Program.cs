using Without_ISP;
using With_ISP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n*************** Without ISP ******************");

        Console.ForegroundColor = ConsoleColor.Green;

        HPLaserJetPrinter1 hPLaserJetPrinter = new HPLaserJetPrinter1();
        hPLaserJetPrinter.Print();
        hPLaserJetPrinter.Scan();
        hPLaserJetPrinter.Fax();
        hPLaserJetPrinter.PrintDuplex();

        LiquidInkJetPrinter1 liquidInkJetPrinter = new LiquidInkJetPrinter1();
        liquidInkJetPrinter.Print();
        liquidInkJetPrinter.Scan();
        //liquidInkJetPrinter.Fax();            
        //liquidInkJetPrinter.PrintDuplex();

        Console.ResetColor();

        Console.WriteLine("\n************** With ISP *********************");

        Console.ForegroundColor = ConsoleColor.Green;

        HPLaserJetPrinter2 hPLaserJetPrinter1 = new HPLaserJetPrinter2();
        hPLaserJetPrinter1.Print();
        hPLaserJetPrinter1.Scan();
        hPLaserJetPrinter1.Fax();
        hPLaserJetPrinter1.PrintDuplex();

        LiquidInkJetPrinter2 liquidInkJetPrinter1 = new LiquidInkJetPrinter2();
        liquidInkJetPrinter1.Print();
        liquidInkJetPrinter1.Scan();              

        Console.ResetColor();
        Console.ReadLine();
    }
}