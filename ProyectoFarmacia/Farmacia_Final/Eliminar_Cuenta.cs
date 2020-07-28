using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Eliminar la cuenta de un farmaceutico.</summary>
    public class Eliminar_Cuenta
    {
        private static string _usuario = "Andrei";

        

        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Eliminar_Cuenta" /> class.</summary>
        /// <param name="usu">Parametro del usuario del farmaceutico.</param>
        public Eliminar_Cuenta(string usu)
        {

            Usuario = usu;

        }

        /// <summary>Obtiene el usuario de la cuenta del farmaceutico y lo retorna.</summary>
        /// <value>EL usuario de la cuenta del farmaceutico.</value>
        /// <exception cref="ArgumentNullException">El campo del usuario no puede quedar vacío.</exception>
        public static string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del usuario no puede quedar vacío.");
                }

                {
                    _usuario = value.Trim();
                }
            }
        }


        /// <summary>
        /// Se hizo la conexion con la base de datos Farmacia
        /// Con la ayuda de un procedimiento almacenado se eliminara una cuenta del farmaceutico.</summary>
        public void Eliminar()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("Eliminar_usuario", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", Usuario);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
        }
    }
}
