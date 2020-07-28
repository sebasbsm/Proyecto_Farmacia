using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase registrarServicios para desarrollar el proceso de registrar servicios en base a los datos ingresados.</summary>
    public class registrarServicios
    {
        private string _serID;
        private string _serNombreServicio;
        private DateTime _serFecha;


        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.registrarServicios" /> class.</summary>
        /// <param name="IDser">Parametro ID del servicio.</param>
        /// <param name="nombreSer">Parametro nombre del servicio.</param>
        /// <param name="serFechaIni">Parametro de fecah de inicio del servicio.</param>
        public registrarServicios(string IDser, string nombreSer, DateTime serFechaIni)
        {
            serID = IDser;
            serNombre = nombreSer;
            serFecha = serFechaIni;

        }
        /// <summary>Obtiene el ID del servicio y luego lo retorna.</summary>
        /// <value>El ID del servicio.</value>
        /// <exception cref="ArgumentNullException">El número de DNI no puede quedar vacío.</exception>
        /// <exception cref="ArgumentOutOfRangeException">El número de DNI tiene un formato inválido.</exception>
        public string serID
        {
            get
            {
                return _serID;
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
                    _serID = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el nombre del servicio y luego lo retorna.</summary>
        /// <value>El nombre del servicio.</value>
        /// <exception cref="ArgumentNullException">El campo del nombre no puede quedar vacío.</exception>
        public string serNombre
        {
            get
            {
                return _serNombreServicio;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del nombre no puede quedar vacío.");
                }

                else
                {
                    _serNombreServicio = value.Trim();
                }
            }
        }

        /// <summary>Obtiene la fecha de inicio del servicio y lo retorna.</summary>
        /// <value>La fecha de inicio del servicio.</value>
        public DateTime serFecha
        {
            get
            {
                return _serFecha;
            }
            set
            {
                
                _serFecha = value;
                
            }
        }


        /// <summary>Se realiza la conexion con la base de datos Farmacia
        /// Se registra los servicios con la ayuda de un procedimiento almacenado ehcho en la base de datos.</summary>
        public void Registrar_Servicios()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("insertarServicios", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@serID", serID);
            comando.Parameters.AddWithValue("@serNombre", serNombre);
            comando.Parameters.AddWithValue("@serFechaInic", serFecha);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }

    }
}
