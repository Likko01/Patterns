using Builder.Product.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine(IEngine engine);
        void SetTripComputer(bool hasComputer);
        void SetGPS(bool hasGPS);
    }
}
