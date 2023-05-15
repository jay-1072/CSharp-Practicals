using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_6
{
    public class ProcessBuissnessLogic
    {
        public delegate void ProcessCompletedEventHandler(object source, EventArgs e);

        public event ProcessCompletedEventHandler? ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Console.WriteLine("\nWork in progrss...");
            Thread.Sleep(3000);
            Console.WriteLine("\nProcess Completed");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {            
            ProcessCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}