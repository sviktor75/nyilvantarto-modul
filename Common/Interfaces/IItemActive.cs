using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface  IItemActive : IItem
    {
        IList<IPortActive> GetPortsList();

        IError AddPort(IPortActive port);

        IError RemovePort(IPortActive port);

        IError GetPortByID(IPortActive port);

        IError RemovePortByID(IPortActive port);
    }
}
