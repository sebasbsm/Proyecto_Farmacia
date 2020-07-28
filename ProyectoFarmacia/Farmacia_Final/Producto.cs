using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia_Final
{
    /// <summary>Clase Producto para poder desarrollar el proceso de registrar productos en base a datos ingresados.</summary>
    public class Producto
    {
        private static string _ID = "0012";
        private static string _Nombre = "Panadol";
        private static string _Proveedor = "Proveedor";
        private static int _Stock = 45;
        private static int _Pre = 45;
        private static DateTime _Fecha ;


        /// <summary>Initializes a new instance of the <see cref="T:Farmacia_Final.Producto" /> class.</summary>
        /// <param name="ID1">Parametro del ID del producto.</param>
        /// <param name="Nom">Parametro del nombre del producto.</param>
        /// <param name="Prov">Parametro del proveedor del producto.</param>
        /// <param name="stock">Pametro del stock del producto.</param>
        /// <param name="prec">Parametro del precio del producto.</param>
        /// <param name="Fech">Parametro de la fecha de vencimiento del producto.</param>
        public Producto(string ID1, string Nom, string Prov, int
             stock,int prec , DateTime Fech)
        {
            ID = ID1;
            Nombre = Nom;
            Proveedor = Prov;
            Stock = stock;
            Precio = prec;
            Fecha = Fech;

        }
        /// <summary>Obtiene el ID del producto y luego lo retorna.</summary>
        /// <value>El ID del producto.</value>
        /// <exception cref="ArgumentNullException">El número de DNI no puede quedar vacío.</exception>
        /// <exception cref="ArgumentOutOfRangeException">El número de DNI tiene un formato inválido.</exception>
        public static string ID
        {
            get
            {
                return _ID;
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
                    _ID = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el nombre del producto y luego lo retorna.</summary>
        /// <value>El nombre del producto.</value>
        /// <exception cref="ArgumentNullException">El campo del nombre no puede quedar vacío.</exception>
        public static string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del nombre no puede quedar vacío.");
                }

                else
                {
                    _Nombre = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el proveedor del producto y luego lo retorna.</summary>
        /// <value>El proveedor del producto.</value>
        /// <exception cref="ArgumentNullException">El campo del apellido paterno no puede quedar vacío.</exception>
        public static string Proveedor
        {
            get
            {
                return _Proveedor;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentNullException("El campo del apellido paterno no puede quedar vacío.");
                }

                else
                {
                    _Proveedor = value.Trim();
                }
            }
        }

        /// <summary>Obtiene el stock del producto y luego lo retorna.</summary>
        /// <value>El stock del producto.</value>
        public static int Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                _Stock = value;
            }
        }

        /// <summary>Obtiene el precio del producto y luego lo retorna.</summary>
        /// <value>El precio del producto.</value>
        public static int Precio
        {
            get
            {
                return _Pre;
            }
            set
            {
                _Pre = value;
            }
        }

        /// <summary>Obtiene la fecha de vencimiento del producto y luego lo retorna.</summary>
        /// <value>La fecha de vencimiento del producto.</value>
        public static DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                
                _Fecha = value;
                
            }
        }

        /// <summary>Se realiza la conexion con la base de datos Farmacia
        /// Se registra un producto garcias a un procedimiento almacenado hecho en la base de datos.</summary>
        public void Registrar_Producto()
        {
            SqlConnection conexion = new SqlConnection("server=.;database = Farmacia; integrated security=true");
            SqlCommand comando = new SqlCommand("InsertarProductos2", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Proveedor", Proveedor);
            comando.Parameters.AddWithValue("@Stock", Stock);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Fechanacimiento", Fecha);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();

        }
    }
}
