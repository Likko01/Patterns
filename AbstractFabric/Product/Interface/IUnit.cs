using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Product.Interface
{
    interface IUnit
    {
        int damage { get; set; }
        int health { get; set; }
    }
}
