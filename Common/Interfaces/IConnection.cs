using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IConnection
    {
        int ID { get;}

        string Name { get; set;}

        int DestinationItemID { get; set; }

        int DestinationPortID { get; set; }

    }
}
