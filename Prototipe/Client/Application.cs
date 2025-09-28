using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipe.Client
{
    class Application
    {
        private List<Shape> shapes = new List<Shape>();
        public Application()
        {
            var circle = new Circle { X = 10, Y = 10, Radius = 20, Color = "Red"};
            shapes.Add(circle);

            var anotherCircle = circle.Clone();
            shapes.Add(anotherCircle);

            var rectangle = new Rectangle { width = 10, height = 20, Color = "Blue" };
            shapes.Add(rectangle);
        }
        public void BusinessLogic()
        {
            var shapesCopy = new List<Shape>();
            foreach (var s in shapes)
            {
                shapesCopy.Add(s.Clone());
            }
            Console.WriteLine("Original count: " + shapes.Count);
            Console.WriteLine("Copy count: " + shapesCopy.Count);
        }
    }
}
