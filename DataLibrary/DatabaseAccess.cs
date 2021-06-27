using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DataLibrary
{
    public class DatabaseAccess:IDatabaseAccess
    {
        /// <summary>
        /// generic data query with parameters
        /// </summary>
        /// <typeparam name="T">list content type</typeparam>
        /// <typeparam name="U">MySQL parameters</typeparam>
        /// <param name="sql">sql query string</param>
        /// <param name="parameters">sql parameters</param>
        /// <param name="connectionString"></param>
        /// <returns>async list of queried results</returns>
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

        /// <summary>
        /// import all content of csv file into databse
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public void ImportAll(string connectionString)
        {
            try
            {
                string fileString = GetDirectory() + "/Files/Routes.csv";
                string[] allLines = File.ReadAllLines(fileString);
                allLines = allLines.Skip(1).ToArray();
                List<SingleRoute> routes = new List<SingleRoute>();
                int count = 0;
                using (IDbConnection conn = new MySqlConnection(connectionString))
                {
                    foreach (string s in allLines)
                    {
                        Debug.WriteLine(s);
                        routes.Add(RouteBuilder(s));
                        count++;
                    }
                }
                Debug.WriteLine(count);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        SingleRoute RouteBuilder(string s)
        {
            string[] postSplit = s.Split(',');
            return new SingleRoute
            {
                Chain = postSplit[0],
                Tier = GetTier(postSplit[1]),
                Location = postSplit[2],
                ItemActual = postSplit[3],
                ItemTo = postSplit[4],
                ChainID = double.Parse(postSplit[5]),
                SubPaste = postSplit[6],
                Amount = GetAmount(postSplit[7]),
                Verified = GetVerified(postSplit[8]),
                LocationIndex = Int32.Parse(postSplit[9])
            };

        }

        int GetTier(string s)
        {
            int value;
            if(int.TryParse(s.Substring(s.Length-2,1),out value))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        int GetAmount(string s)
        {
            int value;
            if(int.TryParse(s, out value))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        int GetVerified(string s)
        {
            if (s == "V")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Task ImportData(string sql,SingleRoute route , string connectionString)
        {
            string fileString = GetDirectory() + "/Files/Routes.csv";
            string[] allLines = File.ReadAllLines(fileString);
            foreach (string s in allLines)
            {

            }
            using(IDbConnection conn = new MySqlConnection(connectionString))
            {
                return null;
            }
        }



        public string GetDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }
    }
}
