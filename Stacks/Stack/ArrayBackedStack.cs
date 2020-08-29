using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class ArrayBackedStack<T>
    {
        public int Count { get; private set; }
        private T[] data;
        private int index;

        public ArrayBackedStack(int capacity)
        {
            data = new T[capacity];
        }

        public void Push(T value)
        {
           PerformResizeIfNeeded();

            data[index] = value;
            index++;

        }

        public T Pop()
        {
            index--;
            T topValue = Peek();
            return topValue;
        }

        public T Peek()
        {
            return data[index];
        }

        private T[] Resize()
        {
            int resizeLength = data.Length * 2;
            if(resizeLength == 0)
            {
                resizeLength = 1;
            }

            T[] data2 = new T[resizeLength];
            for(int i = 0; i < data.Length; i++)
            {
                data2[i] = data[i];
            }

            return data2;
        }

        private void PerformResizeIfNeeded()
        {
            if (index == data.Length - 1)
            {
                data = Resize();
            }
        }
    }
}
