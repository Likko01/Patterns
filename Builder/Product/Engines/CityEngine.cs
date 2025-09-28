using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product.Engines
{
    class CityEngine : IEngine
    {
        public int HorsePower => 120;
        public string Type => "City Engine";

    }
}
