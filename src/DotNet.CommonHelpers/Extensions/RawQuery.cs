using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Helpers for better looking dapper queries
    /// ex.
    /// var data = "SELECT ID, Name FROM dbo.MyTable".Query&lt;dynamic&gt;(cString);
    /// </summary>
    public static class RawQuery
    {
        /// <summary>
        /// Default connection string. It has to be set if you want to use Query commands without specifying the connection stirng       
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// RawQuery.ConnectionString = "myconnection string...";
        /// var data = "SELECT * FROM TestTable".Query&lt;dynamic&gt;();
        /// </code>
        /// </example>
        public static string ConnectionString { get; set; }

        /// <summary>
        /// Executes a query, returning the data typed as <typeparamref name="TEntity"/>.
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// var data = "SELECT * FROM [dbo].[Table]".Query&lt;dynamic&gt;(); // gets results of the query as IEnumerble dynamic type
        /// class Table{
        ///     public int ID {get;set;}
        ///     public string Name {get;set;}
        /// }
        /// var tableData = "SELECT * FROM [dbo].[Table]".Query&lt;Table&gt;(); // gets results of the query and mapps them to IEnumerable&lt;Table&gt;
        /// </code>
        /// </example>
        /// <typeparam name="TEntity">The type of results to return.</typeparam>
        /// <param name="cString">The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString</param>
        /// <param name="sql">The SQL to execute for the query.</param>
        /// <param name="param">The parameters to pass, if any.</param>
        /// <param name="transaction">The transaction to use, if any.</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        /// <param name="commandTimeout">The command timeout (in seconds).</param>
        /// <param name="commandType">The type of command to execute.</param>
        /// <returns>
        /// A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column in assumed, otherwise an instance is
        /// created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
        /// </returns>
        public static IEnumerable<TEntity> Query<TEntity>(this string sql, string cString = null, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = default, CommandType? commandType = default)
        {
            using (IDbConnection dbConnection = new SqlConnection(cString ?? ConnectionString))
            {
                dbConnection.Open();
                var res = dbConnection.Query<TEntity>(sql, param, transaction, buffered, commandTimeout, commandType);
                return res;
            }
        }

        /// <summary>
        /// Executes a query asynchronously using Task, returning the data typed as <typeparamref name="TEntity"/>.
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// var data = await "SELECT * FROM [dbo].[Table]".QueryAsync&lt;dynamic&gt;(); // gets results of the query as IEnumerble dynamic type
        /// class Table{
        ///     public int ID {get;set;}
        ///     public string Name {get;set;}
        /// }
        /// var tableData = await "SELECT * FROM [dbo].[Table]".QueryAsync&lt;Table&gt;(); // gets results of the query and mapps them to IEnumerable&lt;Table&gt;
        /// </code>
        /// </example>
        /// <typeparam name="TEntity">The type of results to return.</typeparam>
        /// <param name="cString">The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString</param>
        /// <param name="sql">The SQL to execute for the query.</param>
        /// <param name="param">The parameters to pass, if any.</param>
        /// <param name="transaction">The transaction to use, if any.</param>        
        /// <param name="commandTimeout">The command timeout (in seconds).</param>
        /// <param name="commandType">The type of command to execute.</param>
        /// <returns>
        /// A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column in assumed, otherwise an instance is
        /// created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
        /// </returns>
        public static async Task<IEnumerable<TEntity>> QueryAsync<TEntity>(this string sql, string cString = null, object param = null, IDbTransaction transaction = null, int? commandTimeout = default, CommandType? commandType = default)
        {
            using (IDbConnection dbConnection = new SqlConnection(cString ?? ConnectionString))
            {

                dbConnection.Open();
                var res = await dbConnection.QueryAsync<TEntity>(sql, param, transaction, commandTimeout, commandType);
                return res;
            }
        }

        /// <summary>
        /// Execute parameterized SQL that selects a single value.
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// var tableRowCount = "SELECT count(1) FROM [dbo].[Table]".ExecuteScalar&lt;int&gt;(); // gets number of records of dbo.Table        
        /// </code>
        /// </example>
        /// <typeparam name="TEntity">The type to return.</typeparam>
        /// <param name="cString">The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString</param>
        /// <param name="sql">The SQL to execute.</param>
        /// <param name="param">The parameters to use for this command.</param>
        /// <param name="transaction">The transaction to use for this command.</param>
        /// <param name="commandTimeout">Number of seconds before command execution timeout.</param>
        /// <param name="commandType">Is it a stored proc or a batch?</param>
        /// <returns>The first cell returned, as <typeparamref name="TEntity"/>.</returns>
        public static TEntity ExecuteScalar<TEntity>(this string sql, string cString = null, object param = null, IDbTransaction transaction = null, int? commandTimeout = default, CommandType? commandType = default)
        {
            using (IDbConnection dbConnection = new SqlConnection(cString ?? ConnectionString))
            {
                dbConnection.Open();
                var res = dbConnection.ExecuteScalar<TEntity>(sql, param, transaction, commandTimeout, commandType);
                return res;
            }

        }

        /// <summary>
        /// Execute parameterized SQL that selects a single value asynchronously using Task.
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// var tableRowCount = await "SELECT count(1) FROM [dbo].[Table]".ExecuteScalarAsync&lt;int&gt;(); // gets number of records of dbo.Table        
        /// </code>
        /// </example>
        /// <typeparam name="TEntity">The type to return.</typeparam>
        /// <param name="cString">The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString</param>
        /// <param name="sql">The SQL to execute.</param>
        /// <param name="param">The parameters to use for this command.</param>
        /// <param name="transaction">The transaction to use for this command.</param>
        /// <param name="commandTimeout">Number of seconds before command execution timeout.</param>
        /// <param name="commandType">Is it a stored proc or a batch?</param>
        /// <returns>The first cell returned, as <typeparamref name="TEntity"/>.</returns>
        public static async Task<TEntity> ExecuteScalarAsync<TEntity>(this string sql, string cString = null, object param = null, IDbTransaction transaction = null, int? commandTimeout = default, CommandType? commandType = default)
        {
            using (IDbConnection dbConnection = new SqlConnection(cString ?? ConnectionString))
            {
                dbConnection.Open();
                var res = await dbConnection.ExecuteScalarAsync<TEntity>(sql, param, transaction, commandTimeout, commandType);
                return res;
            }
        }

        /// <summary>
        /// Execute a command asynchronously using Task.
        /// </summary> 
        /// <example>        
        /// <code lang="csharp">
        /// await "EXEC dbo.DoSomething @id".ExecuteAsync(param: new {id=123}); // executes stored procedure dbo.DoSomething with the parameter @id = 123
        /// </code>
        /// </example>
        /// <param name="cString">The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString</param>
        /// <param name="sql">The SQL to execute for this query.</param>
        /// <param name="param">The parameters to use for this query.</param>
        /// <param name="transaction">The transaction to use for this query.</param>
        /// <param name="commandTimeout">Number of seconds before command execution timeout.</param>
        /// <param name="commandType">Is it a stored proc or a batch?</param>
        /// <returns>The number of rows affected.</returns>
        public static async Task<int> ExecuteAsync(this string sql, string cString = null, object param = null, IDbTransaction transaction = null, int? commandTimeout = default, CommandType? commandType = default)
        {
            using (IDbConnection dbConnection = new SqlConnection(cString ?? ConnectionString))
            {
                dbConnection.Open();
                var res = await dbConnection.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);
                return res;
            }
        }


        /// <summary>
        /// Execute parameterized SQL.
        /// </summary>
        /// <example>        
        /// <code lang="csharp">
        /// "EXEC dbo.DoSomething @id".Execute(param: new {id=123}); // executes stored procedure dbo.DoSomething with the parameter @id = 123
        /// </code>
        /// </example>
        /// <param name="cString">The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString</param>
        /// <param name="sql">The SQL to execute for this query.</param>
        /// <param name="param">The parameters to use for this query.</param>
        /// <param name="transaction">The transaction to use for this query.</param>
        /// <param name="commandTimeout">Number of seconds before command execution timeout.</param>
        /// <param name="commandType">Is it a stored proc or a batch?</param>
        /// <returns>The number of rows affected.</returns>
        public static int Execute(this string sql, string cString = null, object param = null, IDbTransaction transaction = null, int? commandTimeout = default, CommandType? commandType = default)
        {
            using (IDbConnection dbConnection = new SqlConnection(cString ?? ConnectionString))
            {
                dbConnection.Open();
                var res = dbConnection.Execute(sql, param, transaction, commandTimeout, commandType);
                return res;
            }
        }
    }
}