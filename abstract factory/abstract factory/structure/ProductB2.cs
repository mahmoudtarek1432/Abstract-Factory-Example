using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory.structure
{
    internal class ProductB2 : AbstractProductB
    {
        public override void interact(AbstractProductA product)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + product.GetType().Name);
        }
    }
}
