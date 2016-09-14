using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Database connector string class.
    /// </summary>
    internal class DBConnection
    {
        /// <summary>
        /// The connection string
        /// </summary>
        const string ConnectionString = @"Data Source=localhost;Initial Catalog=PCBuilder;Integrated Security=True";

        /// <summary>
        /// Gets the database connection.
        /// </summary>
        /// <returns>SqlConnection object.</returns>
        public static SqlConnection GetDBConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
