using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Mostrar_Vencido para desarrollar el proceso de mostrar stock de productos vencidos.</summary>
    public class Mostrar_Vencido
    {
        /// <summary>Realiza la conexion con la base de datos Farmacia
        /// Se muestra el stock de los productos vencidos con la ayuda de un procedimiento almacenado hehco en la base de datos .</summary>
        /// <returns>DataTable.</returns>
        public DataTable MostrarVen()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("mostrar_vencidos", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Open();
            conexion.Close();
            return dt;
        }
    }
}
