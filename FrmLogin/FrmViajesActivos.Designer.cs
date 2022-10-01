
namespace Vista
{
    partial class FrmViajesActivos
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
            this.dgvViajesActivos = new System.Windows.Forms.DataGridView();
            this.btnInspeccionarViaje = new System.Windows.Forms.Button();
            this.btnVenderPasaje = new System.Windows.Forms.Button();
            this.btnAltaViaje = new System.Windows.Forms.Button();
            this.btnBajaViaje = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViajesActivos
            // 
            this.dgvViajesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesActivos.Location = new System.Drawing.Point(74, 87);
            this.dgvViajesActivos.Name = "dgvViajesActivos";
            this.dgvViajesActivos.ReadOnly = true;
            this.dgvViajesActivos.RowTemplate.Height = 25;
            this.dgvViajesActivos.Size = new System.Drawing.Size(640, 317);
            this.dgvViajesActivos.TabIndex = 0;
            this.dgvViajesActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajesActivos_CellContentClick);
            // 
            // btnInspeccionarViaje
            // 
            this.btnInspeccionarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccionarViaje.Location = new System.Drawing.Point(74, 21);
            this.btnInspeccionarViaje.Name = "btnInspeccionarViaje";
            this.btnInspeccionarViaje.Size = new System.Drawing.Size(259, 45);
            this.btnInspeccionarViaje.TabIndex = 1;
            this.btnInspeccionarViaje.Text = "Inspeccionar vuelo";
            this.btnInspeccionarViaje.UseVisualStyleBackColor = true;
            this.btnInspeccionarViaje.Click += new System.EventHandler(this.btnInspeccionarViaje_Click);
            // 
            // btnVenderPasaje
            // 
            this.btnVenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderPasaje.Location = new System.Drawing.Point(444, 21);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(259, 45);
            this.btnVenderPasaje.TabIndex = 2;
            this.btnVenderPasaje.Text = "Vender un pasaje";
            this.btnVenderPasaje.UseVisualStyleBackColor = true;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // btnAltaViaje
            // 
            this.btnAltaViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaViaje.Location = new System.Drawing.Point(74, 421);
            this.btnAltaViaje.Name = "btnAltaViaje";
            this.btnAltaViaje.Size = new System.Drawing.Size(166, 41);
            this.btnAltaViaje.TabIndex = 3;
            this.btnAltaViaje.Text = "Agregar un viaje";
            this.btnAltaViaje.UseVisualStyleBackColor = true;
            this.btnAltaViaje.Click += new System.EventHandler(this.btnAltaViaje_Click);
            // 
            // btnBajaViaje
            // 
            this.btnBajaViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaViaje.Location = new System.Drawing.Point(548, 421);
            this.btnBajaViaje.Name = "btnBajaViaje";
            this.btnBajaViaje.Size = new System.Drawing.Size(166, 41);
            this.btnBajaViaje.TabIndex = 5;
            this.btnBajaViaje.Text = "Dar de baja";
            this.btnBajaViaje.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(12, 21);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(43, 44);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmViajesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Vista.Properties.Resources._0f2410d5b280aa56ee383b756f574cdc;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBajaViaje);
            this.Controls.Add(this.btnAltaViaje);
            this.Controls.Add(this.btnVenderPasaje);
            this.Controls.Add(this.btnInspeccionarViaje);
            this.Controls.Add(this.dgvViajesActivos);
            this.Name = "FrmViajesActivos";
            this.Text = "FrmViajesActivos";
            this.Load += new System.EventHandler(this.FrmViajesActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViajesActivos;
        private System.Windows.Forms.Button btnInspeccionarViaje;
        private System.Windows.Forms.Button btnVenderPasaje;
        private System.Windows.Forms.Button btnAltaViaje;
        private System.Windows.Forms.Button btnBajaViaje;
        private System.Windows.Forms.Button btnRegresar;
    }
}