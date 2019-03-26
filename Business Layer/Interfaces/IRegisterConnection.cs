using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterConnection
    {
        IConnection this[int ID] { get; set; }

        IError Add(IConnection connection);

        IError Remove(IConnection connection);

        IError RemoveByID(IConnection connection);
    }
}
