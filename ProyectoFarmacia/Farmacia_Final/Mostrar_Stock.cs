using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Mostrar el Stock para poder desarrollar el proceso de mostrar el stock de los productos.</summary>
    public class Mostrar_Stock
    {
        /// <summary>Realizar la conexion con la base de datos Farmacia
        /// Mostrar el stock del producto con la ayuda de un procedimiento almacenado hehco en la base de datos.</summary>
        /// <returns>DataTable.</returns>
        public DataTable MostrarStock()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("MostrarStock", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Open();
            conexion.Close();
            return dt;
        }
    }
}
