using System;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Extensions that make the code easier to read and mentain
    /// </summary>
    public static class CleanerCodeExtensions
    {
        /// <summary>
        /// Checks if the parameter meets the condition. It throws an exception if it does not
        /// </summary>
        /// <example lang="csharp">
        /// int amount = 30;
        /// string productName = "";
        /// amount.Require(a=>a>0);
        /// productName.Require(p=>!string.IsNullOrWhiteSpace(p));
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="param">parameter to be checked</param>
        /// <param name="condition">Condition to be met</param>
        public static void Require<T>(this T param, Func<T, bool> condition)
        {
            if (!condition(param))
            {
                throw new ArgumentException();
            }
        }
    }
}
