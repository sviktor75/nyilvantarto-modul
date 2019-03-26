using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRegisterSymbol
    {
        ISymbol this[int ID] { get; set; }

        IError Add(ISymbol symbol);

        IError Remove(ISymbol symbol);

        IError RemoveByID(ISymbol symbol);
    }
}
