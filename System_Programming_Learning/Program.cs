using System;
using System.Collections.Generic;
using System.Diagnostics; // Progress class
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System_Programming_Learning
{
    class Program
    {
        static void MyMethod(object state)
        {
            for (int i = 0; i < 100000; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
            }
        }

        static void Main(string[] args)
        {
            #region ThreadExamples
            //Example 1
            //Console.WriteLine("Test1");
            //for (int i = 0; i < 100000; i++)
            //{
            //    Thread.Sleep(TimeSpan.FromMilliseconds(100));
            //}
            //Console.WriteLine("Test2");


            // Exmaple 2
            //Console.WriteLine("Test1");
            //ThreadPool.QueueUserWorkItem((el) =>
            //{
            //    //object
            //    //AProcess
            //    //Process
            //    if (el is Process)
            //    {
            //        Console.WriteLine("All good it`s process");
            //        var myProcess = el as Process;
            //        for (int i = 0; i < 100000; i++)
            //        {
            //            Console.WriteLine("Test");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Vasya, it`s not process");
            //    }

            //}, false);

            //Console.WriteLine("Test2");
            #endregion
            //Processes

            // Start new process with arguments 
            //Process.Start("chrome.exe", "youtube.com");  

            // Get process by name
            Process[] processes = Process.GetProcessesByName("chrome");
            Console.WriteLine("----------------Chrome Process----------------");
            //Console.WriteLine(String.Join<Process>(" ", processes.ToArray())); 
            //Console.WriteLine($" Id : {chrome.Id}\n Name: {chrome.ProcessName}\n Priority: {chrome.PriorityClass}\n Machine Name: {chrome.MachineName}\n IsExited: {chrome.HasExited}");
            //Console.WriteLine("----------------------------------------------");
        }


    }
}

