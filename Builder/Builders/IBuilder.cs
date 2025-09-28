using Builder.Product.Engines;

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
