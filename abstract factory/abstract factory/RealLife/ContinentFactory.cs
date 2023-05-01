using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory.NewFolder
{
    abstract class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }
}
