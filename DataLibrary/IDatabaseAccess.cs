using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataLibrary
{
    public interface IDatabaseAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);

        Task ImportData(string sql, SingleRoute route, string connectionString);

        Task<string[]> GetUniqueValues (string value, string connectionString);

        void ImportAll(string connectionString);
        string  GetDirectory();

        Task<string> GetChainID(string sql, string connectionString);

        Task<List<TradeRoute>> LoadChain(string chainID, string connectionString);

        Task<Vector2> GetCoord(string location,string connectionString);
    }
}
