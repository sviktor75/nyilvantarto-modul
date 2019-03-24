using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Interfaces
{
    public interface IRegisterActive
    {
        IItemActive this[int ID] { get; set; }

        IError Add(IItemActive item);

        IError Remove(IItemActive item);

        IError RemoveByID(IItemActive item);
    }
}
