using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StatePattern
{
    //Se insertan los objetos de las diferentes clases derivadas con sus respectivas respuestas que arrojara dependiendo de la funcion que se inserte y que llamara a las diferentes 
    //clases con sus respuestas//
    class Program
    {
        static void Main(string[] args)
        {
            ServidorContext oServior = new ServidorContext();
            oServior.State = new DisponibleServerState();

            oServior.AtenderSolicitud();

            oServior.State = new SaturadoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new SuperSaturadoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new CaidoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new DisponibleServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

        }
    }
}
