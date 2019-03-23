using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IConnectorWall
    {
        int ID { get;}

        string Name { get; set;}

        int Number { get; set;}

        string Tag { get; set;}

        bool IsWorking { get; set;}

        /// <summary>
        /// if there is no connection,
        /// than it is empty
        /// </summary>
        bool IsEmpty { get; set;}

        /// <summary>
        /// ConnectorTypeName has to be unique, 
        /// because it is the index at LocationType class
        /// </summary>
        string ConnectorTypeName { get; set;}

        ConnectorType Type { get; set;}

        ILocation ParentLocation { get; set;}

        ISymbol Sign { get; set;}
    }
}
