using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ILocation
    {
        int ID { get; }

        string Name {get; set;}

        /// <summary>
        /// LocationTypeName has to be unique, 
        /// because it is the index at LocationType class
        /// </summary>
        string LocationTypeName { get; }

        ILocation Parent {get; set;}

        ISymbol Sign { get; set; }

        string Description {get; set;}

        string Remarks {get; set;}

        IList<ILocation> GetChildList();

        IError AddChild(ILocation child);

        IError RemoveChild(ILocation child);
    }
}
