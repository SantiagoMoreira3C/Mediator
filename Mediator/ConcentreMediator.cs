using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcentreMediator: Mediator

    {
        private ParteNorte _partenorte; // se crea objeto de la clase
        private ParteSur _partesur;// se crea un objeto de la clase
 

        public ParteNorte NorteConcesiones 
        {
            set { _partenorte= value; }
        }

        public ParteSur SurConcesiones
        {
            set { _partesur = value; }
        }

        public ParteNorte ParteNorte { get; internal set; }
        public ParteSur ParteSur { get; internal set; }

        public void SendMessage(string message, Colegas colleague)
        {
            if (colleague == _partenorte) // se crea un condicion para ver quien recibe la notificacion
            {
                _partesur.Notify(message); 
            }
            else
            {
                _partenorte.Notify(message);
            }
        }

        public void SendMessage(string message, ParteNorte parteNorte)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message, ParteSur parteSur)
        {
            throw new NotImplementedException();
        }
    }
}
