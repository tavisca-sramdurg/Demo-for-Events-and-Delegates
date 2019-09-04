using System;
using System.Collections.Generic;
using System.Text;

namespace FuncDemo
{
    public class Operations
    {
        public void ProcessData(int x, int y, Func<int, int, int> func)
        {
            Console.WriteLine(func(x, y)); 
            Console.WriteLine("Func has been processed");
        }
    }
}