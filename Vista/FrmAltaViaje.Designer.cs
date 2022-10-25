
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
            this.dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCrucero
            // 
            this.cmbCrucero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCrucero.FormattingEnabled = true;
            this.cmbCrucero.Location = new System.Drawing.Point(45, 15);
            this.cmbCrucero.MaximumSize = new System.Drawing.Size(161, 0);
            this.cmbCrucero.Name = "cmbCrucero";
            this.cmbCrucero.Size = new System.Drawing.Size(161, 23);
            this.cmbCrucero.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(45, 17);
            this.cmbOrigen.MaximumSize = new System.Drawing.Size(161, 0);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(161, 23);
            this.cmbOrigen.TabIndex = 1;
            // 
            // cmbDestino
            // 
            this.cmbDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(45, 44);
            this.cmbDestino.MaximumSize = new System.Drawing.Size(161, 0);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(161, 23);
            this.cmbDestino.TabIndex = 2;
            // 
            // rbtnRegional
            // 
            this.rbtnRegional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnRegional.AutoSize = true;
            this.rbtnRegional.BackColor = System.Drawing.Color.Transparent;
            this.rbtnRegional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnRegional.ForeColor = System.Drawing.Color.White;
            this.rbtnRegional.Location = new System.Drawing.Point(24, 19);
            this.rbtnRegional.Name = "rbtnRegional";
            this.rbtnRegional.Size = new System.Drawing.Size(83, 20);
            this.rbtnRegional.TabIndex = 3;
            this.rbtnRegional.TabStop = true;
            this.rbtnRegional.Text = "Regional";
            this.rbtnRegional.UseVisualStyleBackColor = false;
            this.rbtnRegional.CheckedChanged += new System.EventHandler(this.rbtnRegional_CheckedChanged);
            // 
            // rbtnExtraregional
            // 
            this.rbtnExtraregional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnExtraregional.AutoSize = true;
            this.rbtnExtraregional.BackColor = System.Drawing.Color.Transparent;
            this.rbtnExtraregional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnExtraregional.ForeColor = System.Drawing.Color.White;
            this.rbtnExtraregional.Location = new System.Drawing.Point(136, 19);
            this.rbtnExtraregional.Name = "rbtnExtraregional";
            this.rbtnExtraregional.Size = new System.Drawing.Size(112, 20);
            this.rbtnExtraregional.TabIndex = 4;
            this.rbtnExtraregional.TabStop = true;
            this.rbtnExtraregional.Text = "Extraregional";
            this.rbtnExtraregional.UseVisualStyleBackColor = false;
            this.rbtnExtraregional.CheckedChanged += new System.EventHandler(this.rbtnExtraregional_CheckedChanged);
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnAgregarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarViaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarViaje.ForeColor = System.Drawing.Color.White;
            this.btnAgregarViaje.Location = new System.Drawing.Point(24, 13);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(88, 35);
            this.btnAgregarViaje.TabIndex = 5;
            this.btnAgregarViaje.Text = "Agregar";
            this.btnAgregarViaje.UseVisualStyleBackColor = false;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // lblSeleccionarOrigen
            // 
            this.lblSeleccionarOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeleccionarOrigen.AutoSize = true;
            this.lblSeleccionarOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarOrigen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarOrigen.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarOrigen.Location = new System.Drawing.Point(45, -1);
            this.lblSeleccionarOrigen.Name = "lblSeleccionarOrigen";
            this.lblSeleccionarOrigen.Size = new System.Drawing.Size(52, 16);
            this.lblSeleccionarOrigen.TabIndex = 7;
            this.lblSeleccionarOrigen.Text = "Origen";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(136, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSeleccionarCrucero
            // 
            this.lblSeleccionarCrucero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeleccionarCrucero.AutoSize = true;
            this.lblSeleccionarCrucero.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarCrucero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarCrucero.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarCrucero.Location = new System.Drawing.Point(45, -3);
            this.lblSeleccionarCrucero.Name = "lblSeleccionarCrucero";
            this.lblSeleccionarCrucero.Size = new System.Drawing.Size(59, 16);
            this.lblSeleccionarCrucero.TabIndex = 6;
            this.lblSeleccionarCrucero.Text = "Crucero";
            // 
            // lblSeleccionarDestino
            // 
            this.lblSeleccionarDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeleccionarDestino.AutoSize = true;
            this.lblSeleccionarDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarDestino.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarDestino.Location = new System.Drawing.Point(101, 1);
            this.lblSeleccionarDestino.Name = "lblSeleccionarDestino";
            this.lblSeleccionarDestino.Size = new System.Drawing.Size(54, 16);
            this.lblSeleccionarDestino.TabIndex = 9;
            this.lblSeleccionarDestino.Text = "Destino";
            // 
            // dtp_FechaSalida
            // 
            this.dtp_FechaSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_FechaSalida.Location = new System.Drawing.Point(45, 17);
            this.dtp_FechaSalida.MaximumSize = new System.Drawing.Size(161, 23);
            this.dtp_FechaSalida.Name = "dtp_FechaSalida";
            this.dtp_FechaSalida.Size = new System.Drawing.Size(161, 23);
            this.dtp_FechaSalida.TabIndex = 10;
            this.dtp_FechaSalida.MinDate = System.DateTime.Today;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaSalida.ForeColor = System.Drawing.Color.White;
            this.lblFechaSalida.Location = new System.Drawing.Point(45, -1);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(91, 16);
            this.lblFechaSalida.TabIndex = 11;
            this.lblFechaSalida.Text = "Fecha salida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCrucero);
            this.panel1.Controls.Add(this.lblSeleccionarCrucero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 52);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFechaSalida);
            this.panel2.Controls.Add(this.dtp_FechaSalida);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 52);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnRegional);
            this.panel3.Controls.Add(this.cmbDestino);
            this.panel3.Controls.Add(this.rbtnExtraregional);
            this.panel3.Controls.Add(this.lblSeleccionarDestino);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 69);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSeleccionarOrigen);
            this.panel4.Controls.Add(this.cmbOrigen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 52);
            this.panel4.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 327);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnAgregarViaje);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 72);
            this.panel5.TabIndex = 17;
            // 
            // FrmAltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(272, 327);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(288, 366);
            this.Name = "FrmAltaViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de viaje";
            this.Load += new System.EventHandler(this.FrmAltaViaje_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

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
        protected System.Windows.Forms.DateTimePicker dtp_FechaSalida;
        protected System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
    }
}