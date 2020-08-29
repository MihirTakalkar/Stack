using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //    ArrayBackedStack<int> otherStack = new ArrayBackedStack<int>(4);
            //    for (int i = 1; i <= 4; i++)
            //    {
            //        otherStack.Push(i);
            //    }
            //    Console.WriteLine(otherStack.Pop());
            //    otherStack.Push(6);

            //LinkedListStack<int> stack = new LinkedListStack<int>();
            //Console.WriteLine("Inserted:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"{i}->");
            //    stack.Push(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Popped order:");
            //for (int i = 0; i < 3; i++)
            //{
            //    int poppedValue = stack.Pop();
            //    Console.Write($"{poppedValue}->");
            //}

            ArrayBackedQueue<int> queue = new ArrayBackedQueue<int>();
            for (int i = 0; i <= 4; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(queue.Dequeue()); 
            }

        }
    }
}
