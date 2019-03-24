using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPortActive : IPort
    {
        UInt64 Layer2Address  {get; set; }

        UInt32 Layer3Address  {get; set; }

        UInt64 MacAddress {get; set; }

        /// <summary>
        /// TypeName has to be unique,
        /// because it is index of PortTypeActive class
        /// </summary>
        string ActiveTypeName {get; }

    }
}
