using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ParteNorte:Colegas
    {
        private ConcentreMediator mediator1;

        // Constructor
        public ParteNorte(Mediator mediator) : base(mediator)
    {
    }

        

        public void Send(string message)
    {
        Console.WriteLine("ParteNorte envía un mensaje:" + message);
        mediator.SendMessage(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("ParteNorte  recibe mensaje: "  + message);
    }
    }
}
