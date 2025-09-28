using Builder.Product.Engines;

namespace NaiveDirector.Builders
{
    internal interface INewBuilder
    {
        INewBuilder Reset();
        INewBuilder SetSeats(int number);
        INewBuilder SetEngine(IEngine engine);
        INewBuilder SetTripComputer(bool hasComputer);
        INewBuilder SetGPS(bool hasGPS);
    }
}
