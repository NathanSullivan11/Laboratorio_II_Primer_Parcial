
namespace Vista
{
    partial class FrmAltaViaje
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
            this.cmbCrucero = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.rbtnRegional = new System.Windows.Forms.RadioButton();
            this.rbtnExtraregional = new System.Windows.Forms.RadioButton();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.lblSeleccionarOrigen = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSeleccionarCrucero = new System.Windows.Forms.Label();
            this.lblSeleccionarDestino = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCrucero
            // 
            this.cmbCrucero.FormattingEnabled = true;
            this.cmbCrucero.Location = new System.Drawing.Point(50, 27);
            this.cmbCrucero.Name = "cmbCrucero";
            this.cmbCrucero.Size = new System.Drawing.Size(161, 23);
            this.cmbCrucero.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(50, 139);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(161, 23);
            this.cmbOrigen.TabIndex = 1;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(50, 218);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(161, 23);
            this.cmbDestino.TabIndex = 2;
            // 
            // rbtnRegional
            // 
            this.rbtnRegional.AutoSize = true;
            this.rbtnRegional.BackColor = System.Drawing.Color.Transparent;
            this.rbtnRegional.Location = new System.Drawing.Point(29, 193);
            this.rbtnRegional.Name = "rbtnRegional";
            this.rbtnRegional.Size = new System.Drawing.Size(71, 19);
            this.rbtnRegional.TabIndex = 3;
            this.rbtnRegional.TabStop = true;
            this.rbtnRegional.Text = "Regional";
            this.rbtnRegional.UseVisualStyleBackColor = false;
            this.rbtnRegional.CheckedChanged += new System.EventHandler(this.rbtnRegional_CheckedChanged);
            // 
            // rbtnExtraregional
            // 
            this.rbtnExtraregional.AutoSize = true;
            this.rbtnExtraregional.BackColor = System.Drawing.Color.Transparent;
            this.rbtnExtraregional.Location = new System.Drawing.Point(141, 193);
            this.rbtnExtraregional.Name = "rbtnExtraregional";
            this.rbtnExtraregional.Size = new System.Drawing.Size(94, 19);
            this.rbtnExtraregional.TabIndex = 4;
            this.rbtnExtraregional.TabStop = true;
            this.rbtnExtraregional.Text = "Extraregional";
            this.rbtnExtraregional.UseVisualStyleBackColor = false;
            this.rbtnExtraregional.CheckedChanged += new System.EventHandler(this.rbtnExtraregional_CheckedChanged);
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarViaje.Location = new System.Drawing.Point(29, 265);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(88, 35);
            this.btnAgregarViaje.TabIndex = 5;
            this.btnAgregarViaje.Text = "Agregar viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = false;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // lblSeleccionarOrigen
            // 
            this.lblSeleccionarOrigen.AutoSize = true;
            this.lblSeleccionarOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarOrigen.Location = new System.Drawing.Point(50, 121);
            this.lblSeleccionarOrigen.Name = "lblSeleccionarOrigen";
            this.lblSeleccionarOrigen.Size = new System.Drawing.Size(43, 15);
            this.lblSeleccionarOrigen.TabIndex = 7;
            this.lblSeleccionarOrigen.Text = "Origen";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(141, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSeleccionarCrucero
            // 
            this.lblSeleccionarCrucero.AutoSize = true;
            this.lblSeleccionarCrucero.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarCrucero.Location = new System.Drawing.Point(50, 9);
            this.lblSeleccionarCrucero.Name = "lblSeleccionarCrucero";
            this.lblSeleccionarCrucero.Size = new System.Drawing.Size(49, 15);
            this.lblSeleccionarCrucero.TabIndex = 6;
            this.lblSeleccionarCrucero.Text = "Crucero";
            // 
            // lblSeleccionarDestino
            // 
            this.lblSeleccionarDestino.AutoSize = true;
            this.lblSeleccionarDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarDestino.Location = new System.Drawing.Point(106, 175);
            this.lblSeleccionarDestino.Name = "lblSeleccionarDestino";
            this.lblSeleccionarDestino.Size = new System.Drawing.Size(47, 15);
            this.lblSeleccionarDestino.TabIndex = 9;
            this.lblSeleccionarDestino.Text = "Destino";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaSalida.Location = new System.Drawing.Point(50, 61);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(71, 15);
            this.lblFechaSalida.TabIndex = 11;
            this.lblFechaSalida.Text = "Fecha salida";
            // 
            // FrmAltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.dibujos_animados_paisajes_mar_montana_18591_48791;
            this.ClientSize = new System.Drawing.Size(272, 327);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSeleccionarDestino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSeleccionarOrigen);
            this.Controls.Add(this.lblSeleccionarCrucero);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.rbtnExtraregional);
            this.Controls.Add(this.rbtnRegional);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.cmbCrucero);
            this.Name = "FrmAltaViaje";
            this.Text = "FrmAltaPasaje";
            this.Load += new System.EventHandler(this.FrmAltaViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox cmbCrucero;
        protected System.Windows.Forms.ComboBox cmbOrigen;
        protected System.Windows.Forms.ComboBox cmbDestino;
        protected System.Windows.Forms.RadioButton rbtnRegional;
        protected System.Windows.Forms.RadioButton rbtnExtraregional;
        protected System.Windows.Forms.Button btnAgregarViaje;
        protected System.Windows.Forms.Label lblSeleccionarOrigen;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Label lblSeleccionarCrucero;
        protected System.Windows.Forms.Label lblSeleccionarDestino;
        protected System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.Label lblFechaSalida;
    }
}