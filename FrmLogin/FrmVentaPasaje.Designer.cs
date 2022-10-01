
namespace Vista
{
    partial class FrmVentaPasaje
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
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.nudMaleta1 = new System.Windows.Forms.NumericUpDown();
            this.gboxEquipaje = new System.Windows.Forms.GroupBox();
            this.btnCargarEquipaje = new System.Windows.Forms.Button();
            this.lblPesoKgMaleta2 = new System.Windows.Forms.Label();
            this.nudMaleta2 = new System.Windows.Forms.NumericUpDown();
            this.lblPesoKgMaleta1 = new System.Windows.Forms.Label();
            this.chkBoxEquipajeDeMano = new System.Windows.Forms.CheckBox();
            this.cmbCantidadMaletas = new System.Windows.Forms.ComboBox();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.btnClienteExistente = new System.Windows.Forms.Button();
            this.dgvClientesExistentes = new System.Windows.Forms.DataGridView();
            this.gboxDatosCliente = new System.Windows.Forms.GroupBox();
            this.nudEdadCliente = new System.Windows.Forms.NumericUpDown();
            this.lblEdadCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblApellidoCiente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarPasaporte = new System.Windows.Forms.Button();
            this.lblMensajeErrorIngresoPasaporte = new System.Windows.Forms.Label();
            this.lblCaducidadPasaporte = new System.Windows.Forms.Label();
            this.lblNacionalidadPasaporte = new System.Windows.Forms.Label();
            this.lblNroPasaporte = new System.Windows.Forms.Label();
            this.lblSexoPasaporte = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbtnPasajePremium = new System.Windows.Forms.RadioButton();
            this.rbtnPasajeTurista = new System.Windows.Forms.RadioButton();
            this.lblMensajeErrorDatosCliente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaleta1)).BeginInit();
            this.gboxEquipaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaleta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExistentes)).BeginInit();
            this.gboxDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(20, 145);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(107, 23);
            this.txtDniCliente.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(20, 51);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(195, 23);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(20, 99);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(195, 23);
            this.txtApellidoCliente.TabIndex = 2;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(12, 94);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(85, 40);
            this.btnSeleccionarCliente.TabIndex = 4;
            this.btnSeleccionarCliente.Text = "Seleccionar cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // nudMaleta1
            // 
            this.nudMaleta1.Location = new System.Drawing.Point(26, 114);
            this.nudMaleta1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMaleta1.Name = "nudMaleta1";
            this.nudMaleta1.Size = new System.Drawing.Size(56, 23);
            this.nudMaleta1.TabIndex = 5;
            // 
            // gboxEquipaje
            // 
            this.gboxEquipaje.BackColor = System.Drawing.Color.Transparent;
            this.gboxEquipaje.Controls.Add(this.btnCargarEquipaje);
            this.gboxEquipaje.Controls.Add(this.lblPesoKgMaleta2);
            this.gboxEquipaje.Controls.Add(this.nudMaleta2);
            this.gboxEquipaje.Controls.Add(this.lblPesoKgMaleta1);
            this.gboxEquipaje.Controls.Add(this.chkBoxEquipajeDeMano);
            this.gboxEquipaje.Controls.Add(this.cmbCantidadMaletas);
            this.gboxEquipaje.Controls.Add(this.nudMaleta1);
            this.gboxEquipaje.Location = new System.Drawing.Point(426, 220);
            this.gboxEquipaje.Name = "gboxEquipaje";
            this.gboxEquipaje.Size = new System.Drawing.Size(270, 153);
            this.gboxEquipaje.TabIndex = 6;
            this.gboxEquipaje.TabStop = false;
            this.gboxEquipaje.Text = "Datos equipaje";
            // 
            // btnCargarEquipaje
            // 
            this.btnCargarEquipaje.Location = new System.Drawing.Point(171, 22);
            this.btnCargarEquipaje.Name = "btnCargarEquipaje";
            this.btnCargarEquipaje.Size = new System.Drawing.Size(84, 125);
            this.btnCargarEquipaje.TabIndex = 15;
            this.btnCargarEquipaje.Text = "Cargar equipaje";
            this.btnCargarEquipaje.UseVisualStyleBackColor = true;
            this.btnCargarEquipaje.Click += new System.EventHandler(this.btnCargarEquipaje_Click);
            // 
            // lblPesoKgMaleta2
            // 
            this.lblPesoKgMaleta2.AutoSize = true;
            this.lblPesoKgMaleta2.Location = new System.Drawing.Point(94, 96);
            this.lblPesoKgMaleta2.Name = "lblPesoKgMaleta2";
            this.lblPesoKgMaleta2.Size = new System.Drawing.Size(32, 15);
            this.lblPesoKgMaleta2.TabIndex = 17;
            this.lblPesoKgMaleta2.Text = "Peso";
            // 
            // nudMaleta2
            // 
            this.nudMaleta2.Location = new System.Drawing.Point(93, 114);
            this.nudMaleta2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMaleta2.Name = "nudMaleta2";
            this.nudMaleta2.Size = new System.Drawing.Size(56, 23);
            this.nudMaleta2.TabIndex = 16;
            // 
            // lblPesoKgMaleta1
            // 
            this.lblPesoKgMaleta1.AutoSize = true;
            this.lblPesoKgMaleta1.Location = new System.Drawing.Point(28, 96);
            this.lblPesoKgMaleta1.Name = "lblPesoKgMaleta1";
            this.lblPesoKgMaleta1.Size = new System.Drawing.Size(35, 15);
            this.lblPesoKgMaleta1.TabIndex = 15;
            this.lblPesoKgMaleta1.Text = "Peso ";
            // 
            // chkBoxEquipajeDeMano
            // 
            this.chkBoxEquipajeDeMano.AutoSize = true;
            this.chkBoxEquipajeDeMano.Location = new System.Drawing.Point(28, 33);
            this.chkBoxEquipajeDeMano.Name = "chkBoxEquipajeDeMano";
            this.chkBoxEquipajeDeMano.Size = new System.Drawing.Size(121, 19);
            this.chkBoxEquipajeDeMano.TabIndex = 7;
            this.chkBoxEquipajeDeMano.Text = "Equipaje de mano";
            this.chkBoxEquipajeDeMano.UseVisualStyleBackColor = true;
            // 
            // cmbCantidadMaletas
            // 
            this.cmbCantidadMaletas.FormattingEnabled = true;
            this.cmbCantidadMaletas.Location = new System.Drawing.Point(28, 62);
            this.cmbCantidadMaletas.Name = "cmbCantidadMaletas";
            this.cmbCantidadMaletas.Size = new System.Drawing.Size(121, 23);
            this.cmbCantidadMaletas.TabIndex = 5;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.Location = new System.Drawing.Point(12, 152);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(85, 41);
            this.btnClienteNuevo.TabIndex = 7;
            this.btnClienteNuevo.Text = "Cliente nuevo";
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            this.btnClienteNuevo.Click += new System.EventHandler(this.btnClienteNuevo_Click);
            // 
            // btnClienteExistente
            // 
            this.btnClienteExistente.Location = new System.Drawing.Point(12, 32);
            this.btnClienteExistente.Name = "btnClienteExistente";
            this.btnClienteExistente.Size = new System.Drawing.Size(85, 43);
            this.btnClienteExistente.TabIndex = 8;
            this.btnClienteExistente.Text = "Cliente existente";
            this.btnClienteExistente.UseVisualStyleBackColor = true;
            this.btnClienteExistente.Click += new System.EventHandler(this.btnClienteExistente_Click);
            // 
            // dgvClientesExistentes
            // 
            this.dgvClientesExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesExistentes.Location = new System.Drawing.Point(117, 32);
            this.dgvClientesExistentes.Name = "dgvClientesExistentes";
            this.dgvClientesExistentes.RowTemplate.Height = 25;
            this.dgvClientesExistentes.Size = new System.Drawing.Size(231, 168);
            this.dgvClientesExistentes.TabIndex = 9;
            // 
            // gboxDatosCliente
            // 
            this.gboxDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.gboxDatosCliente.Controls.Add(this.nudEdadCliente);
            this.gboxDatosCliente.Controls.Add(this.lblEdadCliente);
            this.gboxDatosCliente.Controls.Add(this.lblDniCliente);
            this.gboxDatosCliente.Controls.Add(this.lblApellidoCiente);
            this.gboxDatosCliente.Controls.Add(this.lblNombreCliente);
            this.gboxDatosCliente.Controls.Add(this.btnAgregarCliente);
            this.gboxDatosCliente.Controls.Add(this.txtApellidoCliente);
            this.gboxDatosCliente.Controls.Add(this.txtDniCliente);
            this.gboxDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gboxDatosCliente.Location = new System.Drawing.Point(360, 25);
            this.gboxDatosCliente.Name = "gboxDatosCliente";
            this.gboxDatosCliente.Size = new System.Drawing.Size(336, 175);
            this.gboxDatosCliente.TabIndex = 10;
            this.gboxDatosCliente.TabStop = false;
            this.gboxDatosCliente.Text = "Datos cliente";
            // 
            // nudEdadCliente
            // 
            this.nudEdadCliente.Location = new System.Drawing.Point(159, 146);
            this.nudEdadCliente.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEdadCliente.Name = "nudEdadCliente";
            this.nudEdadCliente.Size = new System.Drawing.Size(56, 23);
            this.nudEdadCliente.TabIndex = 18;
            // 
            // lblEdadCliente
            // 
            this.lblEdadCliente.AutoSize = true;
            this.lblEdadCliente.Location = new System.Drawing.Point(159, 127);
            this.lblEdadCliente.Name = "lblEdadCliente";
            this.lblEdadCliente.Size = new System.Drawing.Size(33, 15);
            this.lblEdadCliente.TabIndex = 14;
            this.lblEdadCliente.Text = "Edad";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(20, 127);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(33, 15);
            this.lblDniCliente.TabIndex = 13;
            this.lblDniCliente.Text = "D.N.I";
            // 
            // lblApellidoCiente
            // 
            this.lblApellidoCiente.AutoSize = true;
            this.lblApellidoCiente.Location = new System.Drawing.Point(20, 81);
            this.lblApellidoCiente.Name = "lblApellidoCiente";
            this.lblApellidoCiente.Size = new System.Drawing.Size(51, 15);
            this.lblApellidoCiente.TabIndex = 12;
            this.lblApellidoCiente.Text = "Apellido";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 33);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(51, 15);
            this.lblNombreCliente.TabIndex = 11;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(237, 33);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(84, 130);
            this.btnAgregarCliente.TabIndex = 11;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCargarPasaporte);
            this.groupBox1.Controls.Add(this.lblMensajeErrorIngresoPasaporte);
            this.groupBox1.Controls.Add(this.lblCaducidadPasaporte);
            this.groupBox1.Controls.Add(this.lblNacionalidadPasaporte);
            this.groupBox1.Controls.Add(this.lblNroPasaporte);
            this.groupBox1.Controls.Add(this.lblSexoPasaporte);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos pasaporte";
            // 
            // btnCargarPasaporte
            // 
            this.btnCargarPasaporte.Location = new System.Drawing.Point(210, 15);
            this.btnCargarPasaporte.Name = "btnCargarPasaporte";
            this.btnCargarPasaporte.Size = new System.Drawing.Size(76, 132);
            this.btnCargarPasaporte.TabIndex = 18;
            this.btnCargarPasaporte.Text = "Cargar Pasaporte";
            this.btnCargarPasaporte.UseVisualStyleBackColor = true;
            this.btnCargarPasaporte.Click += new System.EventHandler(this.btnCargarPasaporte_Click);
            // 
            // lblMensajeErrorIngresoPasaporte
            // 
            this.lblMensajeErrorIngresoPasaporte.AutoSize = true;
            this.lblMensajeErrorIngresoPasaporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeErrorIngresoPasaporte.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorIngresoPasaporte.Location = new System.Drawing.Point(0, 132);
            this.lblMensajeErrorIngresoPasaporte.Name = "lblMensajeErrorIngresoPasaporte";
            this.lblMensajeErrorIngresoPasaporte.Size = new System.Drawing.Size(204, 15);
            this.lblMensajeErrorIngresoPasaporte.TabIndex = 20;
            this.lblMensajeErrorIngresoPasaporte.Text = "Mensaje de error ingreso pasaporte";
            this.lblMensajeErrorIngresoPasaporte.Visible = false;
            // 
            // lblCaducidadPasaporte
            // 
            this.lblCaducidadPasaporte.AutoSize = true;
            this.lblCaducidadPasaporte.Location = new System.Drawing.Point(79, 83);
            this.lblCaducidadPasaporte.Name = "lblCaducidadPasaporte";
            this.lblCaducidadPasaporte.Size = new System.Drawing.Size(64, 15);
            this.lblCaducidadPasaporte.TabIndex = 10;
            this.lblCaducidadPasaporte.Text = "Caducidad";
            // 
            // lblNacionalidadPasaporte
            // 
            this.lblNacionalidadPasaporte.AutoSize = true;
            this.lblNacionalidadPasaporte.Location = new System.Drawing.Point(101, 26);
            this.lblNacionalidadPasaporte.Name = "lblNacionalidadPasaporte";
            this.lblNacionalidadPasaporte.Size = new System.Drawing.Size(77, 15);
            this.lblNacionalidadPasaporte.TabIndex = 9;
            this.lblNacionalidadPasaporte.Text = "Nacionalidad";
            // 
            // lblNroPasaporte
            // 
            this.lblNroPasaporte.AutoSize = true;
            this.lblNroPasaporte.Location = new System.Drawing.Point(6, 26);
            this.lblNroPasaporte.Name = "lblNroPasaporte";
            this.lblNroPasaporte.Size = new System.Drawing.Size(51, 15);
            this.lblNroPasaporte.TabIndex = 8;
            this.lblNroPasaporte.Text = "Número";
            // 
            // lblSexoPasaporte
            // 
            this.lblSexoPasaporte.AutoSize = true;
            this.lblSexoPasaporte.Location = new System.Drawing.Point(6, 83);
            this.lblSexoPasaporte.Name = "lblSexoPasaporte";
            this.lblSexoPasaporte.Size = new System.Drawing.Size(32, 15);
            this.lblSexoPasaporte.TabIndex = 7;
            this.lblSexoPasaporte.Text = "Sexo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(79, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 23);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 23);
            this.textBox2.TabIndex = 3;
            // 
            // rbtnPasajePremium
            // 
            this.rbtnPasajePremium.AutoSize = true;
            this.rbtnPasajePremium.Location = new System.Drawing.Point(310, 314);
            this.rbtnPasajePremium.Name = "rbtnPasajePremium";
            this.rbtnPasajePremium.Size = new System.Drawing.Size(110, 19);
            this.rbtnPasajePremium.TabIndex = 11;
            this.rbtnPasajePremium.TabStop = true;
            this.rbtnPasajePremium.Text = "Pasaje premium";
            this.rbtnPasajePremium.UseVisualStyleBackColor = true;
            this.rbtnPasajePremium.CheckedChanged += new System.EventHandler(this.rbtnPasajePremium_CheckedChanged);
            // 
            // rbtnPasajeTurista
            // 
            this.rbtnPasajeTurista.AutoSize = true;
            this.rbtnPasajeTurista.Checked = true;
            this.rbtnPasajeTurista.Location = new System.Drawing.Point(310, 282);
            this.rbtnPasajeTurista.Name = "rbtnPasajeTurista";
            this.rbtnPasajeTurista.Size = new System.Drawing.Size(94, 19);
            this.rbtnPasajeTurista.TabIndex = 12;
            this.rbtnPasajeTurista.TabStop = true;
            this.rbtnPasajeTurista.Text = "Pasaje turista";
            this.rbtnPasajeTurista.UseVisualStyleBackColor = true;
            this.rbtnPasajeTurista.CheckedChanged += new System.EventHandler(this.rbtnPasajeTurista_CheckedChanged);
            // 
            // lblMensajeErrorDatosCliente
            // 
            this.lblMensajeErrorDatosCliente.AutoSize = true;
            this.lblMensajeErrorDatosCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeErrorDatosCliente.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorDatosCliente.Location = new System.Drawing.Point(426, 9);
            this.lblMensajeErrorDatosCliente.Name = "lblMensajeErrorDatosCliente";
            this.lblMensajeErrorDatosCliente.Size = new System.Drawing.Size(187, 15);
            this.lblMensajeErrorDatosCliente.TabIndex = 19;
            this.lblMensajeErrorDatosCliente.Text = "Mensaje de error ingreso cliente";
            this.lblMensajeErrorDatosCliente.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 54);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblMensajeErrorDatosCliente);
            this.Controls.Add(this.rbtnPasajeTurista);
            this.Controls.Add(this.rbtnPasajePremium);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxDatosCliente);
            this.Controls.Add(this.dgvClientesExistentes);
            this.Controls.Add(this.btnClienteExistente);
            this.Controls.Add(this.btnClienteNuevo);
            this.Controls.Add(this.gboxEquipaje);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Name = "FrmVentaPasaje";
            this.Text = "Venta de pasaje";
            this.Load += new System.EventHandler(this.FrmVentaPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaleta1)).EndInit();
            this.gboxEquipaje.ResumeLayout(false);
            this.gboxEquipaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaleta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExistentes)).EndInit();
            this.gboxDatosCliente.ResumeLayout(false);
            this.gboxDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.NumericUpDown nudMaleta1;
        private System.Windows.Forms.GroupBox gboxEquipaje;
        private System.Windows.Forms.ComboBox cmbCantidadMaletas;
        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.Button btnClienteExistente;
        private System.Windows.Forms.DataGridView dgvClientesExistentes;
        private System.Windows.Forms.GroupBox gboxDatosCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEdadCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblApellidoCiente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCaducidadPasaporte;
        private System.Windows.Forms.Label lblNacionalidadPasaporte;
        private System.Windows.Forms.Label lblNroPasaporte;
        private System.Windows.Forms.Label lblSexoPasaporte;
        private System.Windows.Forms.RadioButton rbtnPasajePremium;
        private System.Windows.Forms.RadioButton rbtnPasajeTurista;
        private System.Windows.Forms.Label lblPesoKgMaleta1;
        private System.Windows.Forms.CheckBox chkBoxEquipajeDeMano;
        private System.Windows.Forms.Label lblPesoKgMaleta2;
        private System.Windows.Forms.NumericUpDown nudMaleta2;
        private System.Windows.Forms.Button btnCargarEquipaje;
        private System.Windows.Forms.NumericUpDown nudEdadCliente;
        private System.Windows.Forms.Label lblMensajeErrorDatosCliente;
        private System.Windows.Forms.Label lblMensajeErrorIngresoPasaporte;
        private System.Windows.Forms.Button btnCargarPasaporte;
        private System.Windows.Forms.Button button2;
    }
}