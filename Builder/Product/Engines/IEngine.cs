using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product.Engines
{
    internal interface IEngine
    {
        int HorsePower { get; }
        string Type { get; }
    }
}
