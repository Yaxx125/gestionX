namespace gestionX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnMoverse = new Button();
            btnDetenerse = new Button();
            btnIniciar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblPasajeros = new Label();
            lblCapacidadCarga = new Label();
            lblBateria = new Label();
            cboTipoVehiculo = new ComboBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtPasajeros = new TextBox();
            txtCarga = new TextBox();
            txtBateria = new TextBox();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(479, 29);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMoverse
            // 
            btnMoverse.Location = new Point(479, 77);
            btnMoverse.Name = "btnMoverse";
            btnMoverse.Size = new Size(112, 34);
            btnMoverse.TabIndex = 1;
            btnMoverse.Text = "Moverse";
            btnMoverse.UseVisualStyleBackColor = true;
            btnMoverse.Click += btnMoverse_Click;
            // 
            // btnDetenerse
            // 
            btnDetenerse.Location = new Point(479, 134);
            btnDetenerse.Name = "btnDetenerse";
            btnDetenerse.Size = new Size(112, 34);
            btnDetenerse.TabIndex = 2;
            btnDetenerse.Text = "Detenerse";
            btnDetenerse.UseVisualStyleBackColor = true;
            btnDetenerse.Click += btnDetenerse_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(626, 26);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(626, 77);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 5;
            label1.Text = "Tipo de vehiculo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(37, 90);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(38, 143);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(74, 25);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo";
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Location = new Point(34, 199);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(85, 25);
            lblPasajeros.TabIndex = 8;
            lblPasajeros.Text = "Pasajeros";
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.Location = new Point(38, 203);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(168, 25);
            lblCapacidadCarga.TabIndex = 9;
            lblCapacidadCarga.Text = "Capacidad de carga";
            // 
            // lblBateria
            // 
            lblBateria.AutoSize = true;
            lblBateria.Location = new Point(38, 203);
            lblBateria.Name = "lblBateria";
            lblBateria.Size = new Size(182, 25);
            lblBateria.TabIndex = 10;
            lblBateria.Text = "Porcentaje de bateria ";
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Items.AddRange(new object[] { "Auto", "Motocicleta", "Camión", "Vehiculo Eléctrico" });
            cboTipoVehiculo.Location = new Point(243, 31);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(182, 33);
            cboTipoVehiculo.TabIndex = 11;
            cboTipoVehiculo.SelectedIndexChanged += cboTipoVehiculo_SelectedIndexChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(243, 80);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(150, 31);
            txtMarca.TabIndex = 12;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(243, 143);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(150, 31);
            txtModelo.TabIndex = 13;
            // 
            // txtPasajeros
            // 
            txtPasajeros.Location = new Point(243, 203);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(150, 31);
            txtPasajeros.TabIndex = 14;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(243, 201);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(150, 31);
            txtCarga.TabIndex = 15;
            // 
            // txtBateria
            // 
            txtBateria.Location = new Point(243, 199);
            txtBateria.Name = "txtBateria";
            txtBateria.Size = new Size(150, 31);
            txtBateria.TabIndex = 16;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(628, 135);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(112, 34);
            btnCargar.TabIndex = 17;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(btnCargar);
            Controls.Add(txtBateria);
            Controls.Add(txtCarga);
            Controls.Add(txtPasajeros);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(lblBateria);
            Controls.Add(lblCapacidadCarga);
            Controls.Add(lblPasajeros);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(btnDetenerse);
            Controls.Add(btnMoverse);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnMoverse;
        private Button btnDetenerse;
        private Button btnIniciar;
        private Button btnSalir;
        private Label label1;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblPasajeros;
        private Label lblCapacidadCarga;
        private Label lblBateria;
        private ComboBox cboTipoVehiculo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtPasajeros;
        private TextBox txtCarga;
        private TextBox txtBateria;
        private Button btnCargar;
    }
}
