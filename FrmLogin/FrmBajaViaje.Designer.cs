
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaViaje));
            this.SuspendLayout();
            // 
            // cmbCrucero
            // 
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DataSource = null;
            // 
            // cmbDestino
            // 
            this.cmbDestino.Location = new System.Drawing.Point(50, 193);
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // lblSeleccionarDestino
            // 
            this.lblSeleccionarDestino.Location = new System.Drawing.Point(50, 175);
            // 
            // FrmBajaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 341);
            this.Name = "FrmBajaViaje";
            this.Text = "Baja de un viaje";
            this.Load += new System.EventHandler(this.FrmBajaViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}