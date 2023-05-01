using abstract_factory.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory.RealLife
{
    internal class Ostritch : Herbivore
    {
        public override void Run(Carnivore C)
        {
            Console.WriteLine($"{this.GetType().Name} is running from {C.GetType().Name}.");
        }
    }
}
