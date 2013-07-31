using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comedor.Modelo
{
    public class mdlPersona
    {
        private String idpersona;

        public String IdPersona
        {
            get { return idpersona; }
            set { idpersona = value; }
        }

        String primernombre;

        public String PrimerNombre
        {
            get { return primernombre; }
            set { primernombre = value; }
        }

        String segundonombre;

        public String SegundoNombre
        {
            get { return segundonombre; }
            set { segundonombre = value; }
        }

        String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        String foto;

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}
