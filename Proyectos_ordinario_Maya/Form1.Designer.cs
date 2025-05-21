namespace Proyectos_ordinario_Maya
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataAutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbAño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataAutos
            // 
            this.DataAutos.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAutos.GridColor = System.Drawing.Color.Thistle;
            this.DataAutos.Location = new System.Drawing.Point(50, 26);
            this.DataAutos.Name = "DataAutos";
            this.DataAutos.Size = new System.Drawing.Size(925, 386);
            this.DataAutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(47, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(50, 475);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(127, 20);
            this.txbID.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(50, 501);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(143, 26);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(832, 514);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 26);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(50, 425);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(143, 26);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(832, 558);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 26);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(50, 558);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(143, 26);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(199, 558);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(143, 26);
            this.btnImportar.TabIndex = 8;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(180, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marca";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(183, 475);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(127, 20);
            this.txbMarca.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(313, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(316, 475);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(127, 20);
            this.txbModelo.TabIndex = 12;
            // 
            // txbAño
            // 
            this.txbAño.Location = new System.Drawing.Point(449, 475);
            this.txbAño.Name = "txbAño";
            this.txbAño.Size = new System.Drawing.Size(127, 20);
            this.txbAño.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(446, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Año";
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(582, 475);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(127, 20);
            this.txbColor.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(579, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Color";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(715, 475);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(127, 20);
            this.txbPrecio.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(712, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(848, 475);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(127, 20);
            this.txbEstado.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(845, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Estado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(199, 501);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 26);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 620);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbAño);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataAutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataAutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbAño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

