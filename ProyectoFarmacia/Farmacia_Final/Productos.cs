using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Farmacia_Final
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        /// <summary>Captura los datos en los textboxs para poder registrar el producto.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Registrar_Producto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoProducto = new Producto(textBoxIDP.Text, textBoxNombreP.Text, textBoxProveedorP.Text,
                    Int32.Parse(textStockP.Text), Int32.Parse(textBoxPrecio.Text), dateTimePickerP.Value);
                nuevoProducto.Registrar_Producto();
            }

            catch (ArgumentNullException error)
            {
                MessageBox.Show("Complete los datos requeridos." + "\n" + error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBoxIDP.SelectAll();
                textBoxNombreP.SelectAll();
                textBoxProveedorP.SelectAll();
                textStockP.SelectAll();
                //textBox6.SelectAll();
                textBoxIDP.Focus();
                textBoxNombreP.Focus();
                textBoxProveedorP.Focus();
                textStockP.Focus();
                //textBox6.Focus();
                return;
            }

            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBoxIDP.SelectAll();
                textBoxNombreP.SelectAll();
                textBoxProveedorP.SelectAll();
                textStockP.SelectAll();
                //textBox6.SelectAll();
                textBoxIDP.Focus();
                textBoxNombreP.Focus();
                textBoxProveedorP.Focus();
                textStockP.Focus();
                //textBox6.Focus();
                return;
            }

            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error." + "\n" + "Detalle: " + error.Message, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBoxIDP.SelectAll();
                textBoxNombreP.SelectAll();
                textBoxProveedorP.SelectAll();
                textStockP.SelectAll();
                //textBox6.SelectAll();
                textBoxIDP.Focus();
                textBoxNombreP.Focus();
                textBoxProveedorP.Focus();
                textStockP.Focus();
                //textBox6.Focus();
                return;
            }

            MessageBox.Show("Inserción completada.", "lex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*textBoxDNIC.Clear();
            textBoxNombresC.Clear();
            textApePatC.Clear();
            textBoxApeMatC.Clear();
            textBoxDireccionC.Clear();*/
            //textBox6.Clear();
            textBoxIDP.Focus();
            textBoxNombreP.Focus();
            textBoxProveedorP.Focus();
            textStockP.Focus();
            //textBox6.Focus();
        }

        private void Salir_Producto_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
