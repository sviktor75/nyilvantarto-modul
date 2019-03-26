using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterConnector
    {
        IConnectorWall this[int ID] { get; set; }

        IError Add(IConnectorWall connector);

        IError Remove(IConnectorWall connector);

        IError RemoveByID(IConnectorWall connector);
    }
}
