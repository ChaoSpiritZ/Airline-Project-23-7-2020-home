using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    static class RedisConfig
    {
        public const int UpdateInterval = 10;
        public const string GetDepartingFlightsFullData = "GetDepartingFlightsFullData";
        public const string GetLandingFlightsFullData = "GetLandingFlightsFullData";
    }
}
