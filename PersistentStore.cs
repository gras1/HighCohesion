using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.HighCohesion
{
    public class PersistentStore
    {
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
