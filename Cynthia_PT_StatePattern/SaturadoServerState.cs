using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StatePattern
{

    //Se crea la clase derivada de la interfaz con la respuesta a atender//
    class SaturadoServerState : ServerState
    {
        public override void Respuesta()
        {
            Task.Delay(500);
            Console.WriteLine("Respuesta 200 con un delaye de 500");
        }
    }
}
