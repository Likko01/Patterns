using AbstractFabric.Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Fabric
{
    interface IAbstractFactory
    {
        public IKnight CreateKnight();
        public IWizard CreateWizard();
    }
}
