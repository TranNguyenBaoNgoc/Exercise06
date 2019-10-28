using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class MyQueue
    {
        private String[] Buffer;
        private int Length, Bot;
        public MyQueue(int size)
        {
            this.Buffer = new String [size];
            this.Length = -1;
        }

        public void Enqueue(String item)
        {
            Buffer[Length + 1] = item;
            Length++;
        }

        public String Dequeue()
        {
            Length--;
            return Buffer[Bot++];
        }

        public String Peek()
        {
            return Buffer[Bot];
        }

        public int Count()
        {
            return Length + 1;
        }

        public void Clear()
        {
            Length = -1;
        }
    }
}
