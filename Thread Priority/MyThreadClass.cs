﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Priority
{
    internal class MyThreadClass
    {

    public static void Thread1()
        {
            for (int LoopCount = 0; LoopCount < 3; LoopCount++) {
                Thread thread = Thread.CurrentThread;
               

                Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int LoopCount = 0; LoopCount <6; LoopCount++) {
              
              
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " = " + LoopCount);
                Thread.Sleep(2000);
                
            }
        }
    }
}
