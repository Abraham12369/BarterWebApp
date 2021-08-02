using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IServices
    {
        Task<Tuple<TradeRoute, float>> GetTotalDistance(TradeRoute route,string connectionString);
    }
}
