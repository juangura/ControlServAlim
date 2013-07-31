using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comedor.Modelo
{
    public class mdlGrupo
    {
        String idgrupo;

        public String IdGrupo
        {
            get { return idgrupo; }
            set { idgrupo = value; }
        }

        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
