using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(200000);
            acc.WithDraw(20000);
            acc.Deposit(40000);
            Console.WriteLine(acc.Balance());
        }
    }
}
