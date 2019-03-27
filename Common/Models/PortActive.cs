using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace Common
{
    public class PortActive : IPortActive
    {
        private string ipAddress;
        private string macAddress;
        private string activeTypeName;
        private string portConfig;
        private int itemID;
        private int portNumber;
        private string portID;
        private string portName;
        private string portPhysicalType;
        private int symbolID;
        private string physicalLocation;

        string IPortActive.MacAddress
        {
            get => macAddress;
            set => macAddress = value;
        }
        string IPortActive.IPAddress
        {
            get => ipAddress;
            set => ipAddress = value;
        }
        string IPortActive.PortConfig
        {
            get => portConfig;
            set => portConfig = value;
        }
        int IPort.ItemID
        {
            get => itemID;
            set => itemID = value;
        }
        int IPort.PortNumber
        {
            get => portNumber;
            set => portNumber = value;
        }
        string IPort.PortID
        {
            get => portID;
            set => portID = value;
        }
        string IPort.PortName
        {
            get => portName;
            set => portName = value;
        }
        string IPort.PortPhysicalType
        {
            get => portPhysicalType;
            set => portPhysicalType = value;
        }
        int IPort.SymbolID
        {
            get => symbolID;
            set => symbolID = value;
        }
        string IPort.PhysicalLocation
        {
            get => physicalLocation;
            set => physicalLocation = value;
        }
    }
}
