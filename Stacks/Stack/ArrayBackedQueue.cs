using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Stack
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class ArrayBackedQueue<T>
    {
        public int Count { get; private set; }
        public T[] data;
        private int headIndex;

        public ArrayBackedQueue()
        {
            data = new T[0];
        }

        public void Enqueue(T value)
        {
            PerformResizeIfNeeded();
            data[(Count + headIndex) % data.Length] = value;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new Exception("Dequeuing when its empty.");
            }

            T value = Peek();
            if (headIndex != data.Length - 1)
            {
                headIndex++;
            }

            else
            {
                headIndex = 0;
            }
            Count--;
            return value;
        }

        public T Peek()
        {
            return data[headIndex];
        }

        private T[] Resize()
        {
            int resizeLength = data.Length * 2;
            if (resizeLength == 0)
            {
                resizeLength = 1;
            }

            T[] data2 = new T[resizeLength];
            for (int i = 0; i < Count; i++)
            {
                data2[i] = data[(i + headIndex) % data.Length];
            }

            return data2;
        }

        private void PerformResizeIfNeeded()
        {
            if (Count == data.Length)
            {
                data = Resize();
            }
        }

        private string GetDebuggerDisplay()
        {

            List<T> values = new List<T>();

            for (int i = headIndex; i < data.Length; i++)
            {
                values.Add(data[i]);
            }
            string output = $"Count: {Count}, Values: {string.Join(',', values)}";
            return output;
        }
    }
}
