
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
            this.lblContieneCasino = new System.Windows.Forms.Label();
            this.lblCapacidadBodega = new System.Windows.Forms.Label();
            this.lblSalonesCrucero = new System.Windows.Forms.Label();
            this.lblCamarotesPremium = new System.Windows.Forms.Label();
            this.lblNombreCrucero = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblCamarotesTurista = new System.Windows.Forms.Label();
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
            this.dgvPasajerosDelViaje.Size = new System.Drawing.Size(545, 292);
            this.dgvPasajerosDelViaje.TabIndex = 0;
            // 
            // gboxCrucero
            // 
            this.gboxCrucero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboxCrucero.Controls.Add(this.lblCamarotesTurista);
            this.gboxCrucero.Controls.Add(this.lblContieneCasino);
            this.gboxCrucero.Controls.Add(this.lblCapacidadBodega);
            this.gboxCrucero.Controls.Add(this.lblSalonesCrucero);
            this.gboxCrucero.Controls.Add(this.lblCamarotesPremium);
            this.gboxCrucero.Controls.Add(this.lblNombreCrucero);
            this.gboxCrucero.Location = new System.Drawing.Point(632, 64);
            this.gboxCrucero.Name = "gboxCrucero";
            this.gboxCrucero.Size = new System.Drawing.Size(214, 277);
            this.gboxCrucero.TabIndex = 1;
            this.gboxCrucero.TabStop = false;
            this.gboxCrucero.Text = "Crucero";
            // 
            // lblContieneCasino
            // 
            this.lblContieneCasino.AutoSize = true;
            this.lblContieneCasino.Location = new System.Drawing.Point(25, 230);
            this.lblContieneCasino.Name = "lblContieneCasino";
            this.lblContieneCasino.Size = new System.Drawing.Size(97, 15);
            this.lblContieneCasino.TabIndex = 4;
            this.lblContieneCasino.Text = "Contiene casino?";
            // 
            // lblCapacidadBodega
            // 
            this.lblCapacidadBodega.AutoSize = true;
            this.lblCapacidadBodega.Location = new System.Drawing.Point(25, 66);
            this.lblCapacidadBodega.Name = "lblCapacidadBodega";
            this.lblCapacidadBodega.Size = new System.Drawing.Size(106, 15);
            this.lblCapacidadBodega.TabIndex = 3;
            this.lblCapacidadBodega.Text = "Capacidad Bodega";
            // 
            // lblSalonesCrucero
            // 
            this.lblSalonesCrucero.AutoSize = true;
            this.lblSalonesCrucero.Location = new System.Drawing.Point(25, 162);
            this.lblSalonesCrucero.Name = "lblSalonesCrucero";
            this.lblSalonesCrucero.Size = new System.Drawing.Size(109, 15);
            this.lblSalonesCrucero.TabIndex = 2;
            this.lblSalonesCrucero.Text = "Salones del crucero";
            // 
            // lblCamarotesPremium
            // 
            this.lblCamarotesPremium.AutoSize = true;
            this.lblCamarotesPremium.Location = new System.Drawing.Point(25, 92);
            this.lblCamarotesPremium.Name = "lblCamarotesPremium";
            this.lblCamarotesPremium.Size = new System.Drawing.Size(116, 15);
            this.lblCamarotesPremium.TabIndex = 1;
            this.lblCamarotesPremium.Text = "Camarotes premium";
            // 
            // lblNombreCrucero
            // 
            this.lblNombreCrucero.AutoSize = true;
            this.lblNombreCrucero.Location = new System.Drawing.Point(25, 42);
            this.lblNombreCrucero.Name = "lblNombreCrucero";
            this.lblNombreCrucero.Size = new System.Drawing.Size(113, 15);
            this.lblNombreCrucero.TabIndex = 0;
            this.lblNombreCrucero.Text = "Nombre del crucero";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(41, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 36);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblCamarotesTurista
            // 
            this.lblCamarotesTurista.AutoSize = true;
            this.lblCamarotesTurista.Location = new System.Drawing.Point(25, 118);
            this.lblCamarotesTurista.Name = "lblCamarotesTurista";
            this.lblCamarotesTurista.Size = new System.Drawing.Size(100, 15);
            this.lblCamarotesTurista.TabIndex = 5;
            this.lblCamarotesTurista.Text = "Camarotes turista";
            // 
            // FrmInspeccionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.p11unuve_900;
            this.ClientSize = new System.Drawing.Size(871, 379);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gboxCrucero);
            this.Controls.Add(this.dgvPasajerosDelViaje);
            this.Name = "FrmInspeccionViaje";
            this.Text = "FrmInspeccionViaje";
            this.Load += new System.EventHandler(this.FrmInspeccionViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajerosDelViaje)).EndInit();
            this.gboxCrucero.ResumeLayout(false);
            this.gboxCrucero.PerformLayout();
            this.ResumeLayout(false);

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
    }
}