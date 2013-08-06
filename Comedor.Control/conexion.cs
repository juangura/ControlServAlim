using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comedor.Control
{
   public class conexion
    {
       SqlConnection conex;

       public void open()
       {
           try
           {
               string cad = "Data Source=CONTROLALIMENTA\\SQLCOMEDOR;Initial Catalog=SERV-ALIM;Persist Security Info=True;User ID=sa; Password=comedor54321";
               conex = new SqlConnection(cad);

               conex.Open();
           }
           catch (Exception e)
           {
               MessageBox.Show("Error al intentar conectar con Base de Datos");
               Application.Exit();
           }
       }

       public SqlConnection get()
       {
           return conex;
       }

       public void close()
       {
           conex.Close();
       }
    }
}
