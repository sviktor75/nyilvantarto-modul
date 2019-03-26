using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterPassive
    {
        IItemPassive this[int ID] { get; set; }

        IError Add(IItemPassive item);

        IError Remove(IItemPassive item);

        IError RemoveByID(IItemPassive item);
    }
}
