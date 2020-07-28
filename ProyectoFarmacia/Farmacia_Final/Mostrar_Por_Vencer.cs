using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Mostrar productos por vencer para desarrollar el proceso de mostrar productos.</summary>
    public class Mostrar_Por_Vencer
    {
        /// <summary>Se realiza la conexion con la base de datos Farmacia
        /// Se muestra los productos por vencer con ayuda de un procedimiento almacenado en la base de datos.</summary>
        /// <returns>DataTable.</returns>
        public DataTable Mostrarporven()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("mostrar_por_vencer", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Open();
            conexion.Close();
            return dt;
        }
    }
}
