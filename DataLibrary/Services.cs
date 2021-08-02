using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataLibrary
{
    public class Services :IServices
    {
        private readonly IDatabaseAccess IDatabaseAccess;
        public Services(IDatabaseAccess access)
        {
            IDatabaseAccess = access;
        }
        public async Task<Tuple<TradeRoute, float>> GetTotalDistance(TradeRoute route,string connectionString)
        {
            Vector2 loc1;
            Vector2 loc2;
            Vector2 loc3;
            Vector2 loc4;
            Vector2 loc5;
            //Vector2 loc6;
            Console.WriteLine("\n starting location grab");
            loc1 = await IDatabaseAccess.GetCoord(route.Location0, connectionString);
            loc2 = await IDatabaseAccess.GetCoord(route.Location1, connectionString);
            loc3 = await IDatabaseAccess.GetCoord(route.Location2, connectionString);
            loc4 = await IDatabaseAccess.GetCoord(route.Location3, connectionString);
            loc5 = await IDatabaseAccess.GetCoord(route.Location4, connectionString);
            //loc6 = await IDatabaseAccess.GetCoord(route.Location5, connectionString);
            Console.WriteLine(loc1.X+ "\t" + loc1.Y);
            Console.WriteLine(loc2.X+ "\t" + loc2.Y);
            Console.WriteLine(loc3.X+ "\t" + loc3.Y);
            Console.WriteLine(loc4.X+ "\t" + loc4.Y);
            Console.WriteLine(loc5.X+ "\t" + loc5.Y);
            //Console.WriteLine(loc6.X+ "\t" + loc6.Y);

            float distance1 = GetDistance(loc1,loc2);
            float distance2 = GetDistance(loc2,loc3);
            float distance3 = GetDistance(loc3,loc4);
            float distance4 = GetDistance(loc4,loc5);
            //float distance5 = GetDistance(loc5,loc6);
            Console.WriteLine("reached end of calculation");
            float distance = distance1 + distance2 + distance3 + distance4;
            Console.WriteLine("totol distance: " + distance);
            return new Tuple<TradeRoute,float>(route, distance1 + distance2 + distance3 + distance4);

        }

        public float GetDistance(Vector2 loc1, Vector2 loc2)
        {
            return Vector2.Distance(loc1, loc2);
        }
    }
}
