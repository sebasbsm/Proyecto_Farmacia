using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Servicios_Realizado para desarrollar el proceso de registrar los servicios realizados con los datos ingresados.</summary>
    public class Servicios_Realizado
    {
        private static string _DNI = "45781245";
        private static string _Nombres = "Paul";
        private static string _Apellidos = "Serva";
        private static string _NombreServicio = "Inyeccion";

        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Servicios_Realizado" /> class.</summary>
        /// <param name="DNI1">Parametro del DNI del CLiente.</param>
        /// <param name="Nom">Parametro del nombre del cliente.</param>
        /// <param name="Ape">Parametro del apellido del cliente.</param>
        /// <param name="NomSer">Parametro del nombre del servicio.</param>
        public Servicios_Realizado(string DNI1, string Nom, string Ape, string
             NomSer)
        {
            DNI = DNI1;
            Nombres = Nom;
            Apellidos = Ape;
            NombreServicios = NomSer;

        }
        /// <summary>Obtiene el DNI del cliente y luego lo retorna.</summary>
        /// <value>El DNI del cliente.</value>
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

        /// <summary>Obtiene el nombre del cliente y luego lo retorna.</summary>
        /// <value>El nombre del cliente.</value>
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

        /// <summary>GObtiene los apellidos del cliente y luego lo retorna.</summary>
        /// <value>Los apellidos del cliente.</value>
        /// <exception cref="ArgumentNullException">El campo del apellido paterno no puede quedar vacío.</exception>
        public static string Apellidos
        {
            get
            {
                return _Apellidos;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido paterno no puede quedar vacío.");
                }

                else
                {
                    _Apellidos = value.Trim();
                }
            }
        }



        /// <summary>Obtiene el nombre del serivicio realizado y luego lo retorna.</summary>
        /// <value>El nombre del servicio realizado.</value>
        /// <exception cref="ArgumentNullException">El campo de la profesion no puede quedar vacío.</exception>
        public static string NombreServicios
        {
            get
            {
                return _NombreServicio;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo de la profesion no puede quedar vacío.");
                }

                else
                {
                    _NombreServicio = value.Trim();
                }
            }
        }

        /// <summary>Se registra la conexion con la base de datos Farmacia
        /// Se registra los servicios realizados con la ayuda de un procedimeinto almacenado hecho en la base de datos.</summary>
        public void RegistrarServicioRealizado()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("InsertarServicioRealizado", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", DNI);
            comando.Parameters.AddWithValue("@Nombres", Nombres);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            comando.Parameters.AddWithValue("@NomServicios", NombreServicios);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}
