using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPortActive : IPort
    {
        string Layer2Address  {get; set; }

        string Layer3Address  {get; set; }

        string MacAddress {get; set; }

        /// <summary>
        /// TypeName has to be unique,
        /// because it is index of PortTypeActive class
        /// </summary>
        string ActiveTypeName {get; }

    }
}
