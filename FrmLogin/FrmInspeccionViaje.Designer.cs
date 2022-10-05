
namespace Vista
{
    partial class FrmInspeccionViaje
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
            this.dgvPasajerosDelViaje = new System.Windows.Forms.DataGridView();
            this.gboxCrucero = new System.Windows.Forms.GroupBox();
            this.lblCamarotesTurista = new System.Windows.Forms.Label();
            this.lblContieneCasino = new System.Windows.Forms.Label();
            this.lblCapacidadBodega = new System.Windows.Forms.Label();
            this.lblSalonesCrucero = new System.Windows.Forms.Label();
            this.lblCamarotesPremium = new System.Windows.Forms.Label();
            this.lblNombreCrucero = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbOpcionesFiltrado = new System.Windows.Forms.ComboBox();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.chkBoxFiltroPremium = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajerosDelViaje)).BeginInit();
            this.gboxCrucero.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPasajerosDelViaje
            // 
            this.dgvPasajerosDelViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajerosDelViaje.Location = new System.Drawing.Point(41, 64);
            this.dgvPasajerosDelViaje.Name = "dgvPasajerosDelViaje";
            this.dgvPasajerosDelViaje.ReadOnly = true;
            this.dgvPasajerosDelViaje.RowTemplate.Height = 25;
            this.dgvPasajerosDelViaje.Size = new System.Drawing.Size(766, 292);
            this.dgvPasajerosDelViaje.TabIndex = 0;
            // 
            // gboxCrucero
            // 
            this.gboxCrucero.BackColor = System.Drawing.Color.Transparent;
            this.gboxCrucero.Controls.Add(this.lblCamarotesTurista);
            this.gboxCrucero.Controls.Add(this.lblContieneCasino);
            this.gboxCrucero.Controls.Add(this.lblCapacidadBodega);
            this.gboxCrucero.Controls.Add(this.lblSalonesCrucero);
            this.gboxCrucero.Controls.Add(this.lblCamarotesPremium);
            this.gboxCrucero.Controls.Add(this.lblNombreCrucero);
            this.gboxCrucero.Location = new System.Drawing.Point(824, 64);
            this.gboxCrucero.Name = "gboxCrucero";
            this.gboxCrucero.Size = new System.Drawing.Size(214, 277);
            this.gboxCrucero.TabIndex = 1;
            this.gboxCrucero.TabStop = false;
            this.gboxCrucero.Text = "Crucero";
            // 
            // lblCamarotesTurista
            // 
            this.lblCamarotesTurista.AutoSize = true;
            this.lblCamarotesTurista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCamarotesTurista.Location = new System.Drawing.Point(25, 118);
            this.lblCamarotesTurista.Name = "lblCamarotesTurista";
            this.lblCamarotesTurista.Size = new System.Drawing.Size(105, 15);
            this.lblCamarotesTurista.TabIndex = 5;
            this.lblCamarotesTurista.Text = "Camarotes turista";
            // 
            // lblContieneCasino
            // 
            this.lblContieneCasino.AutoSize = true;
            this.lblContieneCasino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContieneCasino.Location = new System.Drawing.Point(25, 230);
            this.lblContieneCasino.Name = "lblContieneCasino";
            this.lblContieneCasino.Size = new System.Drawing.Size(99, 15);
            this.lblContieneCasino.TabIndex = 4;
            this.lblContieneCasino.Text = "Contiene casino?";
            // 
            // lblCapacidadBodega
            // 
            this.lblCapacidadBodega.AutoSize = true;
            this.lblCapacidadBodega.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapacidadBodega.Location = new System.Drawing.Point(25, 66);
            this.lblCapacidadBodega.Name = "lblCapacidadBodega";
            this.lblCapacidadBodega.Size = new System.Drawing.Size(107, 15);
            this.lblCapacidadBodega.TabIndex = 3;
            this.lblCapacidadBodega.Text = "Capacidad Bodega";
            // 
            // lblSalonesCrucero
            // 
            this.lblSalonesCrucero.AutoSize = true;
            this.lblSalonesCrucero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalonesCrucero.Location = new System.Drawing.Point(25, 162);
            this.lblSalonesCrucero.Name = "lblSalonesCrucero";
            this.lblSalonesCrucero.Size = new System.Drawing.Size(115, 15);
            this.lblSalonesCrucero.TabIndex = 2;
            this.lblSalonesCrucero.Text = "Salones del crucero";
            // 
            // lblCamarotesPremium
            // 
            this.lblCamarotesPremium.AutoSize = true;
            this.lblCamarotesPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCamarotesPremium.Location = new System.Drawing.Point(25, 92);
            this.lblCamarotesPremium.Name = "lblCamarotesPremium";
            this.lblCamarotesPremium.Size = new System.Drawing.Size(120, 15);
            this.lblCamarotesPremium.TabIndex = 1;
            this.lblCamarotesPremium.Text = "Camarotes premium";
            // 
            // lblNombreCrucero
            // 
            this.lblNombreCrucero.AutoSize = true;
            this.lblNombreCrucero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCrucero.Location = new System.Drawing.Point(25, 42);
            this.lblNombreCrucero.Name = "lblNombreCrucero";
            this.lblNombreCrucero.Size = new System.Drawing.Size(119, 15);
            this.lblNombreCrucero.TabIndex = 0;
            this.lblNombreCrucero.Text = "Nombre del crucero";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(41, 20);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 38);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(265, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(137, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.Visible = false;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbOpcionesFiltrado
            // 
            this.cmbOpcionesFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesFiltrado.FormattingEnabled = true;
            this.cmbOpcionesFiltrado.Location = new System.Drawing.Point(120, 35);
            this.cmbOpcionesFiltrado.Name = "cmbOpcionesFiltrado";
            this.cmbOpcionesFiltrado.Size = new System.Drawing.Size(121, 23);
            this.cmbOpcionesFiltrado.TabIndex = 4;
            this.cmbOpcionesFiltrado.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesFiltrado_SelectedIndexChanged);
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Location = new System.Drawing.Point(120, 17);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(61, 15);
            this.lblFiltrarPor.TabIndex = 5;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // chkBoxFiltroPremium
            // 
            this.chkBoxFiltroPremium.AutoSize = true;
            this.chkBoxFiltroPremium.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxFiltroPremium.Location = new System.Drawing.Point(437, 38);
            this.chkBoxFiltroPremium.Name = "chkBoxFiltroPremium";
            this.chkBoxFiltroPremium.Size = new System.Drawing.Size(106, 19);
            this.chkBoxFiltroPremium.TabIndex = 6;
            this.chkBoxFiltroPremium.Text = "Solo premiums";
            this.chkBoxFiltroPremium.UseVisualStyleBackColor = false;
            this.chkBoxFiltroPremium.CheckedChanged += new System.EventHandler(this.chkBoxFiltroPremium_CheckedChanged);
            // 
            // FrmInspeccionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.p11unuve_900;
            this.ClientSize = new System.Drawing.Size(1038, 447);
            this.Controls.Add(this.chkBoxFiltroPremium);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.cmbOpcionesFiltrado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gboxCrucero);
            this.Controls.Add(this.dgvPasajerosDelViaje);
            this.Name = "FrmInspeccionViaje";
            this.Text = "Inspeccion de viaje";
            this.Load += new System.EventHandler(this.FrmInspeccionViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajerosDelViaje)).EndInit();
            this.gboxCrucero.ResumeLayout(false);
            this.gboxCrucero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajerosDelViaje;
        private System.Windows.Forms.GroupBox gboxCrucero;
        private System.Windows.Forms.Label lblCamarotesPremium;
        private System.Windows.Forms.Label lblNombreCrucero;
        private System.Windows.Forms.Label lblCapacidadBodega;
        private System.Windows.Forms.Label lblSalonesCrucero;
        private System.Windows.Forms.Label lblContieneCasino;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblCamarotesTurista;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbOpcionesFiltrado;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.CheckBox chkBoxFiltroPremium;
    }
}