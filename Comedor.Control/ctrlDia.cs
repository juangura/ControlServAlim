using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comedor.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace Comedor.Control
{
    public class ctrlDia
    {
        conexion conexion = new conexion();

        public List<mdlDia> Listar_Dia()
        {
            List<mdlDia> resp = new List<mdlDia>();

            conexion.open();
            string query = "select idDia, nombre, estado from DIA";

            SqlCommand queryCommand = new SqlCommand(query, conexion.get());

            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(queryCommandReader);

            foreach (DataRow item in dataTable.Rows)
            {
                mdlDia dia = new mdlDia();
                dia.IdDia = item[0].ToString();
                dia.Nombre = item[1].ToString();
                dia.Estado =int.Parse(item[2].ToString());
                resp.Add(dia);
            }
            conexion.close();

            return resp;
        }
    }
}
