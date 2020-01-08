using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
                ConcentreMediator mediator1= new ConcentreMediator();

            ParteNorte leftKitchen = new ParteNorte(mediator1);
            ParteSur rightKitchen = new ParteSur(mediator1);

            mediator1.ParteNorte = leftKitchen;
            mediator1.ParteSur = rightKitchen;

            leftKitchen.Send("¿Puedes envíar palomitas de maíz");
            rightKitchen.Send("Claro, Kenny está en camino..");

            rightKitchen.Send("¿Tienes perros calientes extra ? Hemos tenido prisa por ellos por aquí.");
            leftKitchen.Send("Solo un par, enviaremos a Kenny con ellos.");

            Console.ReadKey();
        }
    }
}
