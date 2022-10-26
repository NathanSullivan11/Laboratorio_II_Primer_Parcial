
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
            this.gboxDatosCliente = new System.Windows.Forms.GroupBox();
            this.nudEdadCliente = new System.Windows.Forms.NumericUpDown();
            this.lblEdadCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblApellidoCiente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblMensajeErrorDatosCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel_ContenedorFuncionCliente = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ContenedorBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_BusquedaPorDni = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscarPorDni = new System.Windows.Forms.Label();
            this.txtFiltroPorDni = new System.Windows.Forms.TextBox();
            this.dgvClientesExistentes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_BotonesCliente = new System.Windows.Forms.TableLayoutPanel();
            this.btnClienteExistente = new System.Windows.Forms.Button();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.gboxEquipaje = new System.Windows.Forms.GroupBox();
            this.btnCargarEquipaje = new System.Windows.Forms.Button();
            this.tableLayoutPanel_TipoPasaje = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnPasajeTurista = new System.Windows.Forms.RadioButton();
            this.rbtnPasajePremium = new System.Windows.Forms.RadioButton();
            this.lblPesoKgMaleta1 = new System.Windows.Forms.Label();
            this.chkBoxEquipajeDeMano = new System.Windows.Forms.CheckBox();
            this.nudPesoEquipaje = new System.Windows.Forms.NumericUpDown();
            this.gboxCargaDatos = new System.Windows.Forms.GroupBox();
            this.chkBox_EquipajeCargado = new System.Windows.Forms.CheckBox();
            this.btnCargarPasajero = new System.Windows.Forms.Button();
            this.chkBox_PasaporteCargado = new System.Windows.Forms.CheckBox();
            this.lblPasaporteCargado = new System.Windows.Forms.Label();
            this.chkBox_ClienteCargado = new System.Windows.Forms.CheckBox();
            this.lblMensajeErrorCargaPasajero = new System.Windows.Forms.Label();
            this.lblEquipajeCargado = new System.Windows.Forms.Label();
            this.lblClienteCargado = new System.Windows.Forms.Label();
            this.gboxPasaporte = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lboxListaPasajeros = new System.Windows.Forms.ListBox();
            this.lblPasajerosCargados = new System.Windows.Forms.Label();
            this.gboxFinalizarVenta = new System.Windows.Forms.GroupBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.lblPrecioAcumulado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInfoCrucero = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gboxDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).BeginInit();
            this.tableLayoutPanel_ContenedorFuncionCliente.SuspendLayout();
            this.tableLayoutPanel_ContenedorBusqueda.SuspendLayout();
            this.tableLayoutPanel_BusquedaPorDni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExistentes)).BeginInit();
            this.tableLayoutPanel_BotonesCliente.SuspendLayout();
            this.gboxEquipaje.SuspendLayout();
            this.tableLayoutPanel_TipoPasaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoEquipaje)).BeginInit();
            this.gboxCargaDatos.SuspendLayout();
            this.gboxPasaporte.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gboxFinalizarVenta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDatosCliente
            // 
            this.gboxDatosCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.gboxDatosCliente.Controls.Add(this.lblMensajeErrorDatosCliente);
            this.gboxDatosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxDatosCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.gboxDatosCliente.Location = new System.Drawing.Point(760, 15);
            this.gboxDatosCliente.MaximumSize = new System.Drawing.Size(339, 208);
            this.gboxDatosCliente.MinimumSize = new System.Drawing.Size(338, 202);
            this.gboxDatosCliente.Name = "gboxDatosCliente";
            this.gboxDatosCliente.Size = new System.Drawing.Size(339, 208);
            this.gboxDatosCliente.TabIndex = 10;
            this.gboxDatosCliente.TabStop = false;
            this.gboxDatosCliente.Text = "Datos nuevo cliente";
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
            this.lblEdadCliente.Size = new System.Drawing.Size(41, 16);
            this.lblEdadCliente.TabIndex = 14;
            this.lblEdadCliente.Text = "Edad";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(20, 127);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(38, 16);
            this.lblDniCliente.TabIndex = 13;
            this.lblDniCliente.Text = "D.N.I";
            // 
            // lblApellidoCiente
            // 
            this.lblApellidoCiente.AutoSize = true;
            this.lblApellidoCiente.Location = new System.Drawing.Point(20, 81);
            this.lblApellidoCiente.Name = "lblApellidoCiente";
            this.lblApellidoCiente.Size = new System.Drawing.Size(63, 16);
            this.lblApellidoCiente.TabIndex = 12;
            this.lblApellidoCiente.Text = "Apellido";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 33);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCliente.TabIndex = 11;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCliente.Location = new System.Drawing.Point(237, 33);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(84, 136);
            this.btnAgregarCliente.TabIndex = 11;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(20, 99);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(195, 23);
            this.txtApellidoCliente.TabIndex = 2;
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
            // lblMensajeErrorDatosCliente
            // 
            this.lblMensajeErrorDatosCliente.AutoSize = true;
            this.lblMensajeErrorDatosCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeErrorDatosCliente.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorDatosCliente.Location = new System.Drawing.Point(44, 18);
            this.lblMensajeErrorDatosCliente.Name = "lblMensajeErrorDatosCliente";
            this.lblMensajeErrorDatosCliente.Size = new System.Drawing.Size(187, 15);
            this.lblMensajeErrorDatosCliente.TabIndex = 19;
            this.lblMensajeErrorDatosCliente.Text = "Mensaje de error ingreso cliente";
            this.lblMensajeErrorDatosCliente.Visible = false;
            // 
            // tableLayoutPanel_ContenedorFuncionCliente
            // 
            this.tableLayoutPanel_ContenedorFuncionCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_ContenedorFuncionCliente.ColumnCount = 2;
            this.tableLayoutPanel_ContenedorFuncionCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.4953F));
            this.tableLayoutPanel_ContenedorFuncionCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.5047F));
            this.tableLayoutPanel_ContenedorFuncionCliente.Controls.Add(this.tableLayoutPanel_ContenedorBusqueda, 1, 0);
            this.tableLayoutPanel_ContenedorFuncionCliente.Controls.Add(this.tableLayoutPanel_BotonesCliente, 0, 0);
            this.tableLayoutPanel_ContenedorFuncionCliente.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel_ContenedorFuncionCliente.Name = "tableLayoutPanel_ContenedorFuncionCliente";
            this.tableLayoutPanel_ContenedorFuncionCliente.RowCount = 1;
            this.tableLayoutPanel_ContenedorFuncionCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorFuncionCliente.Size = new System.Drawing.Size(728, 205);
            this.tableLayoutPanel_ContenedorFuncionCliente.TabIndex = 39;
            // 
            // tableLayoutPanel_ContenedorBusqueda
            // 
            this.tableLayoutPanel_ContenedorBusqueda.ColumnCount = 1;
            this.tableLayoutPanel_ContenedorBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorBusqueda.Controls.Add(this.tableLayoutPanel_BusquedaPorDni, 0, 0);
            this.tableLayoutPanel_ContenedorBusqueda.Controls.Add(this.dgvClientesExistentes, 0, 1);
            this.tableLayoutPanel_ContenedorBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorBusqueda.Location = new System.Drawing.Point(137, 3);
            this.tableLayoutPanel_ContenedorBusqueda.Name = "tableLayoutPanel_ContenedorBusqueda";
            this.tableLayoutPanel_ContenedorBusqueda.RowCount = 2;
            this.tableLayoutPanel_ContenedorBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_ContenedorBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_ContenedorBusqueda.Size = new System.Drawing.Size(588, 199);
            this.tableLayoutPanel_ContenedorBusqueda.TabIndex = 41;
            // 
            // tableLayoutPanel_BusquedaPorDni
            // 
            this.tableLayoutPanel_BusquedaPorDni.ColumnCount = 3;
            this.tableLayoutPanel_BusquedaPorDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9759F));
            this.tableLayoutPanel_BusquedaPorDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.02409F));
            this.tableLayoutPanel_BusquedaPorDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel_BusquedaPorDni.Controls.Add(this.lblBuscarPorDni, 0, 0);
            this.tableLayoutPanel_BusquedaPorDni.Controls.Add(this.txtFiltroPorDni, 1, 0);
            this.tableLayoutPanel_BusquedaPorDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_BusquedaPorDni.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_BusquedaPorDni.Name = "tableLayoutPanel_BusquedaPorDni";
            this.tableLayoutPanel_BusquedaPorDni.RowCount = 1;
            this.tableLayoutPanel_BusquedaPorDni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_BusquedaPorDni.Size = new System.Drawing.Size(582, 23);
            this.tableLayoutPanel_BusquedaPorDni.TabIndex = 40;
            // 
            // lblBuscarPorDni
            // 
            this.lblBuscarPorDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscarPorDni.AutoSize = true;
            this.lblBuscarPorDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarPorDni.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorDni.Location = new System.Drawing.Point(19, 3);
            this.lblBuscarPorDni.Name = "lblBuscarPorDni";
            this.lblBuscarPorDni.Size = new System.Drawing.Size(108, 16);
            this.lblBuscarPorDni.TabIndex = 21;
            this.lblBuscarPorDni.Text = "Buscar por DNI:";
            this.lblBuscarPorDni.Visible = false;
            // 
            // txtFiltroPorDni
            // 
            this.txtFiltroPorDni.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFiltroPorDni.Location = new System.Drawing.Point(149, 3);
            this.txtFiltroPorDni.Name = "txtFiltroPorDni";
            this.txtFiltroPorDni.Size = new System.Drawing.Size(183, 23);
            this.txtFiltroPorDni.TabIndex = 21;
            this.txtFiltroPorDni.Visible = false;
            this.txtFiltroPorDni.TextChanged += new System.EventHandler(this.txtFiltroPorDni_TextChanged);
            this.txtFiltroPorDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroPorDni_KeyPress);
            // 
            // dgvClientesExistentes
            // 
            this.dgvClientesExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesExistentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClientesExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesExistentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientesExistentes.Location = new System.Drawing.Point(3, 32);
            this.dgvClientesExistentes.Name = "dgvClientesExistentes";
            this.dgvClientesExistentes.RowTemplate.Height = 25;
            this.dgvClientesExistentes.Size = new System.Drawing.Size(582, 164);
            this.dgvClientesExistentes.TabIndex = 9;
            // 
            // tableLayoutPanel_BotonesCliente
            // 
            this.tableLayoutPanel_BotonesCliente.ColumnCount = 1;
            this.tableLayoutPanel_BotonesCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_BotonesCliente.Controls.Add(this.btnClienteExistente, 0, 1);
            this.tableLayoutPanel_BotonesCliente.Controls.Add(this.btnClienteNuevo, 0, 0);
            this.tableLayoutPanel_BotonesCliente.Controls.Add(this.btnSeleccionarCliente, 0, 2);
            this.tableLayoutPanel_BotonesCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_BotonesCliente.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_BotonesCliente.Name = "tableLayoutPanel_BotonesCliente";
            this.tableLayoutPanel_BotonesCliente.RowCount = 3;
            this.tableLayoutPanel_BotonesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_BotonesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_BotonesCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_BotonesCliente.Size = new System.Drawing.Size(128, 199);
            this.tableLayoutPanel_BotonesCliente.TabIndex = 38;
            // 
            // btnClienteExistente
            // 
            this.btnClienteExistente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClienteExistente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnClienteExistente.FlatAppearance.BorderSize = 0;
            this.btnClienteExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteExistente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClienteExistente.ForeColor = System.Drawing.Color.White;
            this.btnClienteExistente.Location = new System.Drawing.Point(16, 75);
            this.btnClienteExistente.Name = "btnClienteExistente";
            this.btnClienteExistente.Size = new System.Drawing.Size(95, 48);
            this.btnClienteExistente.TabIndex = 8;
            this.btnClienteExistente.Text = "Cliente existente";
            this.btnClienteExistente.UseVisualStyleBackColor = false;
            this.btnClienteExistente.Click += new System.EventHandler(this.btnClienteExistente_Click);
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClienteNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnClienteNuevo.FlatAppearance.BorderSize = 0;
            this.btnClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClienteNuevo.ForeColor = System.Drawing.Color.White;
            this.btnClienteNuevo.Location = new System.Drawing.Point(20, 11);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(88, 44);
            this.btnClienteNuevo.TabIndex = 7;
            this.btnClienteNuevo.Text = "Cliente nuevo";
            this.btnClienteNuevo.UseVisualStyleBackColor = false;
            this.btnClienteNuevo.Click += new System.EventHandler(this.btnClienteNuevo_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnSeleccionarCliente.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionarCliente.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(16, 142);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(95, 47);
            this.btnSeleccionarCliente.TabIndex = 4;
            this.btnSeleccionarCliente.Text = "Seleccionar cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = false;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // gboxEquipaje
            // 
            this.gboxEquipaje.BackColor = System.Drawing.Color.Transparent;
            this.gboxEquipaje.Controls.Add(this.btnCargarEquipaje);
            this.gboxEquipaje.Controls.Add(this.tableLayoutPanel_TipoPasaje);
            this.gboxEquipaje.Controls.Add(this.lblPesoKgMaleta1);
            this.gboxEquipaje.Controls.Add(this.chkBoxEquipajeDeMano);
            this.gboxEquipaje.Controls.Add(this.nudPesoEquipaje);
            this.gboxEquipaje.Enabled = false;
            this.gboxEquipaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxEquipaje.ForeColor = System.Drawing.Color.White;
            this.gboxEquipaje.Location = new System.Drawing.Point(365, 18);
            this.gboxEquipaje.Name = "gboxEquipaje";
            this.gboxEquipaje.Size = new System.Drawing.Size(326, 145);
            this.gboxEquipaje.TabIndex = 6;
            this.gboxEquipaje.TabStop = false;
            this.gboxEquipaje.Text = "Datos equipaje";
            // 
            // btnCargarEquipaje
            // 
            this.btnCargarEquipaje.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarEquipaje.FlatAppearance.BorderSize = 0;
            this.btnCargarEquipaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarEquipaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarEquipaje.ForeColor = System.Drawing.Color.White;
            this.btnCargarEquipaje.Location = new System.Drawing.Point(212, 55);
            this.btnCargarEquipaje.Name = "btnCargarEquipaje";
            this.btnCargarEquipaje.Size = new System.Drawing.Size(104, 78);
            this.btnCargarEquipaje.TabIndex = 15;
            this.btnCargarEquipaje.Text = "Cargar equipaje";
            this.btnCargarEquipaje.UseVisualStyleBackColor = false;
            this.btnCargarEquipaje.Click += new System.EventHandler(this.btnCargarEquipaje_Click);
            // 
            // tableLayoutPanel_TipoPasaje
            // 
            this.tableLayoutPanel_TipoPasaje.ColumnCount = 2;
            this.tableLayoutPanel_TipoPasaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27954F));
            this.tableLayoutPanel_TipoPasaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72046F));
            this.tableLayoutPanel_TipoPasaje.Controls.Add(this.rbtnPasajeTurista, 0, 0);
            this.tableLayoutPanel_TipoPasaje.Controls.Add(this.rbtnPasajePremium, 1, 0);
            this.tableLayoutPanel_TipoPasaje.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel_TipoPasaje.Name = "tableLayoutPanel_TipoPasaje";
            this.tableLayoutPanel_TipoPasaje.RowCount = 1;
            this.tableLayoutPanel_TipoPasaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TipoPasaje.Size = new System.Drawing.Size(326, 26);
            this.tableLayoutPanel_TipoPasaje.TabIndex = 42;
            // 
            // rbtnPasajeTurista
            // 
            this.rbtnPasajeTurista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnPasajeTurista.AutoSize = true;
            this.rbtnPasajeTurista.Checked = true;
            this.rbtnPasajeTurista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnPasajeTurista.ForeColor = System.Drawing.Color.White;
            this.rbtnPasajeTurista.Location = new System.Drawing.Point(32, 3);
            this.rbtnPasajeTurista.Name = "rbtnPasajeTurista";
            this.rbtnPasajeTurista.Size = new System.Drawing.Size(96, 19);
            this.rbtnPasajeTurista.TabIndex = 12;
            this.rbtnPasajeTurista.TabStop = true;
            this.rbtnPasajeTurista.Text = "Pasaje turista";
            this.rbtnPasajeTurista.UseVisualStyleBackColor = true;
            this.rbtnPasajeTurista.CheckedChanged += new System.EventHandler(this.rbtnPasajeTurista_CheckedChanged);
            // 
            // rbtnPasajePremium
            // 
            this.rbtnPasajePremium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnPasajePremium.AutoSize = true;
            this.rbtnPasajePremium.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnPasajePremium.ForeColor = System.Drawing.Color.White;
            this.rbtnPasajePremium.Location = new System.Drawing.Point(188, 3);
            this.rbtnPasajePremium.Name = "rbtnPasajePremium";
            this.rbtnPasajePremium.Size = new System.Drawing.Size(110, 19);
            this.rbtnPasajePremium.TabIndex = 11;
            this.rbtnPasajePremium.TabStop = true;
            this.rbtnPasajePremium.Text = "Pasaje premium";
            this.rbtnPasajePremium.UseVisualStyleBackColor = true;
            this.rbtnPasajePremium.CheckedChanged += new System.EventHandler(this.rbtnPasajePremium_CheckedChanged);
            // 
            // lblPesoKgMaleta1
            // 
            this.lblPesoKgMaleta1.AutoSize = true;
            this.lblPesoKgMaleta1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesoKgMaleta1.ForeColor = System.Drawing.Color.White;
            this.lblPesoKgMaleta1.Location = new System.Drawing.Point(32, 106);
            this.lblPesoKgMaleta1.Name = "lblPesoKgMaleta1";
            this.lblPesoKgMaleta1.Size = new System.Drawing.Size(57, 15);
            this.lblPesoKgMaleta1.TabIndex = 15;
            this.lblPesoKgMaleta1.Text = "Peso (kg)";
            // 
            // chkBoxEquipajeDeMano
            // 
            this.chkBoxEquipajeDeMano.AutoSize = true;
            this.chkBoxEquipajeDeMano.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBoxEquipajeDeMano.ForeColor = System.Drawing.Color.White;
            this.chkBoxEquipajeDeMano.Location = new System.Drawing.Point(43, 66);
            this.chkBoxEquipajeDeMano.Name = "chkBoxEquipajeDeMano";
            this.chkBoxEquipajeDeMano.Size = new System.Drawing.Size(123, 19);
            this.chkBoxEquipajeDeMano.TabIndex = 7;
            this.chkBoxEquipajeDeMano.Text = "Equipaje de mano";
            this.chkBoxEquipajeDeMano.UseVisualStyleBackColor = true;
            // 
            // nudPesoEquipaje
            // 
            this.nudPesoEquipaje.Location = new System.Drawing.Point(110, 103);
            this.nudPesoEquipaje.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudPesoEquipaje.Name = "nudPesoEquipaje";
            this.nudPesoEquipaje.Size = new System.Drawing.Size(56, 22);
            this.nudPesoEquipaje.TabIndex = 5;
            // 
            // gboxCargaDatos
            // 
            this.gboxCargaDatos.BackColor = System.Drawing.Color.Transparent;
            this.gboxCargaDatos.Controls.Add(this.chkBox_EquipajeCargado);
            this.gboxCargaDatos.Controls.Add(this.btnCargarPasajero);
            this.gboxCargaDatos.Controls.Add(this.chkBox_PasaporteCargado);
            this.gboxCargaDatos.Controls.Add(this.lblPasaporteCargado);
            this.gboxCargaDatos.Controls.Add(this.chkBox_ClienteCargado);
            this.gboxCargaDatos.Controls.Add(this.lblMensajeErrorCargaPasajero);
            this.gboxCargaDatos.Controls.Add(this.lblEquipajeCargado);
            this.gboxCargaDatos.Controls.Add(this.lblClienteCargado);
            this.gboxCargaDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxCargaDatos.ForeColor = System.Drawing.Color.White;
            this.gboxCargaDatos.Location = new System.Drawing.Point(365, 175);
            this.gboxCargaDatos.Name = "gboxCargaDatos";
            this.gboxCargaDatos.Size = new System.Drawing.Size(326, 157);
            this.gboxCargaDatos.TabIndex = 41;
            this.gboxCargaDatos.TabStop = false;
            this.gboxCargaDatos.Text = "Datos cliente";
            // 
            // chkBox_EquipajeCargado
            // 
            this.chkBox_EquipajeCargado.AutoSize = true;
            this.chkBox_EquipajeCargado.Location = new System.Drawing.Point(182, 122);
            this.chkBox_EquipajeCargado.Name = "chkBox_EquipajeCargado";
            this.chkBox_EquipajeCargado.Size = new System.Drawing.Size(15, 14);
            this.chkBox_EquipajeCargado.TabIndex = 46;
            this.chkBox_EquipajeCargado.UseVisualStyleBackColor = true;
            this.chkBox_EquipajeCargado.CheckedChanged += new System.EventHandler(this.chkBox_EquipajeCargado_CheckedChanged);
            // 
            // btnCargarPasajero
            // 
            this.btnCargarPasajero.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarPasajero.Enabled = false;
            this.btnCargarPasajero.FlatAppearance.BorderSize = 0;
            this.btnCargarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPasajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPasajero.ForeColor = System.Drawing.Color.White;
            this.btnCargarPasajero.Location = new System.Drawing.Point(241, 24);
            this.btnCargarPasajero.Name = "btnCargarPasajero";
            this.btnCargarPasajero.Size = new System.Drawing.Size(75, 120);
            this.btnCargarPasajero.TabIndex = 20;
            this.btnCargarPasajero.Text = "Cargar pasajero";
            this.btnCargarPasajero.UseVisualStyleBackColor = false;
            this.btnCargarPasajero.Click += new System.EventHandler(this.btnCargarPasajero_Click);
            // 
            // chkBox_PasaporteCargado
            // 
            this.chkBox_PasaporteCargado.AutoSize = true;
            this.chkBox_PasaporteCargado.Location = new System.Drawing.Point(182, 91);
            this.chkBox_PasaporteCargado.Name = "chkBox_PasaporteCargado";
            this.chkBox_PasaporteCargado.Size = new System.Drawing.Size(15, 14);
            this.chkBox_PasaporteCargado.TabIndex = 46;
            this.chkBox_PasaporteCargado.UseVisualStyleBackColor = true;
            this.chkBox_PasaporteCargado.CheckedChanged += new System.EventHandler(this.chkBox_PasaporteCargado_CheckedChanged);
            // 
            // lblPasaporteCargado
            // 
            this.lblPasaporteCargado.AutoSize = true;
            this.lblPasaporteCargado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasaporteCargado.ForeColor = System.Drawing.Color.Red;
            this.lblPasaporteCargado.Location = new System.Drawing.Point(17, 89);
            this.lblPasaporteCargado.Name = "lblPasaporteCargado";
            this.lblPasaporteCargado.Size = new System.Drawing.Size(133, 16);
            this.lblPasaporteCargado.TabIndex = 26;
            this.lblPasaporteCargado.Text = "Pasaporte cargado";
            // 
            // chkBox_ClienteCargado
            // 
            this.chkBox_ClienteCargado.AutoSize = true;
            this.chkBox_ClienteCargado.Location = new System.Drawing.Point(182, 63);
            this.chkBox_ClienteCargado.Name = "chkBox_ClienteCargado";
            this.chkBox_ClienteCargado.Size = new System.Drawing.Size(15, 14);
            this.chkBox_ClienteCargado.TabIndex = 46;
            this.chkBox_ClienteCargado.UseVisualStyleBackColor = true;
            this.chkBox_ClienteCargado.CheckedChanged += new System.EventHandler(this.chkBox_ClienteCargado_CheckedChanged);
            // 
            // lblMensajeErrorCargaPasajero
            // 
            this.lblMensajeErrorCargaPasajero.AutoSize = true;
            this.lblMensajeErrorCargaPasajero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeErrorCargaPasajero.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorCargaPasajero.Location = new System.Drawing.Point(7, 33);
            this.lblMensajeErrorCargaPasajero.Name = "lblMensajeErrorCargaPasajero";
            this.lblMensajeErrorCargaPasajero.Size = new System.Drawing.Size(228, 15);
            this.lblMensajeErrorCargaPasajero.TabIndex = 37;
            this.lblMensajeErrorCargaPasajero.Text = "Mensaje de error ingreso carga pasajero";
            this.lblMensajeErrorCargaPasajero.Visible = false;
            // 
            // lblEquipajeCargado
            // 
            this.lblEquipajeCargado.AutoSize = true;
            this.lblEquipajeCargado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquipajeCargado.ForeColor = System.Drawing.Color.Red;
            this.lblEquipajeCargado.Location = new System.Drawing.Point(17, 119);
            this.lblEquipajeCargado.Name = "lblEquipajeCargado";
            this.lblEquipajeCargado.Size = new System.Drawing.Size(126, 16);
            this.lblEquipajeCargado.TabIndex = 28;
            this.lblEquipajeCargado.Text = "Equipaje cargado";
            // 
            // lblClienteCargado
            // 
            this.lblClienteCargado.AutoSize = true;
            this.lblClienteCargado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClienteCargado.ForeColor = System.Drawing.Color.Red;
            this.lblClienteCargado.Location = new System.Drawing.Point(17, 61);
            this.lblClienteCargado.Name = "lblClienteCargado";
            this.lblClienteCargado.Size = new System.Drawing.Size(114, 16);
            this.lblClienteCargado.TabIndex = 31;
            this.lblClienteCargado.Text = "Cliente cargado";
            // 
            // gboxPasaporte
            // 
            this.gboxPasaporte.BackColor = System.Drawing.Color.Transparent;
            this.gboxPasaporte.Controls.Add(this.btnCargarPasaporte);
            this.gboxPasaporte.Controls.Add(this.lblMensajeErrorIngresoPasaporte);
            this.gboxPasaporte.Controls.Add(this.lblCaducidadPasaporte);
            this.gboxPasaporte.Controls.Add(this.lblNacionalidadPasaporte);
            this.gboxPasaporte.Controls.Add(this.lblNroPasaporte);
            this.gboxPasaporte.Controls.Add(this.lblSexoPasaporte);
            this.gboxPasaporte.Controls.Add(this.dtpCaducidadPasaporte);
            this.gboxPasaporte.Controls.Add(this.cmbSexoPasaporte);
            this.gboxPasaporte.Controls.Add(this.txtNacionalidadPasaporte);
            this.gboxPasaporte.Controls.Add(this.txtNroPasaporte);
            this.gboxPasaporte.Enabled = false;
            this.gboxPasaporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxPasaporte.ForeColor = System.Drawing.Color.White;
            this.gboxPasaporte.Location = new System.Drawing.Point(3, 70);
            this.gboxPasaporte.Name = "gboxPasaporte";
            this.gboxPasaporte.Size = new System.Drawing.Size(336, 264);
            this.gboxPasaporte.TabIndex = 42;
            this.gboxPasaporte.TabStop = false;
            this.gboxPasaporte.Text = "Datos pasaporte";
            // 
            // btnCargarPasaporte
            // 
            this.btnCargarPasaporte.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarPasaporte.FlatAppearance.BorderSize = 0;
            this.btnCargarPasaporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPasaporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPasaporte.ForeColor = System.Drawing.Color.White;
            this.btnCargarPasaporte.Location = new System.Drawing.Point(203, 30);
            this.btnCargarPasaporte.Name = "btnCargarPasaporte";
            this.btnCargarPasaporte.Size = new System.Drawing.Size(105, 182);
            this.btnCargarPasaporte.TabIndex = 18;
            this.btnCargarPasaporte.Text = "Cargar Pasaporte";
            this.btnCargarPasaporte.UseVisualStyleBackColor = false;
            this.btnCargarPasaporte.Click += new System.EventHandler(this.btnCargarPasaporte_Click);
            // 
            // lblMensajeErrorIngresoPasaporte
            // 
            this.lblMensajeErrorIngresoPasaporte.AutoSize = true;
            this.lblMensajeErrorIngresoPasaporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeErrorIngresoPasaporte.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorIngresoPasaporte.Location = new System.Drawing.Point(37, 225);
            this.lblMensajeErrorIngresoPasaporte.Name = "lblMensajeErrorIngresoPasaporte";
            this.lblMensajeErrorIngresoPasaporte.Size = new System.Drawing.Size(204, 15);
            this.lblMensajeErrorIngresoPasaporte.TabIndex = 20;
            this.lblMensajeErrorIngresoPasaporte.Text = "Mensaje de error ingreso pasaporte";
            this.lblMensajeErrorIngresoPasaporte.Visible = false;
            // 
            // lblCaducidadPasaporte
            // 
            this.lblCaducidadPasaporte.AutoSize = true;
            this.lblCaducidadPasaporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaducidadPasaporte.ForeColor = System.Drawing.Color.White;
            this.lblCaducidadPasaporte.Location = new System.Drawing.Point(6, 121);
            this.lblCaducidadPasaporte.Name = "lblCaducidadPasaporte";
            this.lblCaducidadPasaporte.Size = new System.Drawing.Size(75, 17);
            this.lblCaducidadPasaporte.TabIndex = 10;
            this.lblCaducidadPasaporte.Text = "Caducidad";
            // 
            // lblNacionalidadPasaporte
            // 
            this.lblNacionalidadPasaporte.AutoSize = true;
            this.lblNacionalidadPasaporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidadPasaporte.ForeColor = System.Drawing.Color.White;
            this.lblNacionalidadPasaporte.Location = new System.Drawing.Point(6, 75);
            this.lblNacionalidadPasaporte.Name = "lblNacionalidadPasaporte";
            this.lblNacionalidadPasaporte.Size = new System.Drawing.Size(89, 17);
            this.lblNacionalidadPasaporte.TabIndex = 9;
            this.lblNacionalidadPasaporte.Text = "Nacionalidad";
            // 
            // lblNroPasaporte
            // 
            this.lblNroPasaporte.AutoSize = true;
            this.lblNroPasaporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroPasaporte.ForeColor = System.Drawing.Color.White;
            this.lblNroPasaporte.Location = new System.Drawing.Point(6, 29);
            this.lblNroPasaporte.Name = "lblNroPasaporte";
            this.lblNroPasaporte.Size = new System.Drawing.Size(55, 17);
            this.lblNroPasaporte.TabIndex = 8;
            this.lblNroPasaporte.Text = "Número";
            // 
            // lblSexoPasaporte
            // 
            this.lblSexoPasaporte.AutoSize = true;
            this.lblSexoPasaporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexoPasaporte.ForeColor = System.Drawing.Color.White;
            this.lblSexoPasaporte.Location = new System.Drawing.Point(6, 166);
            this.lblSexoPasaporte.Name = "lblSexoPasaporte";
            this.lblSexoPasaporte.Size = new System.Drawing.Size(37, 17);
            this.lblSexoPasaporte.TabIndex = 7;
            this.lblSexoPasaporte.Text = "Sexo";
            // 
            // dtpCaducidadPasaporte
            // 
            this.dtpCaducidadPasaporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpCaducidadPasaporte.Location = new System.Drawing.Point(6, 141);
            this.dtpCaducidadPasaporte.MinDate = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            this.dtpCaducidadPasaporte.Name = "dtpCaducidadPasaporte";
            this.dtpCaducidadPasaporte.Size = new System.Drawing.Size(171, 22);
            this.dtpCaducidadPasaporte.TabIndex = 6;
            // 
            // cmbSexoPasaporte
            // 
            this.cmbSexoPasaporte.FormattingEnabled = true;
            this.cmbSexoPasaporte.Location = new System.Drawing.Point(6, 183);
            this.cmbSexoPasaporte.Name = "cmbSexoPasaporte";
            this.cmbSexoPasaporte.Size = new System.Drawing.Size(171, 25);
            this.cmbSexoPasaporte.TabIndex = 5;
            // 
            // txtNacionalidadPasaporte
            // 
            this.txtNacionalidadPasaporte.Location = new System.Drawing.Point(6, 95);
            this.txtNacionalidadPasaporte.Name = "txtNacionalidadPasaporte";
            this.txtNacionalidadPasaporte.Size = new System.Drawing.Size(171, 23);
            this.txtNacionalidadPasaporte.TabIndex = 4;
            // 
            // txtNroPasaporte
            // 
            this.txtNroPasaporte.Location = new System.Drawing.Point(6, 49);
            this.txtNroPasaporte.Name = "txtNroPasaporte";
            this.txtNroPasaporte.PlaceholderText = "Formato: \"XXX1111\"";
            this.txtNroPasaporte.Size = new System.Drawing.Size(171, 23);
            this.txtNroPasaporte.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.22822F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.77179F));
            this.tableLayoutPanel1.Controls.Add(this.gboxDatosCliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_ContenedorFuncionCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1034, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 239);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 14);
            this.panel1.TabIndex = 45;
            // 
            // lboxListaPasajeros
            // 
            this.lboxListaPasajeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxListaPasajeros.FormattingEnabled = true;
            this.lboxListaPasajeros.ItemHeight = 15;
            this.lboxListaPasajeros.Location = new System.Drawing.Point(3, 38);
            this.lboxListaPasajeros.Name = "lboxListaPasajeros";
            this.lboxListaPasajeros.Size = new System.Drawing.Size(322, 124);
            this.lboxListaPasajeros.TabIndex = 46;
            // 
            // lblPasajerosCargados
            // 
            this.lblPasajerosCargados.AutoSize = true;
            this.lblPasajerosCargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPasajerosCargados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasajerosCargados.ForeColor = System.Drawing.Color.White;
            this.lblPasajerosCargados.Location = new System.Drawing.Point(3, 0);
            this.lblPasajerosCargados.Name = "lblPasajerosCargados";
            this.lblPasajerosCargados.Size = new System.Drawing.Size(322, 16);
            this.lblPasajerosCargados.TabIndex = 31;
            this.lblPasajerosCargados.Text = "Pasajeros cargados";
            // 
            // gboxFinalizarVenta
            // 
            this.gboxFinalizarVenta.Controls.Add(this.lblPrecio);
            this.gboxFinalizarVenta.Controls.Add(this.lblPrecioFinal);
            this.gboxFinalizarVenta.Controls.Add(this.btnFinalizarVenta);
            this.gboxFinalizarVenta.Controls.Add(this.lblPrecioAcumulado);
            this.gboxFinalizarVenta.Controls.Add(this.btnCancelar);
            this.gboxFinalizarVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gboxFinalizarVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.gboxFinalizarVenta.Location = new System.Drawing.Point(3, 181);
            this.gboxFinalizarVenta.MaximumSize = new System.Drawing.Size(315, 185);
            this.gboxFinalizarVenta.MinimumSize = new System.Drawing.Size(315, 170);
            this.gboxFinalizarVenta.Name = "gboxFinalizarVenta";
            this.gboxFinalizarVenta.Size = new System.Drawing.Size(315, 174);
            this.gboxFinalizarVenta.TabIndex = 47;
            this.gboxFinalizarVenta.TabStop = false;
            this.gboxFinalizarVenta.Text = "Facturación";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(12, 29);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 16);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Visible = false;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.White;
            this.lblPrecioFinal.Location = new System.Drawing.Point(12, 67);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(102, 16);
            this.lblPrecioFinal.TabIndex = 24;
            this.lblPrecioFinal.Text = "Precio con IVA";
            this.lblPrecioFinal.Visible = false;
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFinalizarVenta.Enabled = false;
            this.btnFinalizarVenta.FlatAppearance.BorderSize = 0;
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarVenta.Location = new System.Drawing.Point(10, 138);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(153, 27);
            this.btnFinalizarVenta.TabIndex = 29;
            this.btnFinalizarVenta.Text = "Finalizar venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            // 
            // lblPrecioAcumulado
            // 
            this.lblPrecioAcumulado.AutoSize = true;
            this.lblPrecioAcumulado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioAcumulado.ForeColor = System.Drawing.Color.White;
            this.lblPrecioAcumulado.Location = new System.Drawing.Point(10, 103);
            this.lblPrecioAcumulado.Name = "lblPrecioAcumulado";
            this.lblPrecioAcumulado.Size = new System.Drawing.Size(126, 16);
            this.lblPrecioAcumulado.TabIndex = 32;
            this.lblPrecioAcumulado.Text = "Precio acumulado";
            this.lblPrecioAcumulado.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(182, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 27);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar venta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnInfoCrucero
            // 
            this.btnInfoCrucero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnInfoCrucero.FlatAppearance.BorderSize = 0;
            this.btnInfoCrucero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoCrucero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfoCrucero.ForeColor = System.Drawing.Color.White;
            this.btnInfoCrucero.Location = new System.Drawing.Point(171, 14);
            this.btnInfoCrucero.Name = "btnInfoCrucero";
            this.btnInfoCrucero.Size = new System.Drawing.Size(176, 38);
            this.btnInfoCrucero.TabIndex = 8;
            this.btnInfoCrucero.Text = "Info crucero";
            this.btnInfoCrucero.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(17, 14);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(104, 38);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.gboxEquipaje);
            this.panel3.Controls.Add(this.btnAyuda);
            this.panel3.Controls.Add(this.gboxCargaDatos);
            this.panel3.Controls.Add(this.btnInfoCrucero);
            this.panel3.Controls.Add(this.gboxPasaporte);
            this.panel3.Location = new System.Drawing.Point(55, 269);
            this.panel3.MaximumSize = new System.Drawing.Size(705, 355);
            this.panel3.MinimumSize = new System.Drawing.Size(705, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 335);
            this.panel3.TabIndex = 48;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblPasajerosCargados, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lboxListaPasajeros, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gboxFinalizarVenta, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(798, 253);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(328, 355);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(328, 358);
            this.tableLayoutPanel3.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(783, 253);
            this.panel2.MaximumSize = new System.Drawing.Size(15, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 358);
            this.panel2.TabIndex = 45;
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1126, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1142, 650);
            this.Name = "FrmVentaPasaje";
            this.Text = "FrmVentaPasaje";
            this.Load += new System.EventHandler(this.FrmVentaPasaje_Load);
            this.gboxDatosCliente.ResumeLayout(false);
            this.gboxDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).EndInit();
            this.tableLayoutPanel_ContenedorFuncionCliente.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorBusqueda.ResumeLayout(false);
            this.tableLayoutPanel_BusquedaPorDni.ResumeLayout(false);
            this.tableLayoutPanel_BusquedaPorDni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExistentes)).EndInit();
            this.tableLayoutPanel_BotonesCliente.ResumeLayout(false);
            this.gboxEquipaje.ResumeLayout(false);
            this.gboxEquipaje.PerformLayout();
            this.tableLayoutPanel_TipoPasaje.ResumeLayout(false);
            this.tableLayoutPanel_TipoPasaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoEquipaje)).EndInit();
            this.gboxCargaDatos.ResumeLayout(false);
            this.gboxCargaDatos.PerformLayout();
            this.gboxPasaporte.ResumeLayout(false);
            this.gboxPasaporte.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gboxFinalizarVenta.ResumeLayout(false);
            this.gboxFinalizarVenta.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatosCliente;
        private System.Windows.Forms.NumericUpDown nudEdadCliente;
        private System.Windows.Forms.Label lblEdadCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblApellidoCiente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblMensajeErrorDatosCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorFuncionCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorBusqueda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BusquedaPorDni;
        private System.Windows.Forms.Label lblBuscarPorDni;
        private System.Windows.Forms.TextBox txtFiltroPorDni;
        private System.Windows.Forms.DataGridView dgvClientesExistentes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BotonesCliente;
        private System.Windows.Forms.Button btnClienteExistente;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.GroupBox gboxEquipaje;
        private System.Windows.Forms.Button btnCargarEquipaje;
        private System.Windows.Forms.Label lblPesoKgMaleta1;
        private System.Windows.Forms.CheckBox chkBoxEquipajeDeMano;
        private System.Windows.Forms.NumericUpDown nudPesoEquipaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TipoPasaje;
        private System.Windows.Forms.RadioButton rbtnPasajeTurista;
        private System.Windows.Forms.RadioButton rbtnPasajePremium;
        private System.Windows.Forms.GroupBox gboxCargaDatos;
        private System.Windows.Forms.Button btnCargarPasajero;
        private System.Windows.Forms.Label lblPasaporteCargado;
        private System.Windows.Forms.Label lblMensajeErrorCargaPasajero;
        private System.Windows.Forms.Label lblEquipajeCargado;
        private System.Windows.Forms.Label lblClienteCargado;
        private System.Windows.Forms.GroupBox gboxPasaporte;
        private System.Windows.Forms.Button btnCargarPasaporte;
        private System.Windows.Forms.Label lblMensajeErrorIngresoPasaporte;
        private System.Windows.Forms.Label lblCaducidadPasaporte;
        private System.Windows.Forms.Label lblNacionalidadPasaporte;
        private System.Windows.Forms.Label lblNroPasaporte;
        private System.Windows.Forms.Label lblSexoPasaporte;
        private System.Windows.Forms.DateTimePicker dtpCaducidadPasaporte;
        private System.Windows.Forms.ComboBox cmbSexoPasaporte;
        private System.Windows.Forms.TextBox txtNacionalidadPasaporte;
        private System.Windows.Forms.TextBox txtNroPasaporte;
        private System.Windows.Forms.CheckBox chkBox_EquipajeCargado;
        private System.Windows.Forms.CheckBox chkBox_PasaporteCargado;
        private System.Windows.Forms.CheckBox chkBox_ClienteCargado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lboxListaPasajeros;
        private System.Windows.Forms.Label lblPasajerosCargados;
        private System.Windows.Forms.GroupBox gboxFinalizarVenta;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Label lblPrecioAcumulado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInfoCrucero;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
    }
}