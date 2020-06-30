using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var threadingDelegate = new ThreadStart(() => Counting(2000));
            var threadingDelegate2 = new ThreadStart(() => Counting(4000));
            Thread thread1 = new Thread(threadingDelegate);
            Thread thread2 = new Thread(threadingDelegate);
            thread1.Name = "First Thread";
            thread2.Name = "Second Thread";
            var stopWatch = Stopwatch.StartNew();
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine($"Time elapsed {stopWatch.ElapsedMilliseconds}");

            //stopWatch = Stopwatch.StartNew();
            //thread1 = new Thread(threadingDelegate);
            //thread2 = new Thread(threadingDelegate2);
            //thread1.Name = "First Thread";
            //thread2.Name = "Second Thread";
            //thread1.Start();
            //thread2.Start();
            //Console.WriteLine($"Time elapsed {stopWatch.ElapsedMilliseconds}");
            //Counting();
        }


        private static void Counting(int milisecondsAmount)
        {
            for(int i = 1; i< 11; i++)
            {
                Console.WriteLine($"Current count {i}\nCurrent Thread: {Thread.CurrentThread.Name}, Status: {Thread.CurrentThread.ThreadState}");
                Thread.Sleep(milisecondsAmount);
            }
        }
    }
}
