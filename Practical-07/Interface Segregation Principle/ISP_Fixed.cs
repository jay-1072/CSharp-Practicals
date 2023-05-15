using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_ISP
{
    public interface IPrinterTasks
    {
        void Print();
        void Scan();
    }

    public interface IFaxTasks
    {
        void Fax();
    }

    public interface IPrintDuplexTasks
    {
        void PrintDuplex();
    }

    public class HPLaserJetPrinter2 : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print()
        {
            Console.WriteLine("\nPrint Done by HPLaserJetPrinter");
        }        
        public void Scan()
        {
            Console.WriteLine("\nScan Done by HPLaserJetPrinter");
        }
        public void Fax()
        {
            Console.WriteLine("\nFax Done by HPLaserJetPrinter");
        }
        public void PrintDuplex()
        {
            Console.WriteLine("\nWork Done by HPLaserJetPrinter");
        }
    }

    public class LiquidInkJetPrinter2 : IPrinterTasks
    {
        public void Print()
        {
            Console.WriteLine("\nPrint Done by LiquidInkJetPrinter");
        }
        public void Scan()
        {
            Console.WriteLine("\nScan Done by LiquidInkJetPrinter");
        }       
    }
}
