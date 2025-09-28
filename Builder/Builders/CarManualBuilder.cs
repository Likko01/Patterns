using Builder.Product;
using Builder.Product.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    class CarManualBuilder : IBuilder
    {
        private CarManual carManual = new CarManual ();

        public void Reset()
        {
            carManual = new CarManual();
        }

        public void SetEngine(IEngine engine)
        {
            carManual.Content += $"Engine: {engine.GetType().Name}\n";
        }

        public void SetGPS(bool hasGPS)
        {
            carManual.Content += $"GPS: {hasGPS}\n";
        }

        public void SetSeats(int number)
        {
            carManual.Content += $"Seats: {number}\n";
        }

        public void SetTripComputer(bool hasComputer)
        {
            carManual.Content += $"TripComputer: {hasComputer}\n";
        }
        public CarManual GetResult()
        {
            return carManual;
        }
    }
}
