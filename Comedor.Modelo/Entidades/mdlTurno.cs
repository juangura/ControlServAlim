using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comedor.Modelo
{
    public class mdlTurno
    {
        #region Campos_Turno
        private String idturno;

        public String IdTurno
        {
            get { return idturno; }
            set { idturno = value; }
        }

        private mdlDia dia;

        public mdlDia Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        //desayuno=1 almuerzo=2 cena=3
        private int desalmcen;

        public int DesAlmCen
        {
            get { return desalmcen; }
            set { desalmcen = value; }
        }

        private DateTime horainicio;

        public DateTime HoraInicio
        {
            get { return horainicio; }
            set { horainicio = value; }
        }

        private DateTime horafin;

        public DateTime HoraFin
        {
            get { return horafin; }
            set { horafin = value; }
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
