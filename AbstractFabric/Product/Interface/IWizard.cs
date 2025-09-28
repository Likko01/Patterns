using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Product.Interface
{
    interface IWizard: IUnit
    {
        void CastSpell();
    }
}
