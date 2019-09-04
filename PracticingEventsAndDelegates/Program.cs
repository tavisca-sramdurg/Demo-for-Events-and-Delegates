using System;

namespace PracticingEventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();


            //Delegate Inference
            //worker.WorkPerformed = new EventHandler<WorkArgs>(MethodList.Worker_WorkPerformed);
            //worker.WorkPerformed = MethodList.Worker_WorkPerformed;

            worker.WorkPerformed += (s,e) => Console.WriteLine(e.Hours + " " + e.WorkType);
            worker.WorkCompleted += (s,e) => Console.WriteLine("Work Done");
            worker.DoWork(5, WorkType.Coding);

            
            Console.Read();
        }

        
    }

    public enum WorkType
    {
        Coding,
        Analysis,
        Documentation
    }
}
