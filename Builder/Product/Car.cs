using Builder.Product.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    class Car
    {
        public int Seats { get; set; }
        public IEngine Engine { get; set; }
        public bool HasTripComputer { get; set; }
        public bool HasGPS { get; set; }

        public override string ToString()
        {
            return $"Car: Seats={Seats}, Engine={Engine.Type} ({Engine.HorsePower} HP), " +
                   $"TripComputer={HasTripComputer}, GPS={HasGPS}";
        }
    }
}
