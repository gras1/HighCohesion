using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.HighCohesion
{
    public class ConnectionStatistics
    {
        private Dictionary<Connection, int> _connectionUsageCountMap;
        private Dictionary<Connection, int> _connectionUsageTimeMap;

        public Dictionary<Connection, int> GetConnectionCountStats
        {
            get
            {
                return _connectionUsageCountMap;
            }
        }

        public Dictionary<Connection, int> GetConnectionTimeStats
        {
            get
            {
                return _connectionUsageTimeMap;
            }
        }

        public void PersistConnectionRequested(Connection c)
        {
            //do something
        }

        public void PersistConnectionReleased(Connection c)
        {
            //do something
        }
    }
}
