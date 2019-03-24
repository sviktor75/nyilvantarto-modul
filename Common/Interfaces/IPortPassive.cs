using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPortPassive : IPort
    {
        /// <summary>
        /// TypeName has to be unique,
        /// because it is index of PortTypePassive class
        /// </summary>
        string PassiveTypeName { get; }
    }
}
