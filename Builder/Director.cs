using Builder.Builders;
using Builder.Product.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new SportEngine());
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }

        public void ConstructCityCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine(new CityEngine());
            builder.SetTripComputer(true);
            builder.SetGPS(false);
        }
        public void ConstructCheapSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new CityEngine());
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }
    }
}
