using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPort
    {
        int ID { get;}

        string Name { get; set;}

        bool IsWorking { get; set;}

        /// <summary>
        /// if there is no connection,
        /// than it is empty
        /// </summary>
        bool IsEmpty { get; set;}
    }
}
