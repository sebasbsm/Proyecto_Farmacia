using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Farmacia_Final
{
    /// <summary>Clase Farmaceutico para desarrollar el ingreso de datos del farmaceutico en la base de datos.</summary>
    public class Farmaceutico
    {
        private static string _DNI = "7894561";
        private static string _Nombres = "Alex";
        private static string _ApellidoPaterno = "Zapata";
        private static string _ApellidoMaterno = "Maravi";
        private static string _Direccion = "AvReal";
        private static string _Profesion = "Quimico Farmaceutico";


        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Farmaceutico" /> class.</summary>
        /// <param name="DNI1">Parametro del DNI del farmaceutico.</param>
        /// <param name="Nom">Parametro del nombre del farmaceutico.</param>
        /// <param name="ApePat">Parametro del apellido paterno del farmaceutico.</param>
        /// <param name="ApeMat">Parametro del apellido materno del farmaceutico.</param>
        /// <param name="Direc">Parametro de  la direccion del farmaceutico.</param>
        /// <param name="Prof">Parametro de la profesion del farmaceutico.</param>
        public Farmaceutico(string DNI1, string Nom, string ApePat, string
             ApeMat, string Direc, string Prof)
        {
            DNI = DNI1;
            Nombres = Nom;
            ApellidoPaterno = ApePat;
            ApellidoMaterno = ApeMat;
            Direccion = Direc;
            Profesion = Prof;

        }
        /// <summary>Obtiene el DNI del farmaceutico y luego lo retorna.</summary>
        /// <value>El DNI del Farmaceutico.</value>
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

        /// <summary>Obtiene el nombre del farmaceutico y luego lo retorna.</summary>
        /// <value>Los nombres del Farmaceutico.</value>
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

        /// <summary>Obtiene el apellido paterno del farmaceutico y luego lo retorna.</summary>
        /// <value>El apellido paterno del farmaceutico.</value>
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

        /// <summary>Obtiene el apellido materno del farmaceutico y luego lo retorna.</summary>
        /// <value>El apellido materno del farmaceutico.</value>
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

        /// <summary>Obtiene la direccion del farmaceutico y luego lo retorna.</summary>
        /// <value>La direccion del farmaceutico.</value>
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

        /// <summary>Obtiene la profesion del farmaceutico y lo retorna.</summary>
        /// <value>La profesion del farmaceutico.</value>
        /// <exception cref="ArgumentNullException">El campo de la profesion no puede quedar vacío.</exception>
        public static string Profesion
        {
            get
            {
                return _Profesion;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la profesion no puede quedar vacío.");
                }

                else
                {
                    _Profesion = value.Trim();
                }
            }
        }

        /// <summary>Se realiza la conexion con la base de datos Farmacia
        /// Se registran los datos gracias a un procedimiento almacenado hecho en la base de datos
        /// .</summary>
        public void Registrar()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("usp_Insertar_Farmaceuticos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", DNI);
            comando.Parameters.AddWithValue("@Nombres", Nombres);
            comando.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
            comando.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Profesion", Profesion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}

