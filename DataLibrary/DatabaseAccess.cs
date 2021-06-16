using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using Dapper;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DatabaseAccess:IDatabaseAccess
    {
        public async Task<List<T>> LoadData<T,U>(string sql, U parameters, string connectionString)
        {
            using(IDbConnection conn = new MySqlConnection(connectionString))
            {
                var rows = await conn.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }
        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using(IDbConnection conn = new MySqlConnection(connectionString))
            {
                return conn.ExecuteAsync(sql, parameters);
            }
        }
    }
}
