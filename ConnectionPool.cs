using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.HighCohesion
{
    public class ConnectionPool
    {
        //http://stackoverflow.com/questions/3085285/cohesion-coupling

        private List<Connection> _freeConnectionList;
        private List<Connection> _inUseConnectionList;
        private ConnectionStatistics _connStats;
        private PersistentStore _store;

        public Connection GetConnection
        {
            get
            {
                return new Connection();
            }
        }

        public void ReleaseConnection(Connection c)
        {
            //do something
        }
    }
}
