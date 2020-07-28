using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Cliente para desarrollar el ingreso de datos a la base de datos.</summary>
    public class Cliente
    {

        private static string _DNI = "123456";
        private static string _Nombres = "Mario";
        private static string _ApellidoPaterno = "Luna";
        private static string _ApellidoMaterno = "Orellana";
        private static string _Direccion = "AvSanCarlo";
        private static string _Fecha = "12-10-2020";



        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Cliente" /> class.</summary>
        /// <param name="DNI1">Parametro del DNI del cliente.</param>
        /// <param name="Nom">Parametro del nombre del cliente.</param>
        /// <param name="ApePat">Parametro del apellido paterno del cliente.</param>
        /// <param name="ApeMat">Parametro del apellido materno del cliente.</param>
        /// <param name="Direc">Parametro de la direccion del cliente.</param>
        /// <param name="Fech">Parametro de la fecha de nacimiento del cliente.</param>
        public Cliente(string DNI1, string Nom, string ApePat, string
             ApeMat, string Direc, string Fech)
        {
            DNI = DNI1;
            Nombres = Nom;
            ApellidoPaterno = ApePat;
            ApellidoMaterno = ApeMat;
            Direccion = Direc;
            Fecha = Fech;
        }
        /// <summary>Obtiene el DNI del cliente y lo retorna.</summary>
        /// <value>El dni dni del cliente.</value>
        /// <exception cref="ArgumentNullException">El número de DNI no puede quedar vacío.</exception>
        /// <exception cref="ArgumentOutOfRangeException">El número de DNI tiene un formato inválido.</exception>
        public static string DNI
        {
            get
            {
                return _DNI;
            }
            set
            {

                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El número de DNI no puede quedar vacío.");
                }
                else if (value.Trim().Length > 8)
                {
                    throw new ArgumentOutOfRangeException("El número de DNI tiene un formato inválido.");
                }
                else
                {
                    _DNI = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el nombre de la persona y lo obtiene.</summary>
        /// <value>Los nombres del cliente.</value>
        /// <exception cref="ArgumentNullException">El campo del nombre no puede quedar vacío.</exception>
        public static string Nombres
        {
            get
            {
                return _Nombres;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del nombre no puede quedar vacío.");
                }

                else
                {
                    _Nombres = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el apellido paterno del cliente y lo devuelve.</summary>
        /// <value>El apellido paterno del cliente.</value>
        /// <exception cref="ArgumentNullException">El campo del apellido paterno no puede quedar vacío.</exception>
        public static string ApellidoPaterno
        {
            get
            {
                return _ApellidoPaterno;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido paterno no puede quedar vacío.");
                }

                else
                {
                    _ApellidoPaterno = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el apellido paterno del cliente y lo devuelve.</summary>
        /// <value>El apellido materno del cliente.</value>
        /// <exception cref="ArgumentNullException">El campo del apellido materno no puede quedar vacío.</exception>
        public static string ApellidoMaterno
        {
            get
            {
                return _ApellidoMaterno;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido materno no puede quedar vacío.");
                }

                else
                {
                    _ApellidoMaterno = value.Trim();
                }
            }
        }

        /// <summary>Obtiene la direccion del cliente y lo retorna.</summary>
        /// <value>La direccion del cliente.</value>
        /// <exception cref="ArgumentNullException">El campo de la direccion no puede quedar vacío.</exception>
        public static string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la direccion no puede quedar vacío.");
                }

                else
                {
                    _Direccion = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el valor de la fecha de nacimiento del cliente y lo devuelve.</summary>
        /// <value>La fecha de nacimiento del cliente.</value>
        /// <exception cref="ArgumentNullException">El campo de la profesion no puede quedar vacío.</exception>
        public static string Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la profesion no puede quedar vacío.");
                }

                else
                {
                    _Fecha = value.Trim();
                }
            }
        }

        /// <summary>
        /// Se realizo la conexion cona la base de datos Farmacia
        /// Registrar clientes en la base de datos con la ayuda de un procedimiento almacenado
        /// el cual nos ayudaraa insertar los datos del cliente en la base de datos
        /// .</summary>
        public void Registrar_Clientes()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("InsertarClientes3", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", DNI);
            comando.Parameters.AddWithValue("@Nombres", Nombres);
            comando.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
            comando.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@FechaNcimiento", Fecha);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}
