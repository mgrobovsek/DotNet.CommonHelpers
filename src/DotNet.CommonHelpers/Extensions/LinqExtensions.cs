using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Linq extensions
    /// </summary>
    public static class LinqExtensions
    {
        /// <summary>
        /// Clones a list of clonable items
        /// </summary>        
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        /// <summary>
        /// Index of max value
        /// </summary>        
        public static int MaxIndex<T>(this IEnumerable<T> sequence) where T : IComparable<T>
        {
            int maxIndex = -1;
            T maxValue = default; // Immediately overwritten anyway

            int index = 0;
            foreach (T value in sequence)
            {
                if (value.CompareTo(maxValue) > 0 || maxIndex == -1)
                {
                    maxIndex = index;
                    maxValue = value;
                }
                index++;
            }
            return maxIndex;
        }

        /// <summary>
        /// Write items to console using converter function func
        /// </summary>
        public static void ToConsoleSameLine<T>(this IEnumerable<T> @this, Func<T, string> func)
        {
            foreach (T item in @this)
                Console.Write(func(item));
        }
    }
}
