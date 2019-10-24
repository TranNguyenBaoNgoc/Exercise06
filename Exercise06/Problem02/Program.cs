using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(5);
            //s.Put(5);
            //s.Put(4);
            //s.Put(7);
            //s.Put(51);
            //s.Put(9);
            //s.Pop();
            //s.Peek();
            //s.Count();
            //s.Clear();

            string[] Arr = { "Pham", "Ngoc", "Duy" };
            for (int i = 0; i < Arr.Length; i++)
            {
                s.Put(Arr[i]);
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = s.Pop();
            }
            for (int i= 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]+" ");
            }
        }
    }
}
