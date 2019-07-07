using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlyForTest
{
    public class TestTaskAndAsync
    {
        private static readonly string FormatStr = "{0}=>My Thread id is {1}";
        public void StartTest()
        {
            Console.WriteLine("StartTest1. My Thread ID is :" + Thread.CurrentThread.ManagedThreadId);
            var result=AsyncMethod();
            Console.WriteLine(result);
            Console.WriteLine("StartTest2. My Thread ID is :" + Thread.CurrentThread.ManagedThreadId);


        }

        private async Task<string> AsyncMethod()
        {
            var ResultFromTimeConsumingMethod = TimeConsumingMethod();
            string Result = await ResultFromTimeConsumingMethod + " + AsyncMethod. My Thread ID is :" + Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(Result);
            return Result;
        }


        private Task<string> TimeConsumingMethod()
        {
            var task = Task.Run(() => {
                Console.WriteLine("Helo I am TimeConsumingMethod. My Thread ID is :" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
                Console.WriteLine("Helo I am TimeConsumingMethod after Sleep(5000). My Thread ID is :" + Thread.CurrentThread.ManagedThreadId);
                return "Hello I am TimeConsumingMethod";
            });

            return task;
        }
    }
}
