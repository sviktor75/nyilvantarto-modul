using Common.Interfaces;
using DataLayer.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataService : IDataService
    {
        private bool isMySQL;
        private LiteRepository repo;

        public DataService(bool isMySQL, LiteRepository repo)
        {
            this.isMySQL = isMySQL;
            this.repo = repo;
        }
        IError IDataService.DeleteConnection(IConnection connection)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeleteConnectorWall(IConnectorWall connector)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeleteItemActive(IItemActive item)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeleteItemPassive(IItemPassive item)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeleteLocation(ILocation location)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeletePortActive(IPortActive port)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeletePortPassive(IPortPassive port)
        {
            throw new NotImplementedException();
        }

        IError IDataService.DeleteSymbol(ISymbol symbol)
        {
            throw new NotImplementedException();
        }

        IList<IConnection> IDataService.GetConnection()
        {
            throw new NotImplementedException();
        }

        IConnection IDataService.GetConnectionByID()
        {
            throw new NotImplementedException();
        }

        IList<IConnectorWall> IDataService.GetConnectorWall()
        {
            throw new NotImplementedException();
        }

        IConnectorWall IDataService.GetConnectorWallByID()
        {
            throw new NotImplementedException();
        }

        IList<IItemActive> IDataService.GetItemActive()
        {
            throw new NotImplementedException();
        }

        IError IDataService.GetItemActive(IIDGenerator generator)
        {
            throw new NotImplementedException();
        }

        IItemActive IDataService.GetItemActiveByID()
        {
            throw new NotImplementedException();
        }

        IList<IItemPassive> IDataService.GetItemPassive()
        {
            throw new NotImplementedException();
        }

        IItemPassive IDataService.GetItemPassiveByID()
        {
            throw new NotImplementedException();
        }

        IList<ILocation> IDataService.GetLocation()
        {
            throw new NotImplementedException();
        }

        ILocation IDataService.GetLocationByID()
        {
            throw new NotImplementedException();
        }

        IList<IPortActive> IDataService.GetPortActive()
        {
            throw new NotImplementedException();
        }

        IPortActive IDataService.GetPortActiveByID()
        {
            throw new NotImplementedException();
        }

        IList<IPortPassive> IDataService.GetPortPassive()
        {
            throw new NotImplementedException();
        }

        IPortPassive IDataService.GetPortPassiveByID()
        {
            throw new NotImplementedException();
        }

        IList<ISymbol> IDataService.GetSymbol()
        {
            throw new NotImplementedException();
        }

        ISymbol IDataService.GetSymbolByID()
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertConnection(IConnection connection)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertConnectorWall(IConnectorWall connector)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertItemActive(IItemActive item)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertItemActive(IIDGenerator generator)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertItemPassive(IItemPassive item)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertLocation(ILocation location)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertPortActive(IPortActive port)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertPortPassive(IPortPassive port)
        {
            throw new NotImplementedException();
        }

        IError IDataService.InsertSymbol(ISymbol symbol)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateConnection(IConnection connection)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateConnectorWall(IConnectorWall connector)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateItemActive(IItemActive item)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateItemActive(IIDGenerator generator)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateItemPassive(IItemPassive item)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateLocation(ILocation location)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdatePortActive(IPortActive port)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdatePortPassive(IPortPassive port)
        {
            throw new NotImplementedException();
        }

        IError IDataService.UpdateSymbol(ISymbol symbol)
        {
            throw new NotImplementedException();
        }
    }
}
