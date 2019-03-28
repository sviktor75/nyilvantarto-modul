using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterLocation
    {
        ILocation this[int ID] { get; }

        IError Add(ILocation location);

        IError Remove(ILocation location);

        IError RemoveByID(ILocation location);
    }
}
