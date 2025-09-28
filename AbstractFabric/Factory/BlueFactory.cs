using AbstractFabric.Product.BlueUnits;
using AbstractFabric.Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Fabric
{
    class BlueFabric : IAbstractFactory
    {
        public IKnight CreateKnight()
        {
            return new BlueKnight();
        }
        public IWizard CreateWizard()
        {
            return new BlueWizard();
        }
    }
}
