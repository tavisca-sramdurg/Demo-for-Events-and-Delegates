using System;
using System.Collections.Generic;
using System.Text;

namespace PracticingEventsAndDelegates
{
    public class WorkArgs : EventArgs
    {
        public int Hours { get; private set; }
        public WorkType WorkType { get; private set; }

        public WorkArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }
    }
}
