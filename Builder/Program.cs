using Builder.Builders;

namespace Builder

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CarBuilder();
            director.ConstructCityCar (builder);
            var car = builder.GetResult();
            Console.WriteLine(car);
        }
    }
}
