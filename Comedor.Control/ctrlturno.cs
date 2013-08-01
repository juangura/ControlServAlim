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
    public class ctrlturno
    {
        conexion conexion = new conexion();

        public List<mdlTurno> BuscarTurno(String idDia)
        {
            List<mdlTurno> resp = new List<mdlTurno>();

            conexion.open();
            string query = "select IdTurno, IdDia, HoraInicio, HoraFin, DesAlmCen from turno where IdDia='" + idDia + "' and estado<>0";

            // Create a SqlCommand object and pass the constructor the connection string and the query string.
            SqlCommand queryCommand = new SqlCommand(query, conexion.get());

            // Use the above SqlCommand object to create a SqlDataReader object.
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            // Create a DataTable object to hold all the data returned by the query.
            DataTable dataTable = new DataTable();

            // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
            dataTable.Load(queryCommandReader);

            foreach (DataRow item in dataTable.Rows)
            {
              
                mdlTurno turno = new mdlTurno();
                turno.IdTurno = item[0].ToString();
                turno.Dia = new mdlDia();
                turno.Dia.IdDia = item[1].ToString();
                turno.HoraInicio = DateTime.Parse(item[2].ToString());
                turno.HoraFin = DateTime.Parse(item[3].ToString());
                turno.DesAlmCen = int.Parse(item[4].ToString());
                resp.Add(turno);
            }
            conexion.close();
            return resp;
        }


        public List<mdlTurno> BuscarTurnoEvento(String idDia, String idturno)
        {
            List<mdlTurno> resp = new List<mdlTurno>();

            conexion.open();
            string query = "select IdTurno, HoraInicio, HoraFin from TURNO where DesAlmCen=(select DesAlmCen from TURNO where IdTurno='" + idturno + "') and IdDia='" + idDia + "' and CONVERT(time,HoraInicio)>CONVERT(time,SYSDATETIME()) and estado<>0";

            // Create a SqlCommand object and pass the constructor the connection string and the query string.
            SqlCommand queryCommand = new SqlCommand(query, conexion.get());

            // Use the above SqlCommand object to create a SqlDataReader object.
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            // Create a DataTable object to hold all the data returned by the query.
            DataTable dataTable = new DataTable();

            // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
            dataTable.Load(queryCommandReader);

            foreach (DataRow item in dataTable.Rows)
            {

                mdlTurno turno = new mdlTurno();
                turno.IdTurno = item[0].ToString();
                turno.HoraInicio = DateTime.Parse(item[1].ToString());
                turno.HoraFin = DateTime.Parse(item[2].ToString());
                resp.Add(turno);
            }
            conexion.close();
            return resp;
        }

    }
}
