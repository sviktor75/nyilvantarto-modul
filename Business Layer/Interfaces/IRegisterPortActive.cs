using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterPortActive
    {
        IPortActive this[int ID] { get; set; }

        IError Add(IPortActive port);

        IError Remove(IPortActive port);

        IError RemoveByID(IPortActive port);
    }
}
