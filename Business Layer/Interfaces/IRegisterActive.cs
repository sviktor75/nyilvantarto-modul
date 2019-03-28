using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterActive
    {
        IItemActive this[int ID] { get; }

        IError Add(IItemActive item);

        IError Remove(IItemActive item);

        IError RemoveByID(int id);
    }
}
