using System;

namespace Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack A = new Stack();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.Push(4);
            A.Push(5);
            A.Push(6);
            A.Pop();
            A.view();
            Console.ReadKey();
        }
    }
}
