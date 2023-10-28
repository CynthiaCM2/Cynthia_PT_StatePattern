using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StatePattern
{
    //Se crea la clase derivada de la interfaz con sus objetos y funciones//
    class SuperSaturadoServerState : ServerState
    {
        public override void Respuesta()
        {
            Task.Delay(1000);
            Console.WriteLine("Respuesta 200 con un delaye de 1000");
        }
       
    }
}
