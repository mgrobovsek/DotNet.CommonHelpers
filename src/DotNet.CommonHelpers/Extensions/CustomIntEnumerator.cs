using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.CommonHelpers.Extensions
{
    public static class EnumerationExtensions
    {
        /// <summary>
        /// Syntactic suggar for better looking loops       
        /// </summary>
        /// <param name="range"></param>
        /// <example>
        /// <code lang="csharp">
        /// foreach(var i in 1..10)
        ///     Console.WriteLine(i);
        /// </code>
        /// </example>
        public static CustomIntEnumerator GetEnumerator(this Range range)
        {
            return new CustomIntEnumerator(range);
        }

    }

    public ref struct CustomIntEnumerator
    {
        private int _current;
        private readonly int _end;

        public CustomIntEnumerator(Range range)
        {
            if (range.End.IsFromEnd)
                throw new Exception("End of interval must be specified!");

            _current = range.Start.Value - 1;
            _end = range.End.Value;
        }

        public int Current => _current;
        public bool MoveNext()
        {
            _current++;
            return _current <= _end;
        }
    }
}
