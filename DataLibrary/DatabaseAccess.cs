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
using System.Numerics;

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
            Debug.WriteLine("this is called");
            try
            {
                string fileString = GetDirectory() + "/Files/Routes.csv";
                string[] fullinput = File.ReadAllLines(fileString);
                int routeCount = 37;
                List<TradeRoute> routes = new List<TradeRoute>();
                for (int routeIndex = 0; routeIndex < routeCount; routeIndex++)
                {

                    for (int subPasteIndex = 0; subPasteIndex < 12; subPasteIndex++)
                    {
                        int startIndex = routeIndex * 72 + subPasteIndex * 6;
                        //string[] input = fullinput[startIndex..(startIndex + 6)];
                        string[] input = fullinput.Skip(startIndex).Take(6).ToArray();
                        string[] line0 = input[0].Split(',');
                        string[] line1 = input[1].Split(',');
                        string[] line2 = input[2].Split(',');
                        string[] line3 = input[3].Split(',');
                        string[] line4 = input[4].Split(',');
                        string[] line5 = input[5].Split(',');
                        //Debug.WriteLine("elements: " + fullinput.Length);
                        //Debug.WriteLine(input[0]);
                        //Debug.WriteLine(input[1]);
                        //Debug.WriteLine(input[2]);
                        //Debug.WriteLine(input[3]);
                        //Debug.WriteLine(input[4]);
                        //Debug.WriteLine(input[5]);
                        //Debug.WriteLine("************");
                        TradeRoute currRoute = new TradeRoute
                        {
                            Chain = line0[0] + line0[5],
                            ChainID = line0[5],
                            SubPaste = line0[6],
                            Location0 = line0[2],
                            Location1 = line1[2],
                            Location2 = line2[2],
                            Location3 = line3[2],
                            Location4 = line4[2],
                            Location5 = line5[2],
                            Item0 = line0[3],
                            Item1 = line1[3],
                            Item2 = line2[3],
                            Item3 = line3[3],
                            Item4 = line4[3],
                            Item5 = line5[3],
                            Item6 = line5[4],
                            Amount = line0[7]
                        };
                        //Debug.WriteLine(startIndex);
                        //Debug.WriteLine(currRoute.OutputString());
                        routes.Add(currRoute);

                    }

                }


                //Debug.WriteLine(i.ToString());

                int count = 0;
                Debug.WriteLine("Routes count: " + routes.Count);
                Debug.WriteLine(connectionString);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    Debug.WriteLine(conn.State);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO itemroutes(chain,location0,location1,location2,location3,location4,location5,item0,item1,item2,item3,item4,item5,item6,chainid,subpaste,amount) VALUES(@chain,@location0,@location1,@location2,@location3,@location4,@location5,@Item0,@Item1,@Item2,@Item3,@Item4,@Item5,@Item6,@id,@subpaste,@quantity)";
                    cmd.Connection = conn;
                    foreach (var s in routes)
                    {
                        //Debug.WriteLine(s.OutputString());
                        count++;
                        cmd.Parameters.AddWithValue("@chain", s.Chain);
                        cmd.Parameters.AddWithValue("@id", s.ChainID);
                        cmd.Parameters.AddWithValue("@subpaste", s.SubPaste);
                        cmd.Parameters.AddWithValue("@location0", s.Location0);
                        cmd.Parameters.AddWithValue("@location1", s.Location1);
                        cmd.Parameters.AddWithValue("@location2", s.Location2);
                        cmd.Parameters.AddWithValue("@location3", s.Location3);
                        cmd.Parameters.AddWithValue("@location4", s.Location4);
                        cmd.Parameters.AddWithValue("@location5", s.Location5);
                        cmd.Parameters.AddWithValue("@Item0", s.Item0);
                        cmd.Parameters.AddWithValue("@Item1", s.Item1);
                        cmd.Parameters.AddWithValue("@Item2", s.Item2);
                        cmd.Parameters.AddWithValue("@Item3", s.Item3);
                        cmd.Parameters.AddWithValue("@Item4", s.Item4);
                        cmd.Parameters.AddWithValue("@Item5", s.Item5);
                        cmd.Parameters.AddWithValue("@Item6", s.Item6);
                        cmd.Parameters.AddWithValue("@quantity", s.Amount);
                        Debug.WriteLine("got here");
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                Debug.WriteLine(count);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
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

        public async Task<string[]> GetUniqueValues(string value, string connectionString)
        {

            List<string> returnList = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT DISTINCT(" + value + ") FROM itemroutes";
                cmd.Connection = conn;
                var reader = await cmd.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Debug.WriteLine(reader[i].ToString());
                            returnList.Add(reader[i].ToString());
                        }
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
            }
            return returnList.ToArray();
        }

        public async Task<string> GetChainID(string sql, string connectionString)
        {
            string chainID="";
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = await cmd.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        chainID = reader[0].ToString();
                    }
                }
                catch(Exception err)
                {
                    Console.WriteLine(err);
                }
            }
            return chainID;
        }

        public async Task<List<TradeRoute>> LoadChain(string chainID, string connectionString)
        {
            List<TradeRoute> returnList = new List<TradeRoute>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT DISTINCT * FROM itemroutes where chainid like " + chainID;
                cmd.Connection = conn;
                //var reader = await cmd.ExecuteReaderAsync();
                returnList = conn.Query<TradeRoute>(cmd.CommandText).ToList();
                returnList.ForEach(TradeRoute => Console.WriteLine(TradeRoute));
                return returnList;
            }
        }

        public async Task<Vector2> GetCoord(string location,string connectionString)
        {
            Debug.WriteLine("geting location: " + location);
            using(MySqlConnection conn=new MySqlConnection(connectionString))
            {
                conn.Open();
                var returnvar = await conn.QueryAsync<LocationCoordiantes>("SELECT * from coordinates where location like '%"+location+"%'").ConfigureAwait(false);
                Console.WriteLine(location +"has "+returnvar.Count()+"matches");
                if (returnvar.Count() > 0)
                {
                    //Console.WriteLine(returnvar.First().);
                    Vector2 returnVec = new Vector2 { X = float.Parse(returnvar.First().locX), Y = float.Parse(returnvar.First().locY) };
                    Console.WriteLine("returning: \t" + location + returnVec.X + "\t" + returnVec.Y);
                    return returnVec;
                }
                else
                {
                    return new Vector2 { X = 0, Y = 0 };
                }
            }
        }
    }
}
