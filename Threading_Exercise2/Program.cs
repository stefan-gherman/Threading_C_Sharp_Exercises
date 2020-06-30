using System;
using System.Threading;

namespace Threading_Exercise2
{
    class Program
    {
        private const string mutexName= "RUNMEONLYONCE";
        static void Main(string[] args)
        {
            Mutex mutex;
            while(1 > 0)
            {
                try
                {
                    mutex = Mutex.OpenExisting(mutexName);
                    mutex.Close();
                    //System.Environment.Exit(1);
                }
                catch (WaitHandleCannotBeOpenedException)
                {
                    mutex = new Mutex(true, mutexName);
                   
                }
            }
            


        }
    }
}
