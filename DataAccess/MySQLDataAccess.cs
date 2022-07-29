using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MySQLDataAccess : IMySQLDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var rows = await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        // params 
        // -the sql query to be executed
        // - an object of type T containing the parameters
        // - the connection string
        // executes the sql query but as part of the query get the ID of the last insert
        // returns the ID
        public async Task<int> CreateRecordReturnID<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //return connection.QueryAsync<int>(sql + "SELECT LAST_INSERT_ID();", parameters);

                //try this if above is not working
                var newId = await connection.QueryAsync<int>(sql + "SELECT LAST_INSERT_ID();", parameters);
                return newId.Single();
            }
        }


        //Task<int> IMySQLDataAccess.CreateRecordReturnID<T>(string sql, T parameters, string connectionString)
        //{
        //    throw new NotImplementedException();
        //}

    }
}