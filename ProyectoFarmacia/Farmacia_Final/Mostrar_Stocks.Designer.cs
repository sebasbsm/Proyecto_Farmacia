namespace Farmacia_Final
{
    partial class Mostrar_Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Stocks));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalir_MS = new System.Windows.Forms.Button();
            this.buttonActualizar_MS = new System.Windows.Forms.Button();
            this.buttonBuscar_MS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre_Producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(652, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSalir_MS
            // 
            this.buttonSalir_MS.Location = new System.Drawing.Point(724, 434);
            this.buttonSalir_MS.Name = "buttonSalir_MS";
            this.buttonSalir_MS.Size = new System.Drawing.Size(78, 27);
            this.buttonSalir_MS.TabIndex = 1;
            this.buttonSalir_MS.Text = "Salir";
            this.buttonSalir_MS.UseVisualStyleBackColor = true;
            this.buttonSalir_MS.Click += new System.EventHandler(this.buttonSalir_MS_Click);
            // 
            // buttonActualizar_MS
            // 
            this.buttonActualizar_MS.Location = new System.Drawing.Point(564, 435);
            this.buttonActualizar_MS.Name = "buttonActualizar_MS";
            this.buttonActualizar_MS.Size = new System.Drawing.Size(119, 24);
            this.buttonActualizar_MS.TabIndex = 2;
            this.buttonActualizar_MS.Text = "Mostrar Productos";
            this.buttonActualizar_MS.UseVisualStyleBackColor = true;
            this.buttonActualizar_MS.Click += new System.EventHandler(this.buttonActualizar_MS_Click);
            // 
            // buttonBuscar_MS
            // 
            this.buttonBuscar_MS.Location = new System.Drawing.Point(506, 132);
            this.buttonBuscar_MS.Name = "buttonBuscar_MS";
            this.buttonBuscar_MS.Size = new System.Drawing.Size(78, 23);
            this.buttonBuscar_MS.TabIndex = 3;
            this.buttonBuscar_MS.Text = "Buscar";
            this.buttonBuscar_MS.UseVisualStyleBackColor = true;
            this.buttonBuscar_MS.Click += new System.EventHandler(this.buttonBuscar_MS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del producto:";
            // 
            // textBoxNombre_Producto
            // 
            this.textBoxNombre_Producto.Location = new System.Drawing.Point(160, 134);
            this.textBoxNombre_Producto.Name = "textBoxNombre_Producto";
            this.textBoxNombre_Producto.Size = new System.Drawing.Size(322, 20);
            this.textBoxNombre_Producto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mostrar Stocks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(257, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(99, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Mostrar_Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(833, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre_Producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar_MS);
            this.Controls.Add(this.buttonActualizar_MS);
            this.Controls.Add(this.buttonSalir_MS);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mostrar_Stocks";
            this.Text = "Mostrar_Stocks";
            this.Load += new System.EventHandler(this.Mostrar_Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalir_MS;
        private System.Windows.Forms.Button buttonActualizar_MS;
        private System.Windows.Forms.Button buttonBuscar_MS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}