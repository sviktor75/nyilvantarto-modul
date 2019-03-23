using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IItemPassive : IItem
    {
        IList<IPortPassive> GetPortsList();

        IError AddPort(IPortPassive port);

        IError RemovePort(IPortPassive port);

        IError GetPortByID(IPortPassive port);

        IError RemovePortByID(IPortPassive port);
    }
}
