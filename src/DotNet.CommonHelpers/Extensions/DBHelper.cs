using System;
using System.Data;
using System.Data.SqlClient;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Makes querying the database easier/more elegant
    /// </summary>
    public static class DBHelper
    {
        /// <summary>
        /// Global connection string. It has to be set if you wish to execute queries without specifying the connectionString
        /// </summary>
        public static string ConnectionString { get; set; }

        /// <summary>
        /// Global query CommandTimeout in seconds
        /// </summary>
        public static int QueryCommandTimeout { get; set; } = 60;


        /// <summary>
        /// Executes the query. If connectionString and timeout are null it takes the default settings.
        /// If ConnectionString is null you have to set it before the 1st call with DBHelper.ConnectionString=...
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// var data = "SELECT * FROM [dbo].[Table]".QueryDT(); // gets results of the query as a DataTable        
        /// </code>
        /// </example>
        /// <param name="sqlQuery">SQL query to be executed</param>
        /// <param name="connectionString">SQL Database connection string</param>
        /// <param name="timeout">Command timeout in seconds</param>
        /// <returns>Results of the query in a datatable</returns>        
        public static DataTable QueryDT(this string sqlQuery, string connectionString = null, int? timeout = null)
        {
            var t = new DataTable();
            try
            {
                using var conn = new SqlConnection(connectionString ?? ConnectionString);
                using var da = new SqlDataAdapter(sqlQuery, conn);
                da.SelectCommand.CommandTimeout = timeout ?? QueryCommandTimeout;
                da.Fill(t);
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(DBHelper.QueryDT), ex);
            }
            return t;
        }
    }
}