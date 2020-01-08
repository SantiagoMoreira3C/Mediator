using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //También necesitamos una clase abstracta para representar a los colegas que hablarán entre ellos:
    abstract class Colegas
    {
        protected Mediator mediator;

        public Colegas (Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
}
