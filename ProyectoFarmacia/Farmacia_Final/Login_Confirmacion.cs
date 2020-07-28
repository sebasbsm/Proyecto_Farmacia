using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Login_Confirmacion para desarrollar la confirmacion de usuario para eliminar cuentas.</summary>
    public class Login_Confirmacion
    {
        private static string _usuario = "Alex05";
        private static string _contrase = "alex1234";


        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Login_Confirmacion" /> class.</summary>
        /// <param name="usu">Parametro usuario del farmaceutico.</param>
        /// <param name="contra">Parametro contraseña del farmaceutico.</param>
        public Login_Confirmacion(string usu, string contra)
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

        /// <summary>Obtiene la contrasela del farmaceutico y luego lo retorna.</summary>
        /// <value>La contraseña del farmaceutico.</value>
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
        /// <param name="argUsuario">Parametro argumento del usuario del farmaceutico.</param>
        /// <param name="argContrasenia">Parametro argumento de la contraseña del farmaceutico.</param>
        /// <returns>Login_Confirmacion.</returns>
        public static Login_Confirmacion Validar(string argUsuario, string argContrasenia)
        {
            Login_Confirmacion x = null;

            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("ValidacionUsuario02", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", argUsuario);
            comando.Parameters.AddWithValue("@contra", argContrasenia);
            conexion.Open();
            SqlDataReader contendor = comando.ExecuteReader();

            while (contendor.Read() == true)
            {
                x = new Login_Confirmacion(contendor["usuario"].ToString(), "contra");
            }
            conexion.Close();
            conexion.Dispose();
            return x;
        }
    }
}
