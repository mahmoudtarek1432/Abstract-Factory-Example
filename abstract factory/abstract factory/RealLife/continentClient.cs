using abstract_factory.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory.RealLife
{
    internal class continentClient
    {
        public ContinentFactory _factory;

        public continentClient(ContinentFactory factory)
        {
            _factory = factory;
        }

        public void runWild()
        {
            var carnivore = _factory.CreateCarnivore();
            var herbivore = _factory.CreateHerbivore();

            herbivore.Run(carnivore);
            carnivore.Eat(herbivore);

        }

    }
}
