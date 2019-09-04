using System;

namespace ActionDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Action<int, int> addAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> multiplyAction = (x, y) => Console.WriteLine(x * y);

            addAction += multiplyAction;

            Operations operations = new Operations();
            operations.ProcessData(10, 20, addAction);
        }
    }
}
