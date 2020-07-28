using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Mostrar Cuentas para desarrollar el proceso de mostrar la cuenta del farmaceutico.</summary>
    public class Mostrar_Cuentas
    {

        /// <summary>Se realiza la conexion con la base de datos Farmacia
        /// Se mostrara los datos gracias a un procedimiento almacenado hecho en la base de datos
        /// .</summary>
        /// <returns>DataTable.</returns>
        public DataTable MostrarCuentas()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("Mostrar_Cuentas", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Open();
            conexion.Close();
            return dt;
        }
    }
}
