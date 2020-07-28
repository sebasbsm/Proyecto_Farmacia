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
    public partial class Mostrar_Vencidos : Form
    {
        public Mostrar_Vencidos()
        {
            InitializeComponent();
        }

        private void Mostrar_Vencidos_Load(object sender, EventArgs e)
        {
            Mostrar_Vencido ven = new Mostrar_Vencido();
            dataGridView1.DataSource = ven.MostrarVen();

            Mostrar_Por_Vencer pven = new Mostrar_Por_Vencer();
            dataGridView2.DataSource = pven.Mostrarporven();

        }
    }
}
