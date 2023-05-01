using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory.structure
{
    internal class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();    
        }

        public void run()
        {
            _productB.interact(_productA);
        }
    }
}
