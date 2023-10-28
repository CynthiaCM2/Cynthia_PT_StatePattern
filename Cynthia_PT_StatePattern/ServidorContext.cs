using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StatePattern
{

    //Se crea la clase del contexto de la clase que hara que se atiendan las solicitudes que aparezca la respuesta insertada//
    public class ServidorContext
    {
        private ServerState state;

        public ServerState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }

        }
         
        public void AtenderSolicitud()
        {
            state.Respuesta();
        }
    }
}
