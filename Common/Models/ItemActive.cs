using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ItemActive : IItemActive
    {
        private int id;
        private int locationID;
        private int symbolID;
        private string deviceID;
        private string deviceName;
        private string notes;

        int IItem.ID { get => id; } 

        int IItem.LocationID { get => locationID; set => locationID = value; }

        int IItem.SymbolID { get => symbolID; set => symbolID = value; }

        string IItem.DeviceID
        {
            get => deviceID;
            set => deviceID = value;
        }
        string IItem.DeviceName
        {
            get => deviceName;
            set => deviceID = value;
        }
        string IItem.Notes
        {
            get => notes;
            set => notes = value;
        }

        IError IItem.AddConnection(IConnection connection)
        {
            throw new NotImplementedException();
        }

        IError IItemActive.AddPort(IPortActive port)
        {
            throw new NotImplementedException();
        }

        IConnection IItem.GetConnectionByID(int id)
        {
            throw new NotImplementedException();
        }

        IList<int> IItem.GetConnectionsIDList()
        {
            throw new NotImplementedException();
        }

        IPortActive IItemActive.GetPortByID(int id)
        {
            throw new NotImplementedException();
        }

        IList<int> IItemActive.GetPortsIDList()
        {
            throw new NotImplementedException();
        }

        IError IItem.RemoveConnection(IConnection connection)
        {
            throw new NotImplementedException();
        }

        IError IItem.RemoveConnectionByID(int id)
        {
            throw new NotImplementedException();
        }

        IError IItemActive.RemovePort(IPortActive port)
        {
            throw new NotImplementedException();
        }

        IError IItemActive.RemovePortByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
