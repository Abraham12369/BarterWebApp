using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public interface IRoutesRepository
    {
        IEnumerable<ItemRoutes> GetRoutes();
        bool Import(ItemRoutes route);
        bool Update(ItemRoutes route);
        bool Delete(ItemRoutes route);
    }
}
