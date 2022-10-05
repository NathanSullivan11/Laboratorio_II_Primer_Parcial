
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
            this.lblCantidadValijas = new System.Windows.Forms.Label();
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
            this.dtpCaducidadPasaporte = new System.Windows.Forms.DateTimePicker();
            this.cmbSexoPasaporte = new System.Windows.Forms.ComboBox();
            this.txtNacionalidadPasaporte = new System.Windows.Forms.TextBox();
            this.txtNroPasaporte = new System.Windows.Forms.TextBox();
            this.rbtnPasajePremium = new System.Windows.Forms.RadioButton();
            this.rbtnPasajeTurista = new System.Windows.Forms.RadioButton();
            this.lblMensajeErrorDatosCliente = new System.Windows.Forms.Label();
            this.btnCargarPasajero = new System.Windows.Forms.Button();
            this.txtFiltroPorDni = new System.Windows.Forms.TextBox();
            this.lblBuscarPorDni = new System.Windows.Forms.Label();
            this.lboxListaPasajeros = new System.Windows.Forms.ListBox();
            this.lblPasajerosCargados = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblPasaporteCargado = new System.Windows.Forms.Label();
            this.lblEquipajeCargado = new System.Windows.Forms.Label();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.lblClienteCargado = new System.Windows.Forms.Label();
            this.lblPrecioAcumulado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxTienePileta = new System.Windows.Forms.CheckBox();
            this.chkBoxTieneComedor = new System.Windows.Forms.CheckBox();
            this.chkBoxTieneGimnasio = new System.Windows.Forms.CheckBox();
            this.chkBoxTieneBar = new System.Windows.Forms.CheckBox();
            this.lblInfoCrucero = new System.Windows.Forms.Label();
            this.txtClienteCargado = new System.Windows.Forms.TextBox();
            this.txtPasaporteCargado = new System.Windows.Forms.TextBox();
            this.txtEquipajeCargado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensajeErrorCargaPasajero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaleta1)).BeginInit();
            this.gboxEquipaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaleta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExistentes)).BeginInit();
            this.gboxDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gboxEquipaje.Controls.Add(this.label1);
            this.gboxEquipaje.Controls.Add(this.lblCantidadValijas);
            this.gboxEquipaje.Controls.Add(this.btnCargarEquipaje);
            this.gboxEquipaje.Controls.Add(this.lblPesoKgMaleta2);
            this.gboxEquipaje.Controls.Add(this.nudMaleta2);
            this.gboxEquipaje.Controls.Add(this.lblPesoKgMaleta1);
            this.gboxEquipaje.Controls.Add(this.chkBoxEquipajeDeMano);
            this.gboxEquipaje.Controls.Add(this.cmbCantidadMaletas);
            this.gboxEquipaje.Controls.Add(this.nudMaleta1);
            this.gboxEquipaje.Location = new System.Drawing.Point(12, 290);
            this.gboxEquipaje.Name = "gboxEquipaje";
            this.gboxEquipaje.Size = new System.Drawing.Size(328, 153);
            this.gboxEquipaje.TabIndex = 6;
            this.gboxEquipaje.TabStop = false;
            this.gboxEquipaje.Text = "Datos equipaje";
            // 
            // lblCantidadValijas
            // 
            this.lblCantidadValijas.AutoSize = true;
            this.lblCantidadValijas.Location = new System.Drawing.Point(52, 55);
            this.lblCantidadValijas.Name = "lblCantidadValijas";
            this.lblCantidadValijas.Size = new System.Drawing.Size(90, 15);
            this.lblCantidadValijas.TabIndex = 18;
            this.lblCantidadValijas.Text = "Cantidad valijas";
            // 
            // btnCargarEquipaje
            // 
            this.btnCargarEquipaje.Location = new System.Drawing.Point(206, 26);
            this.btnCargarEquipaje.Name = "btnCargarEquipaje";
            this.btnCargarEquipaje.Size = new System.Drawing.Size(107, 114);
            this.btnCargarEquipaje.TabIndex = 15;
            this.btnCargarEquipaje.Text = "Cargar equipaje";
            this.btnCargarEquipaje.UseVisualStyleBackColor = true;
            this.btnCargarEquipaje.Click += new System.EventHandler(this.btnCargarEquipaje_Click);
            // 
            // lblPesoKgMaleta2
            // 
            this.lblPesoKgMaleta2.AutoSize = true;
            this.lblPesoKgMaleta2.Location = new System.Drawing.Point(114, 99);
            this.lblPesoKgMaleta2.Name = "lblPesoKgMaleta2";
            this.lblPesoKgMaleta2.Size = new System.Drawing.Size(56, 15);
            this.lblPesoKgMaleta2.TabIndex = 17;
            this.lblPesoKgMaleta2.Text = "Peso (kg)";
            // 
            // nudMaleta2
            // 
            this.nudMaleta2.Location = new System.Drawing.Point(114, 114);
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
            this.lblPesoKgMaleta1.Location = new System.Drawing.Point(26, 99);
            this.lblPesoKgMaleta1.Name = "lblPesoKgMaleta1";
            this.lblPesoKgMaleta1.Size = new System.Drawing.Size(56, 15);
            this.lblPesoKgMaleta1.TabIndex = 15;
            this.lblPesoKgMaleta1.Text = "Peso (kg)";
            // 
            // chkBoxEquipajeDeMano
            // 
            this.chkBoxEquipajeDeMano.AutoSize = true;
            this.chkBoxEquipajeDeMano.Location = new System.Drawing.Point(37, 26);
            this.chkBoxEquipajeDeMano.Name = "chkBoxEquipajeDeMano";
            this.chkBoxEquipajeDeMano.Size = new System.Drawing.Size(121, 19);
            this.chkBoxEquipajeDeMano.TabIndex = 7;
            this.chkBoxEquipajeDeMano.Text = "Equipaje de mano";
            this.chkBoxEquipajeDeMano.UseVisualStyleBackColor = true;
            // 
            // cmbCantidadMaletas
            // 
            this.cmbCantidadMaletas.FormattingEnabled = true;
            this.cmbCantidadMaletas.Location = new System.Drawing.Point(37, 73);
            this.cmbCantidadMaletas.Name = "cmbCantidadMaletas";
            this.cmbCantidadMaletas.Size = new System.Drawing.Size(121, 23);
            this.cmbCantidadMaletas.TabIndex = 5;
            this.cmbCantidadMaletas.SelectedIndexChanged += new System.EventHandler(this.cmbCantidadMaletas_SelectedIndexChanged);
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
            this.dgvClientesExistentes.Size = new System.Drawing.Size(303, 175);
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
            this.gboxDatosCliente.Location = new System.Drawing.Point(426, 32);
            this.gboxDatosCliente.Name = "gboxDatosCliente";
            this.gboxDatosCliente.Size = new System.Drawing.Size(338, 175);
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
            this.groupBox1.Controls.Add(this.dtpCaducidadPasaporte);
            this.groupBox1.Controls.Add(this.cmbSexoPasaporte);
            this.groupBox1.Controls.Add(this.txtNacionalidadPasaporte);
            this.groupBox1.Controls.Add(this.txtNroPasaporte);
            this.groupBox1.Location = new System.Drawing.Point(12, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos pasaporte";
            // 
            // btnCargarPasaporte
            // 
            this.btnCargarPasaporte.Location = new System.Drawing.Point(237, 15);
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
            this.lblMensajeErrorIngresoPasaporte.Location = new System.Drawing.Point(6, 132);
            this.lblMensajeErrorIngresoPasaporte.Name = "lblMensajeErrorIngresoPasaporte";
            this.lblMensajeErrorIngresoPasaporte.Size = new System.Drawing.Size(204, 15);
            this.lblMensajeErrorIngresoPasaporte.TabIndex = 20;
            this.lblMensajeErrorIngresoPasaporte.Text = "Mensaje de error ingreso pasaporte";
            this.lblMensajeErrorIngresoPasaporte.Visible = false;
            // 
            // lblCaducidadPasaporte
            // 
            this.lblCaducidadPasaporte.AutoSize = true;
            this.lblCaducidadPasaporte.Location = new System.Drawing.Point(114, 80);
            this.lblCaducidadPasaporte.Name = "lblCaducidadPasaporte";
            this.lblCaducidadPasaporte.Size = new System.Drawing.Size(64, 15);
            this.lblCaducidadPasaporte.TabIndex = 10;
            this.lblCaducidadPasaporte.Text = "Caducidad";
            // 
            // lblNacionalidadPasaporte
            // 
            this.lblNacionalidadPasaporte.AutoSize = true;
            this.lblNacionalidadPasaporte.Location = new System.Drawing.Point(114, 26);
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
            this.lblSexoPasaporte.Location = new System.Drawing.Point(6, 80);
            this.lblSexoPasaporte.Name = "lblSexoPasaporte";
            this.lblSexoPasaporte.Size = new System.Drawing.Size(32, 15);
            this.lblSexoPasaporte.TabIndex = 7;
            this.lblSexoPasaporte.Text = "Sexo";
            // 
            // dtpCaducidadPasaporte
            // 
            this.dtpCaducidadPasaporte.Location = new System.Drawing.Point(114, 98);
            this.dtpCaducidadPasaporte.MinDate = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            this.dtpCaducidadPasaporte.Name = "dtpCaducidadPasaporte";
            this.dtpCaducidadPasaporte.Size = new System.Drawing.Size(108, 23);
            this.dtpCaducidadPasaporte.TabIndex = 6;
            // 
            // cmbSexoPasaporte
            // 
            this.cmbSexoPasaporte.FormattingEnabled = true;
            this.cmbSexoPasaporte.Location = new System.Drawing.Point(6, 98);
            this.cmbSexoPasaporte.Name = "cmbSexoPasaporte";
            this.cmbSexoPasaporte.Size = new System.Drawing.Size(102, 23);
            this.cmbSexoPasaporte.TabIndex = 5;
            // 
            // txtNacionalidadPasaporte
            // 
            this.txtNacionalidadPasaporte.Location = new System.Drawing.Point(114, 44);
            this.txtNacionalidadPasaporte.Name = "txtNacionalidadPasaporte";
            this.txtNacionalidadPasaporte.Size = new System.Drawing.Size(108, 23);
            this.txtNacionalidadPasaporte.TabIndex = 4;
            // 
            // txtNroPasaporte
            // 
            this.txtNroPasaporte.Location = new System.Drawing.Point(6, 44);
            this.txtNroPasaporte.Name = "txtNroPasaporte";
            this.txtNroPasaporte.Size = new System.Drawing.Size(102, 23);
            this.txtNroPasaporte.TabIndex = 3;
            // 
            // rbtnPasajePremium
            // 
            this.rbtnPasajePremium.AutoSize = true;
            this.rbtnPasajePremium.Location = new System.Drawing.Point(188, 265);
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
            this.rbtnPasajeTurista.Location = new System.Drawing.Point(49, 265);
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
            // btnCargarPasajero
            // 
            this.btnCargarPasajero.Location = new System.Drawing.Point(585, 290);
            this.btnCargarPasajero.Name = "btnCargarPasajero";
            this.btnCargarPasajero.Size = new System.Drawing.Size(82, 153);
            this.btnCargarPasajero.TabIndex = 20;
            this.btnCargarPasajero.Text = "Cargar pasajero";
            this.btnCargarPasajero.UseVisualStyleBackColor = true;
            this.btnCargarPasajero.Click += new System.EventHandler(this.btnCargarPasajero_Click);
            // 
            // txtFiltroPorDni
            // 
            this.txtFiltroPorDni.Location = new System.Drawing.Point(274, 6);
            this.txtFiltroPorDni.Name = "txtFiltroPorDni";
            this.txtFiltroPorDni.Size = new System.Drawing.Size(146, 23);
            this.txtFiltroPorDni.TabIndex = 21;
            this.txtFiltroPorDni.Visible = false;
            this.txtFiltroPorDni.TextChanged += new System.EventHandler(this.txtFiltroPorDni_TextChanged);
            this.txtFiltroPorDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroPorDni_KeyPress);
            // 
            // lblBuscarPorDni
            // 
            this.lblBuscarPorDni.AutoSize = true;
            this.lblBuscarPorDni.Location = new System.Drawing.Point(179, 9);
            this.lblBuscarPorDni.Name = "lblBuscarPorDni";
            this.lblBuscarPorDni.Size = new System.Drawing.Size(89, 15);
            this.lblBuscarPorDni.TabIndex = 21;
            this.lblBuscarPorDni.Text = "Buscar por DNI:";
            this.lblBuscarPorDni.Visible = false;
            // 
            // lboxListaPasajeros
            // 
            this.lboxListaPasajeros.FormattingEnabled = true;
            this.lboxListaPasajeros.ItemHeight = 15;
            this.lboxListaPasajeros.Location = new System.Drawing.Point(355, 457);
            this.lboxListaPasajeros.Name = "lboxListaPasajeros";
            this.lboxListaPasajeros.Size = new System.Drawing.Size(313, 139);
            this.lboxListaPasajeros.TabIndex = 22;
            // 
            // lblPasajerosCargados
            // 
            this.lblPasajerosCargados.AutoSize = true;
            this.lblPasajerosCargados.Location = new System.Drawing.Point(353, 439);
            this.lblPasajerosCargados.Name = "lblPasajerosCargados";
            this.lblPasajerosCargados.Size = new System.Drawing.Size(107, 15);
            this.lblPasajerosCargados.TabIndex = 21;
            this.lblPasajerosCargados.Text = "Pasajeros cargados";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(684, 457);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 21);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Visible = false;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinal.Location = new System.Drawing.Point(684, 478);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(116, 21);
            this.lblPrecioFinal.TabIndex = 24;
            this.lblPrecioFinal.Text = "Precio con IVA";
            this.lblPrecioFinal.Visible = false;
            // 
            // lblPasaporteCargado
            // 
            this.lblPasaporteCargado.AutoSize = true;
            this.lblPasaporteCargado.Location = new System.Drawing.Point(355, 331);
            this.lblPasaporteCargado.Name = "lblPasaporteCargado";
            this.lblPasaporteCargado.Size = new System.Drawing.Size(105, 15);
            this.lblPasaporteCargado.TabIndex = 26;
            this.lblPasaporteCargado.Text = "Pasaporte cargado";
            // 
            // lblEquipajeCargado
            // 
            this.lblEquipajeCargado.AutoSize = true;
            this.lblEquipajeCargado.Location = new System.Drawing.Point(355, 386);
            this.lblEquipajeCargado.Name = "lblEquipajeCargado";
            this.lblEquipajeCargado.Size = new System.Drawing.Size(98, 15);
            this.lblEquipajeCargado.TabIndex = 28;
            this.lblEquipajeCargado.Text = "Equipaje cargado";
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(684, 553);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(153, 43);
            this.btnFinalizarVenta.TabIndex = 29;
            this.btnFinalizarVenta.Text = "Finalizar venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // lblClienteCargado
            // 
            this.lblClienteCargado.AutoSize = true;
            this.lblClienteCargado.Location = new System.Drawing.Point(358, 287);
            this.lblClienteCargado.Name = "lblClienteCargado";
            this.lblClienteCargado.Size = new System.Drawing.Size(90, 15);
            this.lblClienteCargado.TabIndex = 31;
            this.lblClienteCargado.Text = "Cliente cargado";
            // 
            // lblPrecioAcumulado
            // 
            this.lblPrecioAcumulado.AutoSize = true;
            this.lblPrecioAcumulado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioAcumulado.Location = new System.Drawing.Point(684, 509);
            this.lblPrecioAcumulado.Name = "lblPrecioAcumulado";
            this.lblPrecioAcumulado.Size = new System.Drawing.Size(140, 21);
            this.lblPrecioAcumulado.TabIndex = 32;
            this.lblPrecioAcumulado.Text = "Precio acumulado";
            this.lblPrecioAcumulado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkBoxTienePileta);
            this.groupBox2.Controls.Add(this.chkBoxTieneComedor);
            this.groupBox2.Controls.Add(this.chkBoxTieneGimnasio);
            this.groupBox2.Controls.Add(this.chkBoxTieneBar);
            this.groupBox2.Controls.Add(this.lblInfoCrucero);
            this.groupBox2.Location = new System.Drawing.Point(684, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 230);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crucero";
            // 
            // chkBoxTienePileta
            // 
            this.chkBoxTienePileta.AutoSize = true;
            this.chkBoxTienePileta.Enabled = false;
            this.chkBoxTienePileta.Location = new System.Drawing.Point(82, 205);
            this.chkBoxTienePileta.Name = "chkBoxTienePileta";
            this.chkBoxTienePileta.Size = new System.Drawing.Size(55, 19);
            this.chkBoxTienePileta.TabIndex = 26;
            this.chkBoxTienePileta.Text = "Pileta";
            this.chkBoxTienePileta.UseVisualStyleBackColor = true;
            // 
            // chkBoxTieneComedor
            // 
            this.chkBoxTieneComedor.AutoSize = true;
            this.chkBoxTieneComedor.Enabled = false;
            this.chkBoxTieneComedor.Location = new System.Drawing.Point(118, 180);
            this.chkBoxTieneComedor.Name = "chkBoxTieneComedor";
            this.chkBoxTieneComedor.Size = new System.Drawing.Size(76, 19);
            this.chkBoxTieneComedor.TabIndex = 25;
            this.chkBoxTieneComedor.Text = "Comedor";
            this.chkBoxTieneComedor.UseVisualStyleBackColor = true;
            // 
            // chkBoxTieneGimnasio
            // 
            this.chkBoxTieneGimnasio.AutoSize = true;
            this.chkBoxTieneGimnasio.Enabled = false;
            this.chkBoxTieneGimnasio.Location = new System.Drawing.Point(18, 180);
            this.chkBoxTieneGimnasio.Name = "chkBoxTieneGimnasio";
            this.chkBoxTieneGimnasio.Size = new System.Drawing.Size(76, 19);
            this.chkBoxTieneGimnasio.TabIndex = 24;
            this.chkBoxTieneGimnasio.Text = "Gimnasio";
            this.chkBoxTieneGimnasio.UseVisualStyleBackColor = true;
            // 
            // chkBoxTieneBar
            // 
            this.chkBoxTieneBar.AutoSize = true;
            this.chkBoxTieneBar.Enabled = false;
            this.chkBoxTieneBar.Location = new System.Drawing.Point(18, 205);
            this.chkBoxTieneBar.Name = "chkBoxTieneBar";
            this.chkBoxTieneBar.Size = new System.Drawing.Size(43, 19);
            this.chkBoxTieneBar.TabIndex = 19;
            this.chkBoxTieneBar.Text = "Bar";
            this.chkBoxTieneBar.UseVisualStyleBackColor = true;
            // 
            // lblInfoCrucero
            // 
            this.lblInfoCrucero.AutoSize = true;
            this.lblInfoCrucero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoCrucero.Location = new System.Drawing.Point(18, 39);
            this.lblInfoCrucero.Name = "lblInfoCrucero";
            this.lblInfoCrucero.Size = new System.Drawing.Size(119, 17);
            this.lblInfoCrucero.TabIndex = 22;
            this.lblInfoCrucero.Text = "Info básica crucero";
            // 
            // txtClienteCargado
            // 
            this.txtClienteCargado.Enabled = false;
            this.txtClienteCargado.Location = new System.Drawing.Point(358, 305);
            this.txtClienteCargado.Name = "txtClienteCargado";
            this.txtClienteCargado.Size = new System.Drawing.Size(195, 23);
            this.txtClienteCargado.TabIndex = 19;
            // 
            // txtPasaporteCargado
            // 
            this.txtPasaporteCargado.Enabled = false;
            this.txtPasaporteCargado.Location = new System.Drawing.Point(358, 349);
            this.txtPasaporteCargado.Name = "txtPasaporteCargado";
            this.txtPasaporteCargado.Size = new System.Drawing.Size(195, 23);
            this.txtPasaporteCargado.TabIndex = 34;
            // 
            // txtEquipajeCargado
            // 
            this.txtEquipajeCargado.Enabled = false;
            this.txtEquipajeCargado.Location = new System.Drawing.Point(358, 403);
            this.txtEquipajeCargado.Name = "txtEquipajeCargado";
            this.txtEquipajeCargado.Size = new System.Drawing.Size(195, 23);
            this.txtEquipajeCargado.TabIndex = 35;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(862, 553);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 43);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar venta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensajeErrorCargaPasajero
            // 
            this.lblMensajeErrorCargaPasajero.AutoSize = true;
            this.lblMensajeErrorCargaPasajero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeErrorCargaPasajero.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorCargaPasajero.Location = new System.Drawing.Point(371, 265);
            this.lblMensajeErrorCargaPasajero.Name = "lblMensajeErrorCargaPasajero";
            this.lblMensajeErrorCargaPasajero.Size = new System.Drawing.Size(228, 15);
            this.lblMensajeErrorCargaPasajero.TabIndex = 37;
            this.lblMensajeErrorCargaPasajero.Text = "Mensaje de error ingreso carga pasajero";
            this.lblMensajeErrorCargaPasajero.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad valijas";
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 634);
            this.Controls.Add(this.lblMensajeErrorCargaPasajero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEquipajeCargado);
            this.Controls.Add(this.txtPasaporteCargado);
            this.Controls.Add(this.txtClienteCargado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPrecioAcumulado);
            this.Controls.Add(this.lblClienteCargado);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.lblEquipajeCargado);
            this.Controls.Add(this.lblPasaporteCargado);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPasajerosCargados);
            this.Controls.Add(this.lboxListaPasajeros);
            this.Controls.Add(this.lblBuscarPorDni);
            this.Controls.Add(this.txtFiltroPorDni);
            this.Controls.Add(this.btnCargarPasajero);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpCaducidadPasaporte;
        private System.Windows.Forms.ComboBox cmbSexoPasaporte;
        private System.Windows.Forms.TextBox txtNacionalidadPasaporte;
        private System.Windows.Forms.TextBox txtNroPasaporte;
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
        private System.Windows.Forms.Button btnCargarPasajero;
        private System.Windows.Forms.TextBox txtFiltroPorDni;
        private System.Windows.Forms.Label lblBuscarPorDni;
        private System.Windows.Forms.ListBox lboxListaPasajeros;
        private System.Windows.Forms.Label lblPasajerosCargados;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblPasaporteCargado;
        private System.Windows.Forms.Label lblEquipajeCargado;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Label lblClienteCargado;
        private System.Windows.Forms.Label lblPrecioAcumulado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtClienteCargado;
        private System.Windows.Forms.TextBox txtPasaporteCargado;
        private System.Windows.Forms.TextBox txtEquipajeCargado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensajeErrorCargaPasajero;
        private System.Windows.Forms.Label lblCantidadValijas;
        private System.Windows.Forms.Label lblInfoCrucero;
        private System.Windows.Forms.CheckBox chkBoxTienePileta;
        private System.Windows.Forms.CheckBox chkBoxTieneComedor;
        private System.Windows.Forms.CheckBox chkBoxTieneGimnasio;
        private System.Windows.Forms.CheckBox chkBoxTieneBar;
        private System.Windows.Forms.Label label1;
    }
}