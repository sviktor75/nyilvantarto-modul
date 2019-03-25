using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IIDGenerator
    {
         int ActualItemID {get; set; }
         int ActualLocationID {get; set; }
         int ActualPortID {get; set; }
         int ActualConnectionID {get; set; }
         int ActualConnectorWallID {get; set; }
         int ActualSymbolID {get; set; }
    }
}
