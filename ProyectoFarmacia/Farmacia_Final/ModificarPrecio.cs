using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Modificar Precio para desarollar la modificacion del precio con los datos registrados.</summary>
    public class ModificarPrecio
    {
        private int _precio;
        private string _nombre;

        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.ModificarPrecio" /> class.</summary>
        /// <param name="nom">Parametro del nombre del producto.</param>
        /// <param name="prec">Parametro del precio del precio.</param>
        public ModificarPrecio(string nom,int prec)
        {
            precio = prec;
            nombre = nom;
        }

        /// <summary>Obtiene el nombre del producto y luego lo retorna.</summary>
        /// <value>El nombre del producto.</value>
        /// <exception cref="ArgumentNullException">El campo del usuario no puede quedar vacío.</exception>
        public string nombre
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

        /// <summary>Obtiene el precio del producto y luego lo retorna.</summary>
        /// <value>El precio del producto.</value>
        public int precio
        {
            get
            {
                return _precio;
            }
            set
            {
               
               _precio = value;
                
            }
        }

        /// <summary>Se realiza la conexion de la base de datos Farmacia
        /// Se modifica el precio con ayuda de un procedimiento almacenado hecho en la base de datos.</summary>
        public void ModificarP()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("Modificar_precio", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
        }
    }
}
