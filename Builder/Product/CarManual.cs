using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    class CarManual
    {
        public string Content { get; set; } = "";

        public override string ToString()
        {
            return $"Manual:\n{Content}";
        }
    }
}
