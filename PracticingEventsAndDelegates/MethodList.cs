using System;
using System.Collections.Generic;
using System.Text;

namespace PracticingEventsAndDelegates
{
    public class MethodList
    {
        public static void Worker_WorkPerformed(object sender, WorkArgs e)
        {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        public static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Done");
        }
    }
}
