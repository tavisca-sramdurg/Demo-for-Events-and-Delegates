using System;

namespace PracticingEventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            

            worker.WorkPerformed += MethodList.Worker_WorkPerformed;
            worker.WorkCompleted += MethodList.Worker_WorkCompleted;
            worker.DoWork(5, WorkType.Coding);

            Console.WriteLine("Hello World");
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
