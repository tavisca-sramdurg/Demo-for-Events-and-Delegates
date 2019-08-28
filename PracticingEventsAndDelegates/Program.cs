using System;

namespace PracticingEventsAndDelegates
{
    class Program
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        public delegate void WorkCompletedHandler();
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed);

            del1 += del2;
            del1 += del3;

            DoWork(del1);
            //DoWork(del2);
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(500, WorkType.Coding);
        }

        private static void WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine($"Work performed for {hours} hours and of type {workType}");
        }

        private static void WorkCompleted()
        {
            Console.WriteLine("WorkDone!");
        }

 
    }

    public enum WorkType
    {
        Coding,
        Analysis,
        Documentation
    }
}
