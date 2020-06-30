using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        public static void Main(string[] args)
        {
        }


        private static void Counting()
        {
            for(int i = 1; i< 11; i++)
            {
                Console.WriteLine($"Current count {i}\n Current Thread: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
