using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comedor.Modelo
{
    public class mdlConsumidor
    {
        private String idconsumidor;

        public String IdConsumidor
        {
            get { return idconsumidor; }
            set { idconsumidor = value; }
        }

        #region modelo persona...
        mdlPersona persona;

        public mdlPersona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        #endregion

        #region modelo grupo...
        mdlGrupo grupo;

        public mdlGrupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        #endregion

        #region modelo area...
        mdlArea area;

        public mdlArea Area
        {
            get { return area; }
            set { area = value; }
        }
        #endregion

        #region modelo reserva...
        mdlReserva reserva;

        public mdlReserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }
        #endregion

        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
