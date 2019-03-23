using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;


namespace Data_layer.Interfaces
{
    interface IDataService
    {
        IError InsertItem(IItem item);

        IError InsertPort(IPortActive port);

        IError InsertConnection(IConnection connection);

        IError InsertLocation(ILocation location);

        IError UpdateItem(IItem item);

        IError UpdatePort(IPortActive port);

        IError UpdateConnection(IConnection connection);

        IError UpdateLocation(ILocation location);

        IError DeleteItem(IItem item);

        IError DeletePort(IPortActive port);

        IError DeleteConnection(IConnection connection);

        IError DeleteLocation(ILocation location);




    }
}
