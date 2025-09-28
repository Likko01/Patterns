using AbstractFabric.Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Product.RedUnits
{
    class RedKnight : IKnight
    {
        public int damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
