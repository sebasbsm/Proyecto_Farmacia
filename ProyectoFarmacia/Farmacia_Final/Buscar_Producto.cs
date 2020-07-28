using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Producto para desarrollar la busqueda de datos.</summary>
    public class Buscar_Producto
    {

        private static string _nombre = "Panadol";



        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Buscar_Producto" /> class.</summary>
        /// <param name="nombre">Parametro del nombre del producto.</param>
        public Buscar_Producto(string nombre)
        {

            Nombre = nombre;

        }

        /// <summary>Obtiene el nombre del producto y luego lo retorna.</summary>
        /// <value>El nombre del producto.</value>
        /// <exception cref="ArgumentNullException">El campo del usuario no puede quedar vacío.</exception>
        public static string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del usuario no puede quedar vacío.");
                }

                {
                    _nombre = value.Trim();
                }
            }
        }


        /// <summary>Se buscara los datos con un procedimiento almacenado hecho la base de datos.
        /// Se hizo la conexion con la base de datos Farmacia</summary>
        /// <returns>DataTable.</returns>
        public DataTable BuscarDatos()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("BuscarStockProducto", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@nombre", Nombre);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Open();
            conexion.Close();
            return dt;
        }
    }
}
