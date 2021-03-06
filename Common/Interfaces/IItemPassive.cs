﻿using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IItemPassive : IItem
    {
        /// <summary>
        /// Get the list of IDs of ports
        /// </summary>
        /// <returns></returns>
        IList<int> GetPortsIDList();

        IError AddPort(IPortPassive port);

        IError RemovePort(IPortPassive port);

        IPortPassive GetPortByID(int id);

        IError RemovePortByID(int id);

        IItemPassive Clone(int id);
    }
}
