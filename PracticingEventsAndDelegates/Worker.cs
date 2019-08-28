using System;
using System.Collections.Generic;
using System.Text;

namespace PracticingEventsAndDelegates
{
    //public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public class Worker
    {
        public event EventHandler<WorkArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            for(int i=0; i<hours; i++)
            {
                OnWorkerPerformed(i + 1, workType);
            }
            OnWorkerCompleted();
        
        }
       
        private void OnWorkerPerformed(int hours, WorkType workType)
        {
            //Method 1 for raising an event
            WorkPerformed?.Invoke(this, new WorkArgs(hours, workType));

            //Method 2 for raising an event
            //if (WorkPerformed is EventHandler<WorkArgs> del)
            //    del(this, new WorkArgs(hours, workType));
        }

        private void OnWorkerCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
            //if (WorkCompleted is EventHandler del)
            //    del(this, EventArgs.Empty);
        }
    }
}
