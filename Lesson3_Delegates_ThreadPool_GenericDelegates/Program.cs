using System;
using System.Threading;

namespace Lesson3_Delegates_ThreadPool_GenericDelegates
{
    class Program
    {
        static void PrintOddNumbersInRange(object state)
        {
            int[] range = state as int[];
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (i % 2 != 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Factorial(3);
            //ThreadPool.QueueUserWorkItem(Factorial, 3);
            //ThreadPool.QueueUserWorkItem(Factorial, 3);
            int[] nums = new int[2];
            nums[0] = Int32.Parse(Console.ReadLine());
            nums[1] = Int32.Parse(Console.ReadLine());
            ThreadPool.QueueUserWorkItem(PrintOddNumbersInRange, nums);
            Console.WriteLine("Test");
        }

        private static void Factorial(object state)
        {
            Console.WriteLine(state as int?);
        }
    }
}
