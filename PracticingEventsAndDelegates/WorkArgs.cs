using System;
using System.Collections.Generic;
using System.Text;

namespace PracticingEventsAndDelegates
{
    public class WorkArgs : EventArgs
    {
        public WorkArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; private set; }
        public WorkType WorkType { get; private set; }
    }
}
