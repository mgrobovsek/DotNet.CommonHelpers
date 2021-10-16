using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ObjectHelper
    {
        /// <summary>
        /// Outputs an object to the console (converting it to json first)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="indented"></param>
        public static void Dump<T>(this T x, bool indented = true)
        {
            Console.WriteLine(x.AsJson(indented));
        }
        /// <summary>
        /// Covenrst an object to a json string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="indented"></param>
        /// <returns></returns>
        public static string AsJson<T>(this T x, bool indented = true)
        {
            return JsonSerializer.Serialize(x, new JsonSerializerOptions() { WriteIndented = indented });
        }
    }
}
