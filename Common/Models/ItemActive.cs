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
        private string name;

        public ItemActive()
        {
            id = Helpers.GenerateItemtID();
        }
        int IItem.ID { get => id; } 

        string IItem.Name { get => name; set => name = value; }
        int IItem.LocationID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IItem.SymbolID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IItem.Remarks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IItem.IsWorking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IItem.IsError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
