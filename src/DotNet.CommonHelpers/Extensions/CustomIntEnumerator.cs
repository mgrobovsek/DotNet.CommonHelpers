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

    public class CustomIntEnumerator
    {
        private int _current;
        private readonly int _end;
        private MoveNextDelegate _moveNextAction;

        delegate  bool  MoveNextDelegate();
        public CustomIntEnumerator(Range range)
        {

            if (range.End.IsFromEnd)
                throw new Exception("End of interval must be specified!");

            

            if (range.End.Value > range.Start.Value)
            {

                _current = range.Start.Value - 1;
                _end = range.End.Value;
                _moveNextAction = new MoveNextDelegate(MoveNextInc);
            }
            else
            {
                //if (range.Start.IsFromEnd)
                //    throw new Exception("End of interval must be specified!");
                //_current = range.End.Value;
                //_end = range.Start.Value - 1;

                _current = range.Start.Value+1;
                _end = range.End.Value;
                _moveNextAction = new MoveNextDelegate(MoveNextDec);                
            }

        }

        

        public int Current => _current;
        public bool MoveNext() => _moveNextAction();
        
        private bool MoveNextInc()
        {
            _current++;
            return _current <= _end;
        }
        private bool MoveNextDec()
        {
            _current--;
            return _current >= _end;
        }

    }
   
}
