using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class LinkedListStack<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public int Count { get; private set; }
        private LinkedList<T> data;

        public LinkedListStack() 
        {

        }

        public void Push(T value)
        {
            list.AddFirst(value);
        }

        public T Pop()
        {
            list.RemoveFirst();
            return Peek();
        }

        public T Peek()
        {
            if(list.First  == null)
            {
                throw new Exception("The List is Null!");
            }

            return list.First.Value;
        }
    }
}
