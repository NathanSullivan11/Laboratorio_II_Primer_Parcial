
namespace Vista
{
    partial class FrmBajaViaje
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
            this.SuspendLayout();
            // 
            // cmbCrucero
            // 
            this.cmbCrucero.Enabled = false;
            this.cmbCrucero.Location = new System.Drawing.Point(51, 18);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Enabled = false;
            this.cmbOrigen.Location = new System.Drawing.Point(51, 20);
            // 
            // cmbDestino
            // 

            this.cmbDestino.Enabled = false;

            this.cmbDestino.Location = new System.Drawing.Point(51, 27);
            // 
            // rbtnRegional
            // 
            this.rbtnRegional.Checked = true;
            this.rbtnRegional.Location = new System.Drawing.Point(32, 27);
            this.rbtnRegional.Visible = false;
            // 
            // rbtnExtraregional
            // 
            this.rbtnExtraregional.Location = new System.Drawing.Point(144, 27);
            this.rbtnExtraregional.TabStop = false;
            this.rbtnExtraregional.Visible = false;
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarViaje.Location = new System.Drawing.Point(32, 17);
            this.btnAgregarViaje.Text = "Dar de baja";
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // lblSeleccionarOrigen
            // 
            this.lblSeleccionarOrigen.Location = new System.Drawing.Point(53, 3);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(144, 17);
            // 
            // lblSeleccionarCrucero
            // 
            this.lblSeleccionarCrucero.Location = new System.Drawing.Point(53, 1);
            // 
            // lblSeleccionarDestino
            // 
            this.lblSeleccionarDestino.Location = new System.Drawing.Point(58, 183);
            // 
            // dateTimePicker1
            // 
            this.dtp_FechaSalida.Enabled = false;
            this.dtp_FechaSalida.Location = new System.Drawing.Point(53, 21);
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.Location = new System.Drawing.Point(53, 3);
            // 
            // FrmBajaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 341);
            this.Name = "FrmBajaViaje";
            this.Text = "Bajar viaje";
            this.Load += new System.EventHandler(this.FrmBajaViaje_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}