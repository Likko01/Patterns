using AbstractFabric.Product.Interface;
using AbstractFabric.Product.RedUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Fabric
{
    class RedFactory : IAbstractFactory
    {
        public IKnight CreateKnight()
        {
            return new RedKnight();
        }

        public IWizard CreateWizard()
        {
            return new RedWizard();
        }
    }
}
