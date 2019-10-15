using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    ///
    /// </summary>
    public static class ObjectShredder
    {
        /// <summary>
        /// Converts an IEnumerable list to a DataTable
        /// </summary>
        /// <typeparam name="T">Type with parameters (getters and setters)</typeparam>
        /// <param name="varlist"></param>
        /// <returns>DataTable</returns>
        /// <example>
        /// <code lang="csharp">
        /// class Test { 
        ///     public int id { get; set; } 
        ///     public string name { get; set; } 
        /// }
        /// ...
        /// var input =  new[] { new Test() { id=1, name="x" } };
        /// var ret = input.EnumerableToDataTable(); // returns a datatable
        /// </code>
        /// </example>
        public static DataTable EnumerableToDataTable<T>(this IEnumerable<T> varlist)
        {
            var dtReturn = new DataTable();

            // column names
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others   will follow
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (var pi in oProps)
                    {
                        var colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                var dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) ?? DBNull.Value;
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }
    }
}