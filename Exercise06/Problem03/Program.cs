using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyQueue s = new MyQueue(5);

            string[] Arr = { "Pham", "Ngoc", "Duy" };
            for (int i = 0; i < Arr.Length; i++)
            {
                s.Enqueue(Arr[i]);
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = s.Dequeue();
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i] + " ");
            }
        }
    }
}
