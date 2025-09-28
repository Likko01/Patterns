using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipe
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public Shape() { }

        public Shape(Shape source)
        {
            if (source != null)
            {
                this.X = source.X;
                this.Y = source.Y;
                this.Color = source.Color;
            }
        }

        public abstract Shape Clone();
    }
}
