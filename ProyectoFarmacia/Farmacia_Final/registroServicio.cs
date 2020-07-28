using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Final
{
    public partial class registroServicio : Form
    {
        public registroServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>Captura los datos en el text box para poder registrar los servicios.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                registrarServicios nuevoServicio = new registrarServicios(textBox1.Text, textBox2.Text,dateTimePicker1.Value);
                nuevoServicio.Registrar_Servicios();
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
                textBox1.SelectAll();
                textBox2.SelectAll();
                //textBox6.SelectAll();
                textBox1.Focus();
                textBox2.Focus();
                
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
                textBox1.SelectAll();
                textBox2.SelectAll();
                textBox1.Focus();
                textBox2.Focus();

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
                textBox1.SelectAll();
                textBox2.SelectAll();
                //textBox6.SelectAll();
                textBox1.Focus();
                textBox2.Focus();
                //textBox6.Focus();
                return;
            }

            MessageBox.Show("Inserción completada.", "lex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            //textBox6.Clear();
            textBox1.Focus();
            textBox2.Focus();
            //textBox6.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
