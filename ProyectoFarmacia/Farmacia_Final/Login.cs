using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Farmacia_Final
{
    /// <summary>Clase Login para desarrollar el ingreso del usuario y contraseña del farmaceutico.</summary>
    public class Login
    {
        private static string _usuario = "Andrei05";
        private static string _contrase = "andre1234";


        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Login" /> class.</summary>
        /// <param name="usu">Parametro del usuario del farmaceutico.</param>
        /// <param name="contra">Parametro de la contraseña del farmaceutico.</param>
        public Login(string usu, string contra)
        {

            Usuario = usu;
            Contrase = contra;

        }

        /// <summary>Obtiene el usuario del farmaceutico y luego lo retorna.</summary>
        /// <value>El usuario del farmaceutico.</value>
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

        /// <summary>Obtiene la contraseña del farmaceutico y luego lo retorna.</summary>
        /// <value>La constraseña del farmaceutico.</value>
        /// <exception cref="ArgumentNullException">El campo de la contraseña no puede quedar vacío.</exception>
        public static string Contrase
        {
            get
            {
                return _contrase;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la contraseña no puede quedar vacío.");
                }

                {
                    _contrase = value.Trim();
                }
            }
        }


        /// <summary>Se realiza la conexion con la base de datos Farmacia y se realiza la validacion de la cuenta.</summary>
        /// <param name="argUsuario">Parametro argumento usuario del Farmaceutico.</param>
        /// <param name="argContrasenia">Parametro argumento contraseña del Farmaceutico.</param>
        /// <returns>Login.</returns>
        public static Login Validar(string argUsuario, string argContrasenia)
        {
            Login x = null;

            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("ValidacionUsuario02", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", argUsuario);
            comando.Parameters.AddWithValue("@contra", argContrasenia);
            conexion.Open();
            SqlDataReader contendor = comando.ExecuteReader();

            while (contendor.Read() == true)
            {
                x = new Login(contendor["usuario"].ToString(), "contra");
            }
            conexion.Close();
            conexion.Dispose();
            return x;
        }

    }
}
