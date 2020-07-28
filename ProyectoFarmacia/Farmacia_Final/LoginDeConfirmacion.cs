﻿using System;
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
    public partial class LoginDeConfirmacion : Form
    {
        public LoginDeConfirmacion()
        {
            InitializeComponent();
        }

        /// <summary>Captura los datos obtenidos en los textboxs  para hacer el login de confirmacion.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login_Confirmacion.Validar(textBoxCon_Usuario.Text,textBoxCon_Contrasena.Text ) == null)
            {
                MessageBox.Show("Error: El usuario o la contraseña ingresada no son correctas");
            }

            else
            {

                this.Hide();
                MessageBox.Show("Bienvenido!");
                Form formulario = new Eliminar_Cuentas();
                formulario.Show();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
