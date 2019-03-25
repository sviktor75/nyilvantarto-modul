using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Interfaces
{
    public interface IRegisterPortPassive
    {
        IPortPassive this[int ID] { get; set; }

        IError Add(IPortPassive port);

        IError Remove(IPortPassive port);

        IError RemoveByID(IPortPassive port);
    }
}
