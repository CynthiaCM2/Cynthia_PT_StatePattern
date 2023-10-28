using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StatePattern
{

    //Se creara la clase derivada de la interfaz con otro objeto//
    class DisponibleServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 200");
        }
    }
}
