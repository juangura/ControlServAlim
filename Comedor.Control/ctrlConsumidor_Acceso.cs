using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comedor.Modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Comedor.Control
{
    public class ctrlConsumidor_Acceso
    {
        conexion conexion = new conexion();

        public List<mdlConsumidor> Consumidor_Acceso(String codigo, String IdTurno, String IdDia)
        {
            List<mdlConsumidor> ListCon = new List<mdlConsumidor>();
            conexion.open();
            SqlDataAdapter cmdOper1 = new SqlDataAdapter("Consumidor_Matricula_Grupo", conexion.get());
            cmdOper1.SelectCommand.CommandType = CommandType.StoredProcedure;

            cmdOper1.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);
            cmdOper1.SelectCommand.Parameters.AddWithValue("@IdTurno", IdTurno);
            cmdOper1.SelectCommand.Parameters.AddWithValue("@IdDia", IdDia);

            DataTable dt1 = new DataTable();
            cmdOper1.Fill(dt1);
            DataRow row1 = dt1.Rows[0];

            if (int.Parse(row1["estado"].ToString()) == 0)
            {
                //0: consumirdor no esta matriculado o no existe
                return null;
            }
            if(int.Parse(row1["estado"].ToString()) == 2)
            {
                // 2: Consumidor queriendo entrar por segunda ves
                ListCon=Consumidor(row1["IdConsumidor"].ToString(), 2,null);
                return ListCon;
            }

            String idconsumidor=row1["IdConsumidor"].ToString();

//2do procedimiento...

            SqlDataAdapter cmdOper2 = new SqlDataAdapter("Consumidor_Turno_Reserva", conexion.get());
            cmdOper2.SelectCommand.CommandType = CommandType.StoredProcedure;

            cmdOper2.SelectCommand.Parameters.AddWithValue("@IdConsumidor",idconsumidor);
            cmdOper2.SelectCommand.Parameters.AddWithValue("@IdTurno", IdTurno);

            DataTable dt2 = new DataTable();
            cmdOper2.Fill(dt2);
            DataRow row2 = dt2.Rows[0];

            if (int.Parse(row2["estado"].ToString()) == 3)
            {
                //3: cancelo su reserva pero kiere entrar en hora de reserva
                ListCon = Consumidor(idconsumidor, 3, null);
                return ListCon;
            }
            if (int.Parse(row2["estado"].ToString()) == 4)
            {
                //4: entro con incidencia
                ListCon = Consumidor(idconsumidor, 4,row2["IdReserva"].ToString());
                return ListCon;
            }
            if (int.Parse(row2["estado"].ToString()) == 5)
            {
                //5: el grupo a la k asiste no tiene acceso a ese turno
                ListCon = Consumidor(idconsumidor, 5, null);
                return ListCon;
            }

            ListCon = Consumidor(idconsumidor, 1, null);
            conexion.close();

            return ListCon;
        }

        public List<mdlConsumidor> Consumidor(String idconsumidor, int estado, String idreserva) { 
        
            List<mdlConsumidor> reg= new List<mdlConsumidor>();

            string query = "select a.IdPersona, b.Nombres, b.Paterno, b.Materno, b.foto, a.IdGrupo, c.Nombre, a.IdArea, d.Nombre from CONSUMIDOR a, Persona b, GRUPO c, Area d where a.IdPersona=b.IdPersona and a.IdGrupo=c.IdGrupo and a.IdArea=d.IdArea and a.IdConsumidor='" + idconsumidor + "'";
            
            SqlCommand queryCommand = new SqlCommand(query, conexion.get());
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);

            foreach (DataRow item in dataTable.Rows)
            {
                mdlConsumidor ca = new mdlConsumidor();
                ca.IdConsumidor = idconsumidor;
                ca.Persona = new mdlPersona();
                ca.Persona.IdPersona = item[0].ToString();
                ca.Persona.PrimerNombre = item[1].ToString();
                ca.Persona.SegundoNombre = item[2].ToString();
                ca.Persona.Apellidos = item[3].ToString();
                ca.Grupo = new mdlGrupo();
                ca.Persona.Foto = item[4].ToString();
                ca.Grupo.IdGrupo = item[5].ToString();
                ca.Grupo.Nombre = item[6].ToString();
                ca.Area = new mdlArea();
                ca.Area.IdArea = item[7].ToString();
                ca.Area.Nombre = item[8].ToString();
                ca.Reserva = new mdlReserva();
                ca.Reserva.IdReserva = idreserva;
                ca.Estado = estado;

                reg.Add(ca);
            }
           

            return reg;
        }

        public void cancelar(String idconsumidor, String idturno , String idreserva) {
            conexion.open();
           string query1 = "delete from RegistroEntrada where IdConsumidor='" + idconsumidor + "' and IdTurno='" + idturno + "'and  Convert(date,fechaHora)=Convert(date,SYSDATETIME())";

           SqlCommand queryCommand1 = new SqlCommand(query1, conexion.get());
           queryCommand1.ExecuteNonQuery();
           if (idreserva == null || idreserva=="") {
               conexion.close();
               return;
           }
           string query2 = "UPDATE RESERVA set estado=1 where IdReserva='"+idreserva+"'";

           SqlCommand queryCommand2 = new SqlCommand(query2, conexion.get());
           queryCommand2.ExecuteNonQuery();

           string query3 = "update Excepcion set estado=0 where IdReserva='"+idreserva+"' and CONVERT(date, fecha)= CONVERT(date,SYSDATETIME())";

           SqlCommand queryCommand3 = new SqlCommand(query3, conexion.get());
           queryCommand2.ExecuteNonQuery();

           conexion.close();
        }

        public int CantidadConsumidores(String fecha, String idturno)
        {
            int cant=0;
            conexion.open();
            string query = "select (SELECT count(*) FROM CONSUMIDOR_PERIODO a, PERIODO b where a.IdPeriodo=b.IdPeriodo and CONVERT(date,b.fechaInicio)<=CONVERT(date,'" + fecha + "') and convert(date,b.fechaFin)>=CONVERT(date,'" + fecha + "') and a.estado<>0 and IdConsumidor=any(SELECT c.IdConsumidor FROM  CONSUMIDOR c , GRUPO d, Grupo_Turno e where   c.IdGrupo=d.IdGrupo and d.IdGrupo=e.IdGrupo and IdTurno='" + idturno + "' and c.estado<>0 and d.estado<>0 and e.estado<>0))-(select count(*) from RESERVA where IdTurno='" + idturno + "' and tipo=2 and CONVERT(date,fecha)=CONVERT(date,'" + fecha + "') and estado<>0)-(select COUNT(*) from RESERVA where IdTurno='" + idturno + "' and tipo=1 and estado<>0 )+(select COUNT(*) from Excepcion  where IdReserva=any(select IdReserva from RESERVA where IdTurno='" + idturno + "' and tipo=1 and estado<>0 )and estado<>0 and CONVERT(date,fecha)=CONVERT(date,'" + fecha + "'))+(select count(*) from RESERVA where IdTurnoRemplazo='" + idturno + "' and tipo=2 and CONVERT(date,fecha)=CONVERT(date,'" + fecha + "') and estado<>0)+(select COUNT(*) from RESERVA where IdTurnoRemplazo='" + idturno + "' and tipo=1 and estado<>0 )-(select COUNT(*) from Excepcion  where IdReserva=any(select IdReserva from RESERVA where IdTurnoRemplazo='" + idturno + "' and tipo=1 and estado<>0 )and estado<>0 and CONVERT(date,fecha)=CONVERT(date,'" + fecha + "'))";
            
            SqlCommand queryCommand = new SqlCommand(query, conexion.get());
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);
            DataRow item=dataTable.Rows[0];
            
            cant=int.Parse(item[0].ToString());

            return cant; 
        }

        public int CantidadConsumidoresReserva(String fecha, String idturno)
        {
            int cant = 0;
            conexion.open();
            string query = "select (select count(*) from RESERVA where IdTurnoRemplazo=any(select IdTurnoRemplazo from RESERVA where IdTurno='"+idturno+"') and tipo=2 and CONVERT(date,fecha)=CONVERT(date,'"+fecha+"') and estado<>0 and tipoServicio<>2)+(select COUNT(*) from RESERVA where IdTurnoRemplazo=any(select IdTurnoRemplazo from RESERVA where IdTurno='"+idturno+"') and tipo=1 and estado<>0 and tipoServicio<>2)-(select COUNT(*) from Excepcion  where IdReserva=any(select IdReserva from RESERVA where IdTurnoRemplazo=any(select IdTurnoRemplazo from RESERVA where IdTurno='"+idturno+"') and tipo=1 and estado<>0)and estado<>0 and CONVERT(date,fecha)=CONVERT(date,'"+fecha+"'))";

            SqlCommand queryCommand = new SqlCommand(query, conexion.get());
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);
            DataRow item = dataTable.Rows[0];

            cant = int.Parse(item[0].ToString());

            return cant;
        }

        public int CantidadRegistroEntrada(String idturno, String fecha)
        {
            int cant = 0;
            conexion.open();
            string query = "select count(*) from RegistroEntrada where IdTurno='"+idturno+"' and CONVERT(date,fechaHora)=convert(date,'"+fecha+"') and estado<>0";

            SqlCommand queryCommand = new SqlCommand(query, conexion.get());
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);
            DataRow item = dataTable.Rows[0];

            cant = int.Parse(item[0].ToString());

            return cant;
        }

        public mdlConsumidor Consumidor_reg(String idconsumidor, int estado, String idreserva)
        {

            mdlConsumidor reg = new mdlConsumidor();

            string query = "select a.IdPersona, b.Nombres, b.Paterno, b.Materno, b.foto, a.IdGrupo, c.Nombre, a.IdArea, d.Nombre from CONSUMIDOR a, Persona b, GRUPO c, Area d where a.IdPersona=b.IdPersona and a.IdGrupo=c.IdGrupo and a.IdArea=d.IdArea and a.IdConsumidor='" + idconsumidor + "'";

            SqlCommand queryCommand = new SqlCommand(query, conexion.get());
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);

            foreach (DataRow item in dataTable.Rows)
            {
                mdlConsumidor ca = new mdlConsumidor();
                ca.IdConsumidor = idconsumidor;
                ca.Persona = new mdlPersona();
                ca.Persona.IdPersona = item[0].ToString();
                ca.Persona.PrimerNombre = item[1].ToString();
                ca.Persona.SegundoNombre = item[2].ToString();
                ca.Persona.Apellidos = item[3].ToString();
                ca.Grupo = new mdlGrupo();
                ca.Persona.Foto = item[4].ToString();
                ca.Grupo.IdGrupo = item[5].ToString();
                ca.Grupo.Nombre = item[6].ToString();
                ca.Area = new mdlArea();
                ca.Area.IdArea = item[7].ToString();
                ca.Area.Nombre = item[8].ToString();
                ca.Reserva = new mdlReserva();
                ca.Reserva.IdReserva = idreserva;
                ca.Estado = estado;

                reg = ca;
            }
            return reg;
        }

        public List<mdlConsumidor> RegistroEntrada(String idturno, String fecha)
        {
            
            List<mdlConsumidor> reg = new List<mdlConsumidor>();
            conexion.open();
            string query = "select IdConsumidor from RegistroEntrada where  IdTurno='"+idturno+"' and CONVERT(date,fechaHora)=convert(date,'"+fecha+"') and estado<>0 order by fechaHora desc";

            SqlCommand queryCommand = new SqlCommand(query, conexion.get());
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);
            int x=0;
            foreach (DataRow item in dataTable.Rows)
            {
                if (x >= 4)
                {
                    return reg;
                }
                reg.Add(Consumidor_reg(item[0].ToString(), 1, null));
                x++;
                
            }
            
            return reg;
        }

    }
}
