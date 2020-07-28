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
    public partial class Eliminar_Cuentas : Form
    {
        public Eliminar_Cuentas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Elimnar_Cuentas_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>Obtiene el valor de lso datos a atraves de los text box.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonEliminar_cuenta_Click(object sender, EventArgs e)
        {


            // Form formulario = new LoginDeConfirmacion();
            // formulario.Show();

            /*Eliminar_Cuenta elim = new Eliminar_Cuenta(textUsuario.Text);
            elim.Eliminar();
            MessageBox.Show("Eliminacion exitosa");*/

            try
            {
                Eliminar_Cuenta elim = new Eliminar_Cuenta(textUsuario.Text);
                elim.Eliminar();
            }

            catch (ArgumentNullException error)
            {
                MessageBox.Show("Complete los datos requeridos." + "\n" + error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error." + "\n" + "Detalle: " + error.Message, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            //MessageBox.Show("Eliminacion completada.", "lex", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>Muestra los datos de las cuentas en un data gried.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            //Eliminar_Cuenta mostr = new Eliminar_Cuenta(textUsuario.Text);
            //dataGridView1.DataSource = mostr.MostrarCuentas();

            Mostrar_Cuentas mostr = new Mostrar_Cuentas();
            dataGridView1.DataSource = mostr.MostrarCuentas();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {


        }

        /// <summary>Handles the Load event of the Eliminar_Cuentas control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Eliminar_Cuentas_Load(object sender, EventArgs e)
        {
            Mostrar_Cuentas mostr = new Mostrar_Cuentas();
            dataGridView1.DataSource = mostr.MostrarCuentas();
        }
    }
}
