using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IItem
    {
        int ID { get; }

        string Name {get; set;}
        
        ILocation Where  {get; set;}
        
        ISymbol Sign { get; set;}

        string Remarks {get; set;}

        bool IsWorking {get; set;}

        bool IsError {get; set;}

        

        IList<IConnection> GetConnectionsList();

        IError AddConnection(IConnection connection);

        IError RemoveConnection(IConnection connection);

        IError GetConnectionByID(IConnection connection);

        IError RemoveConnectionByID(IConnection connection);
    }
}
