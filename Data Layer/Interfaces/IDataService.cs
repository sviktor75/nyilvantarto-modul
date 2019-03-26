using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;


namespace DataLayer.Interfaces
{
    public interface IDataService
    {
        IError InsertItemActive(IItemActive item);

        IError InsertItemPassive(IItemPassive item);

        IError InsertPortActive(IPortActive port);

        IError InsertPortPassive(IPortPassive port);

        IError InsertConnection(IConnection connection);

        IError InsertLocation(ILocation location);

        IError InsertConnectorWall(IConnectorWall connector);

        IError InsertSymbol(ISymbol symbol);

        IError UpdateItemActive(IItemActive item);

        IError UpdateItemPassive(IItemPassive item);

        IError UpdatePortActive(IPortActive port);

        IError UpdatePortPassive(IPortPassive port);

        IError UpdateConnection(IConnection connection);

        IError UpdateLocation(ILocation location);

        IError UpdateConnectorWall(IConnectorWall connector);

        IError UpdateSymbol(ISymbol symbol);

        IError DeleteItemActive(IItemActive item);

        IError DeleteItemPassive(IItemPassive item);

        IError DeletePortActive(IPortActive port);

        IError DeletePortPassive(IPortPassive port);

        IError DeleteConnection(IConnection connection);

        IError DeleteLocation(ILocation location);

        IError DeleteConnectorWall(IConnectorWall connector);

        IError DeleteSymbol(ISymbol symbol);

        IList<IItemActive> GetItemActive();

        IList<IItemPassive> GetItemPassive();

        IList<IPortActive> GetPortActive();

        IList<IPortPassive> GetPortPassive();

        IList<IConnection> GetConnection();

        IList<ILocation> GetLocation();

        IList<IConnectorWall> GetConnectorWall();

        IList<ISymbol> GetSymbol();

        IItemActive GetItemActiveByID();

        IItemPassive GetItemPassiveByID();

        IPortActive GetPortActiveByID();

        IPortPassive GetPortPassiveByID();

        IConnection GetConnectionByID();

        ILocation GetLocationByID();

        IConnectorWall GetConnectorWallByID();

        ISymbol GetSymbolByID();

        // Helper classes
        IError InsertItemActive(IIDGenerator generator);
        IError UpdateItemActive(IIDGenerator generator);
        IError GetItemActive(IIDGenerator generator);
    }
}
