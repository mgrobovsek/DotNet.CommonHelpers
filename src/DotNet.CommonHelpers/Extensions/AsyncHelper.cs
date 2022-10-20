using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Helper for running async functions synchronously
    /// </summary>
    public static class AsyncHelper
    {
        private static readonly TaskFactory _myTaskFactory = new(CancellationToken.None,
                      TaskCreationOptions.None,
                      TaskContinuationOptions.None,
                      TaskScheduler.Default);
        /// <summary>
        /// Runs an async function synchronously 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static TResult RunSync<TResult>(Func<Task<TResult>> func)
        {
            return AsyncHelper._myTaskFactory
              .StartNew(func)
              .Unwrap()
              .GetAwaiter()
              .GetResult();
        }
        /// <summary>
        /// Runs an async method synchronously
        /// </summary>
        /// <param name="func"></param>
        public static void RunSync(Func<Task> func)
        {
            AsyncHelper._myTaskFactory
              .StartNew<Task>(func)
              .Unwrap()
              .GetAwaiter()
              .GetResult();
        }
    }
}
