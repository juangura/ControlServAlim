using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comedor.Modelo
{
    public class mdlDia
    {
        #region Campos_dia
        private String iddia;

        public String IdDia
        {
            get { return iddia; }
            set { iddia = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion
    }
}
