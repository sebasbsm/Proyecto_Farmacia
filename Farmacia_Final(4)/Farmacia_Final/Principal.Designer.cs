namespace Farmacia_Final
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Registrar_ProductoP = new System.Windows.Forms.Button();
            this.Registrar_ClientesP = new System.Windows.Forms.Button();
            this.Salir_Principal = new System.Windows.Forms.Button();
            this.Registro_FarmaceuticosP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Eliminar_Farmaceutico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrar_ProductoP
            // 
            this.Registrar_ProductoP.Location = new System.Drawing.Point(64, 174);
            this.Registrar_ProductoP.Name = "Registrar_ProductoP";
            this.Registrar_ProductoP.Size = new System.Drawing.Size(130, 23);
            this.Registrar_ProductoP.TabIndex = 0;
            this.Registrar_ProductoP.Text = "Registrar Producto";
            this.Registrar_ProductoP.UseVisualStyleBackColor = true;
            this.Registrar_ProductoP.Click += new System.EventHandler(this.Registrar_ProductoP_Click);
            // 
            // Registrar_ClientesP
            // 
            this.Registrar_ClientesP.Location = new System.Drawing.Point(624, 174);
            this.Registrar_ClientesP.Name = "Registrar_ClientesP";
            this.Registrar_ClientesP.Size = new System.Drawing.Size(122, 23);
            this.Registrar_ClientesP.TabIndex = 2;
            this.Registrar_ClientesP.Text = "Registro de clientes";
            this.Registrar_ClientesP.UseVisualStyleBackColor = true;
            this.Registrar_ClientesP.Click += new System.EventHandler(this.Registrar_ClientesP_Click);
            // 
            // Salir_Principal
            // 
            this.Salir_Principal.Location = new System.Drawing.Point(671, 403);
            this.Salir_Principal.Name = "Salir_Principal";
            this.Salir_Principal.Size = new System.Drawing.Size(75, 23);
            this.Salir_Principal.TabIndex = 5;
            this.Salir_Principal.Text = "Salir";
            this.Salir_Principal.UseVisualStyleBackColor = true;
            this.Salir_Principal.Click += new System.EventHandler(this.Salir_Principal_Click);
            // 
            // Registro_FarmaceuticosP
            // 
            this.Registro_FarmaceuticosP.Location = new System.Drawing.Point(314, 174);
            this.Registro_FarmaceuticosP.Name = "Registro_FarmaceuticosP";
            this.Registro_FarmaceuticosP.Size = new System.Drawing.Size(161, 23);
            this.Registro_FarmaceuticosP.TabIndex = 6;
            this.Registro_FarmaceuticosP.Text = "Registro de Farmaceuticos";
            this.Registro_FarmaceuticosP.UseVisualStyleBackColor = true;
            this.Registro_FarmaceuticosP.Click += new System.EventHandler(this.Registro_FarmaceuticosP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 122);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_Eliminar_Farmaceutico
            // 
            this.button_Eliminar_Farmaceutico.Location = new System.Drawing.Point(64, 377);
            this.button_Eliminar_Farmaceutico.Name = "button_Eliminar_Farmaceutico";
            this.button_Eliminar_Farmaceutico.Size = new System.Drawing.Size(130, 23);
            this.button_Eliminar_Farmaceutico.TabIndex = 8;
            this.button_Eliminar_Farmaceutico.Text = "Eliminar Farmaceutico";
            this.button_Eliminar_Farmaceutico.UseVisualStyleBackColor = true;
            this.button_Eliminar_Farmaceutico.Click += new System.EventHandler(this.button_Eliminar_Farmaceutico_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Eliminar_Farmaceutico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Registro_FarmaceuticosP);
            this.Controls.Add(this.Salir_Principal);
            this.Controls.Add(this.Registrar_ClientesP);
            this.Controls.Add(this.Registrar_ProductoP);
            this.Name = "Principal";
            this.Text = "Principal";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registrar_ProductoP;
        private System.Windows.Forms.Button Registrar_ClientesP;
        private System.Windows.Forms.Button Salir_Principal;
        private System.Windows.Forms.Button Registro_FarmaceuticosP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Eliminar_Farmaceutico;
    }
}