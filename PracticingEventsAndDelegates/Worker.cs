using System;
using System.Collections.Generic;
using System.Text;

namespace PracticingEventsAndDelegates
{
    
    public class Worker
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed);

        public delegate void WorkCompletedHandler();
        WorkCompletedHandler del2 = new WorkCompletedHandler(WorkCompleted);

        public void DoWork()
        {
            del1(100, WorkType.Coding);
            del2();
        }

        private static void WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine($"Work performed for {hours} hours and of type {workType}");
        }
        private static void WorkCompleted()
        {
            Console.WriteLine("WorkDone");
        }

        public enum WorkType
        {
            Coding,
            Analysis,
            Documentation
        }
    }
}
