using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingUsingAsyncAwait
{

    class Test
    {

        public static  Task ThrowInvalidOperationExceptionAsync() => throw new NotImplementedException();
        public static  Task ThrowNotImplementedExceptionAsync() => throw new InvalidOperationException();

        static async Task AllExceptionsAsync()
        {
            var task1 = ThrowNotImplementedExceptionAsync();
            var task2 = ThrowInvalidOperationExceptionAsync();

            Task allTasks = Task.WhenAll(task1, task2);
            try
            {
                await allTasks;
            }
            catch
            {
                AggregateException allExceptions = allTasks.Exception;
            }
        }
    }

    class Test2
    {
        private static Task<Int32> Method2()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                return 1;
            }
            );
        }
        public async static Task Method1()
        {
            var _returnValue = await Method2();
            Console.WriteLine(Environment.NewLine + " Call to Asynchronous process completed with value" + _returnValue);
        }
    }
    class Program
        {
            static void Main()
            {
            }
        }
    }

         