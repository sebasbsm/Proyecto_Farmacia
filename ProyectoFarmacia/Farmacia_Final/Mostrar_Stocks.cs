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
    public partial class Mostrar_Stocks : Form
    {
        public Mostrar_Stocks()
        {
            InitializeComponent();
        }

        private void buttonSalir_MS_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>Captura los datos para hacer la actualizacion del stock.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonActualizar_MS_Click(object sender, EventArgs e)
        {
            Mostrar_Stock mos = new Mostrar_Stock();
            dataGridView1.DataSource = mos.MostrarStock();
        }

        /// <summary>Busca el dato que se ha registrado en la textbox.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonBuscar_MS_Click(object sender, EventArgs e)
        {

            Buscar_Producto bus = new Buscar_Producto(textBoxNombre_Producto.Text);
            dataGridView1.DataSource = bus.BuscarDatos();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_Stocks_Load(object sender, EventArgs e)
        {
            Mostrar_Stock mos = new Mostrar_Stock();
            dataGridView1.DataSource = mos.MostrarStock();
        }
    }
}
