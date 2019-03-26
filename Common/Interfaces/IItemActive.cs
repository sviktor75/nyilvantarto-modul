﻿using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface  IItemActive : IItem
    {
        /// <summary>
        /// Get the list of IDs of ports
        /// </summary>
        /// <returns></returns>
        IList<int> GetPortsIDList();

        IError AddPort(IPortActive port);

        IError RemovePort(IPortActive port);

        IPortActive GetPortByID(int id);

        IError RemovePortByID(int id);
    }
}
