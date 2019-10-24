using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Stack
    {
        private String[] Buffer;
        private int Top;
        public Stack(int size)
        {
            this.Buffer = new String [size];
            this.Top= -1;
        }

        public void Put(String item)
        {
            Buffer[Top + 1] = item;
            Top++;
        }

        public String Pop()
        {
            return Buffer[Top--];
        }

        public String Peek()
        {
            return Buffer[Top];
        }

        public int Count()
        {
            return Top+1;
        }

        public void Clear()
        {
            Top = -1;
        }
    }
}
