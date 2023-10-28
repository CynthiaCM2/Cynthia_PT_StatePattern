using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StatePattern
{
    //Se crea la clase derivada de la interfaz con el objeto//
    public class CaidoServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 503");
        }
    }
}
