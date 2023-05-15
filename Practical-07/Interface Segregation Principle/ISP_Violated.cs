using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_ISP
{
    public interface IPrinterTasks
    {
        void Print();
        void Fax();
        void Scan();
        void PrintDuplex();
    }

    public class HPLaserJetPrinter1 : IPrinterTasks
    {
        public void Print()
        {
            Console.WriteLine("\nPrint Done by HPLaserJetPrinter");
        }
        public void Fax()
        {
            Console.WriteLine("\nFax Done by HPLaserJetPrinter");
        }
        public void Scan()
        {
            Console.WriteLine("\nScan Done by HPLaserJetPrinter");
        }
        public void PrintDuplex()
        {
            Console.WriteLine("\nWork Done by HPLaserJetPrinter");
        }
    }

    public class LiquidInkJetPrinter1 : IPrinterTasks
    {
        public void Print()
        {
            Console.WriteLine("\nPrint Done by LiquidInkJetPrinter");
        }
        public void Scan()
        {
            Console.WriteLine("\nScan Done by LiquidInkJetPrinter");
        }
        public void Fax()
        {
            throw new NotImplementedException(); 
        }       
        public void PrintDuplex()
        {
            throw new NotImplementedException();
        }
    }
}
