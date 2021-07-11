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
    public class DatabaseAccess : IDatabaseAccess
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
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection conn = new MySqlConnection(connectionString))
            {
                var rows = await conn.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }
        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection conn = new MySqlConnection(connectionString))
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
                string[] input = File.ReadAllLines(fileString);
                List<Trade> routes = new List<Trade>();
                Trade currRoute;
                Debug.WriteLine("Input length: " + input.Length);
                for (int i = 1; i < input.Length; i++)
                {
                    string[] startLine = input[i].Split(',');
                    //Debug.WriteLine(i);
                    currRoute = new Trade
                    {
                        ID = startLine[5],
                        subPaste = startLine[6],
                        location = startLine[2],
                        give = startLine[3],
                        receive = startLine[4],
                        tier = GetTier(startLine[1]).ToString(),
                        quantity = GetAmount(startLine[7]).ToString()
                    };
                    routes.Add(currRoute);

                    //Debug.WriteLine(i.ToString());
                }
                int count = 0;
                Debug.WriteLine("Routes count: " + routes.Count);
                Debug.WriteLine(connectionString);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    Debug.WriteLine(conn.State);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO itemroutes(id,subpaste,location,give,receive,tier,quantity) VALUES(@id,@subpaste,@location,@give,@receive,@tier,@quantity)";
                    cmd.Connection = conn;
                    foreach (Trade s in routes)
                    {
                        Debug.WriteLine(s.OutputString());
                        count++;
                        cmd.Parameters.AddWithValue("@id", s.ID);
                        cmd.Parameters.AddWithValue("@subpaste", s.subPaste);
                        cmd.Parameters.AddWithValue("@location", s.location);
                        cmd.Parameters.AddWithValue("@give", s.give);
                        cmd.Parameters.AddWithValue("@receive", s.receive);
                        cmd.Parameters.AddWithValue("@tier", s.tier);
                        cmd.Parameters.AddWithValue("@quantity", s.quantity);
                        Debug.WriteLine("got here");
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                Debug.WriteLine(count);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                Debug.WriteLine(err.StackTrace);
            }
        }


        int GetTier(string s)
        {
            int value;
            if (int.TryParse(s.Substring(s.Length - 2, 1), out value))
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
            if (int.TryParse(s, out value))
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

        public Task ImportData(string sql, SingleRoute route, string connectionString)
        {
            string fileString = GetDirectory() + "/Files/Routes.csv";
            string[] allLines = File.ReadAllLines(fileString);
            foreach (string s in allLines)
            {

            }
            using (IDbConnection conn = new MySqlConnection(connectionString))
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
