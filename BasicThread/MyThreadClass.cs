using System;
using System.Threading;

namespace BasicThreadDemo
{
    public static class MyThreadClass
    {
    
        public static void Thread1(object _)
        {
            Thread thread = Thread.CurrentThread;

            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Console.WriteLine($"Name of Thread: {thread.Name} Process = {loopCount}");

            
                if (loopCount == 5) break;
              
                Thread.Sleep(1500);
            }
        }
    }
}
