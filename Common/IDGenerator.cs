using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IDGenerator : IIDGenerator
    {
        private int actualItemID;
        private int actualLocationID;
        private int actualPortID;
        private int actualConnectionID;
        private int actualConnectorWallID;
        private int actualSymbolID;

        int IIDGenerator.ActualItemID { get => actualItemID; set => actualItemID = value; }
        int IIDGenerator.ActualLocationID { get => actualLocationID; set => actualLocationID = value; }
        int IIDGenerator.ActualPortID { get => actualPortID; set => actualPortID = value; }
        int IIDGenerator.ActualConnectionID { get => actualConnectionID; set => actualConnectionID = value; }
        int IIDGenerator.ActualConnectorWallID { get => actualConnectorWallID; set => actualConnectorWallID = value; }
        int IIDGenerator.ActualSymbolID { get => actualSymbolID; set => actualSymbolID = value; }
    }
}
