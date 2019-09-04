using System;
using System.Collections.Generic;
using System.Text;

namespace ActionDemo
{
    public class Operations
    {
        public void ProcessData(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed");
        }
    }
}