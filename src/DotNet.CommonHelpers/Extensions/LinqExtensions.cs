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
    }
}
