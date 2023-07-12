using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        /**
         * string sql = sql statement to be executed
         * U parameters = any extra parameters added
         * string connectionString = connection string that routes to the server being accessed
         * This class is used to load data from an sql table, and place it into a generic list.
         * @return Task of a List as Generics from fetching data in the list.
         */
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            /*using statement so it closes the connection from closing, crashing, completion,..etc*/
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                /*await needs to be performed to ensure completion before returning the list*/
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        /**
         * string sql = statement to be executed
         * T parameters = any extra parameters added as a generic type
         * string connectionString = connection string that routes to the server being accessed
         * Quickly save new data to the database.
         * @return Task completed
         */
        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            /*using statement so it closes the connection from closing, crashing, completion,..etc*/
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                /*Execute the statement sent for the save data method*/
                return connection.ExecuteAsync(sql, parameters);

            }
        }
    }
}
