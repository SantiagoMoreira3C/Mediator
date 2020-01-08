using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // Primero, necesitaremos nuestra interfaz de Mediador , que define un método por el cual las barras de bocadillos pueden comunicarse entre sí:
    interface Mediator
    {
        void SendMessage(string message, Colegas consesion);
        void SendMessage(string message, ParteNorte parteNorte);
        void SendMessage(string message, ParteSur parteSur);
    }
}
