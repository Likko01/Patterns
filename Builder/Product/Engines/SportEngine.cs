using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product.Engines
{
    class SportEngine : IEngine
    {
        public int HorsePower => 400;
        public string Type => "Sport Engine";
    }
}
