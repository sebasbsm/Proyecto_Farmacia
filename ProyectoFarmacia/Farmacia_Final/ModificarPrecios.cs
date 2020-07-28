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
    public partial class ModificarPrecios : Form
    {
        public ModificarPrecios()
        {
            InitializeComponent();
        }

        /// <summary>Muestra en un data gried view.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ModificarPrecios_Load(object sender, EventArgs e)
        {
            Mostrar_Stock mos = new Mostrar_Stock();
            dataGridView1.DataSource = mos.MostrarStock();
        }

        /// <summary>Captura los datos en los textboxs para poder modificar el precio.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarPrecio mod = new ModificarPrecio(textBox1.Text, Int32.Parse(textBox2.Text));
                mod.ModificarP();

                MessageBox.Show("Insercion de datos exitosa");

                Mostrar_Stock mos = new Mostrar_Stock();
                dataGridView1.DataSource = mos.MostrarStock();
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
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
