using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
    }
}
