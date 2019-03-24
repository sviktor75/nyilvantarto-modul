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
        string Name { get; set; }

        Image Image { get; set; }
    }
}
