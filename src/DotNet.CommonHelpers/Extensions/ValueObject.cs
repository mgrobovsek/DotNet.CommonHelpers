using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    ///  Learn more: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/implement-value-objects
    /// </summary>
    public abstract class ValueObject
    {
        /// <summary>
        /// Returns true if left and right are the same
        /// </summary>        
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }

            return left?.Equals(right) != false;
        }
        /// <summary>
        /// Returns true if left and right are not equal
        /// </summary>        
        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !(EqualOperator(left, right));
        }
        
        /// <summary>
        /// Returns all components that must match if the objects are equal
        /// </summary>        
        protected abstract IEnumerable<object> GetEqualityComponents();
        
        /// <summary>
        /// Returns true if obj equals to this
        /// </summary>        
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;
            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        /// <summary>
        /// Serves as default hash function
        /// </summary>        
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
