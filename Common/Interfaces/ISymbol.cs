using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Common.Interfaces
{
    public interface ISymbol
    {
        int ID { get; }

        string Name { get; }

        Image Image { get; set; }
    }
}
