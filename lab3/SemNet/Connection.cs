using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setee
{
    class Connection
    {
        public Entity Qust2 { get; private set; }
        public Entity Successor { get; private set; }
        public string ConnectionType { get; private set; }

        public Connection(Entity quest2, Entity successor, string connectionType)
        {
            Qust2 = quest2;
            Successor = successor;
            ConnectionType = connectionType;
        }

        public Connection( string connectionType)
        {
           
            ConnectionType = connectionType;
        }

        public Connection SetEntitys(Entity quest2, Entity successor)
        {
            Qust2 = quest2;
            Successor = successor;
            quest2.AddConnection(this);
            successor.AddConnection(this);
            return this;
        }
    }
}
