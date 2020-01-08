using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ParteSur: Colegas
    {
        public ParteSur(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)//espera un parametro de tipo string
        {
            Console.WriteLine("ParteSur envía mensaje: " + message);
            mediator.SendMessage(message, this); 
        }

        public void Notify(string message)// espera un parametro de tipo string
        {
            Console.WriteLine("Parte sur recibe mensaje: " + message);
        }
    }
}
