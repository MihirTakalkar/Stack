using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class LinkedListQueue<T>
    {
        public int Count => data.Count;
        private LinkedList<T> data;

        public LinkedListQueue()
        {
            data = new LinkedList<T>();
        }
        public void Enqueue(T value)
        {
            data.AddLast(value);
        }
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new Exception("Dequeuing when its empty.");
            }

            var temp = data.First;
            data.RemoveFirst();
            return temp.Value;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Peeking when its empty.");
            }
            return data.First.Value;
        }
    }
}
