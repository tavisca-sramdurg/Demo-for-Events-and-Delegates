using System;

namespace FuncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Func<int, int, int> multiplyFunc = (x, y) => x * y;

            addFunc += multiplyFunc;

            Operations operations = new Operations();
            operations.ProcessData(10, 20, addFunc);
        }
    }
}
