using Builder.Product;
using Builder.Product.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class CarBuilder : IBuilder
    {
        private Car car = new Car();

        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(IEngine engine)
        {
            car.Engine = engine;
        }

        public void SetGPS(bool hasGPS)
        {
            car.HasGPS = hasGPS;
        }

        public void SetSeats(int number)
        {
            car.Seats = number;
        }

        public void SetTripComputer(bool hasComputer)
        {
            car.HasTripComputer = hasComputer;

        }
        public Car GetResult()
        {
            return car;
        }
    }
}
