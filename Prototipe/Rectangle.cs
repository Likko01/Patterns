using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipe
{
    class Rectangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }
            
        public Rectangle() { }
        public Rectangle(Rectangle source) : base (source)
        {
            this.width = source.width;
            this.height = source.height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

    }
}
