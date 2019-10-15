using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Deep copying of objects using reflection
    /// </summary>
    public static class ReflectionCopy
    {
        #region Typed

        /// <summary>
        /// Copies an array (source) to a destination array of type T
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static List<T> CopyList<T>(this object source) where T : new()
        {
            return CopyList<T>(source, new List<string> { });
        }

        /// <summary>
        /// Copies an array (source) to a destination array of type T that skips the parameters in skipParams list
        /// </summary>
        /// <param name="source"></param>
        /// <param name="skipParams"></param>
        /// <returns></returns>
        public static List<T> CopyList<T>(this object source, List<string> skipParams) where T : new()
        {
            var destinationType = typeof(T);
            var gt = typeof(List<>);
            _ = gt.MakeGenericType(destinationType);
            var tList = new List<T>();

            foreach (object o in (IEnumerable)source)
            {
                tList.Add(Copy<T>(o, skipParams));
            }
            return tList;
        }

        /// <summary>
        /// Makes a shallow copy of a similar object (same properties!)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// /// <param name="skipParams"></param>
        /// <returns></returns>
        public static T Copy<T>(this object source, List<string> skipParams) where T : new()
        {
            T newObject = new T();
            Modify(source, newObject, skipParams);
            return newObject;
        }

        /// <summary>
        /// Makes a shallow copy of a similar object (same properties!)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T Copy<T>(this object source) where T : new()
        {
            return Copy<T>(source, new List<string>() { });
        }

        #endregion Typed

        #region generic

        /// <summary>
        /// Copies an array (source) to a destination array of type destinationType
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public static List<object> Copy(this List<object> source, Type destinationType)
        {
            Type gt = typeof(List<>);
            Type ct = gt.MakeGenericType(destinationType);
            object tList = Activator.CreateInstance(ct);

            foreach (object o in source)
            {
                ((IList)tList).Add(Copy(o, destinationType));
            }
            return (tList as List<object>);
        }

        /// <summary>
        /// Makes a shallow copy of a similar object (same properties!)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public static object Copy(this object source, Type destinationType)
        {
            object newObject = Activator.CreateInstance(destinationType);
            Modify(source, newObject);
            return newObject;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void Modify(this object source, object destination)
        {
            Modify(source, destination, new List<string> { });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="skipParams">list of parameter names to be ignored</param>
        public static void Modify(this object source, object destination, List<string> skipParams)
        {
            PropertyInfo[] pList = source.GetType().GetProperties();

            Type destinationType = destination.GetType();

            foreach (PropertyInfo pi in pList)
            {
                // We don't copy the EntityKey and rowVer
                // rowVer is a rowversion column used in PTTracker
                if (pi.Name != "EntityKey" &&
                    pi.Name != "RowVer" &&
                    pi.Name != "EntityState" &&
                    //!pi.PropertyType.IsClass &&
                    pi.PropertyType.Namespace == "System" && // only bulit-in types
                    !skipParams.Contains(pi.Name)
                    )
                {
                    PropertyInfo piDest = destinationType.GetProperty(pi.Name);
                    if (piDest == null)
                        continue;
                    if (pi.PropertyType.IsArray)
                    {
                        Type et = Type.GetType(pi.PropertyType.FullName.Replace("[]", string.Empty));
                        Array a = (Array)pi.GetValue(source, null);
                        if (a != null)
                        {
                            Array c = Array.CreateInstance(et, a.Length);
                            for (int i = 0; i < a.Length; i++)
                            {
                                c.SetValue(a.GetValue(i), i);
                            }
                            piDest.SetValue(destination, c, null);
                        }
                    }
                    else
                    {
                        piDest.SetValue(
                            destination,
                            pi.GetValue(source, null),
                            null);
                        //Console.WriteLine(pi.Name + " -> " + pi.GetType().ToString());
                    }
                }
            }
        }

        #endregion generic
    }
}