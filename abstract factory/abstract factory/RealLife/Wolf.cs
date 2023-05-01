using abstract_factory.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory.RealLife
{
    internal class Wolf : Carnivore
    {
        public override void Eat(Herbivore prey)
        {
            Console.WriteLine($"{this.GetType().Name} is hunting down {prey.GetType().Name}.");
        }
    }
}
