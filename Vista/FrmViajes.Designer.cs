
namespace Vista
{
    partial class FrmViajes
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
            this.tableLayoutPanel_ContenedorPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ContenedorBotones = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesActivos)).BeginInit();
            this.tableLayoutPanel_ContenedorPrincipal.SuspendLayout();
            this.tableLayoutPanel_ContenedorBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViajesActivos
            // 
            this.dgvViajesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViajesActivos.Location = new System.Drawing.Point(3, 76);
            this.dgvViajesActivos.Name = "dgvViajesActivos";
            this.dgvViajesActivos.ReadOnly = true;
            this.dgvViajesActivos.RowTemplate.Height = 25;
            this.dgvViajesActivos.Size = new System.Drawing.Size(789, 511);
            this.dgvViajesActivos.TabIndex = 0;
            // 
            // btnInspeccionarViaje
            // 
            this.btnInspeccionarViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInspeccionarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnInspeccionarViaje.CausesValidation = false;
            this.btnInspeccionarViaje.FlatAppearance.BorderSize = 0;
            this.btnInspeccionarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccionarViaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInspeccionarViaje.ForeColor = System.Drawing.Color.White;
            this.btnInspeccionarViaje.Location = new System.Drawing.Point(15, 13);
            this.btnInspeccionarViaje.Name = "btnInspeccionarViaje";
            this.btnInspeccionarViaje.Size = new System.Drawing.Size(166, 41);
            this.btnInspeccionarViaje.TabIndex = 1;
            this.btnInspeccionarViaje.Text = "Listar pasajeros";
            this.btnInspeccionarViaje.UseVisualStyleBackColor = false;
            this.btnInspeccionarViaje.Click += new System.EventHandler(this.btnInspeccionarViaje_Click);
            // 
            // btnVenderPasaje
            // 
            this.btnVenderPasaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVenderPasaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnVenderPasaje.CausesValidation = false;
            this.btnVenderPasaje.FlatAppearance.BorderSize = 0;
            this.btnVenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderPasaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderPasaje.ForeColor = System.Drawing.Color.White;
            this.btnVenderPasaje.Location = new System.Drawing.Point(212, 13);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(166, 41);
            this.btnVenderPasaje.TabIndex = 2;
            this.btnVenderPasaje.Text = "Vender pasaje";
            this.btnVenderPasaje.UseVisualStyleBackColor = false;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // btnAltaViaje
            // 
            this.btnAltaViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnAltaViaje.CausesValidation = false;
            this.btnAltaViaje.FlatAppearance.BorderSize = 0;
            this.btnAltaViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaViaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaViaje.ForeColor = System.Drawing.Color.White;
            this.btnAltaViaje.Location = new System.Drawing.Point(409, 13);
            this.btnAltaViaje.Name = "btnAltaViaje";
            this.btnAltaViaje.Size = new System.Drawing.Size(166, 41);
            this.btnAltaViaje.TabIndex = 3;
            this.btnAltaViaje.Text = "Agregar viaje";
            this.btnAltaViaje.UseVisualStyleBackColor = false;
            this.btnAltaViaje.Click += new System.EventHandler(this.btnAltaViaje_Click);
            // 
            // btnBajaViaje
            // 
            this.btnBajaViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBajaViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnBajaViaje.CausesValidation = false;
            this.btnBajaViaje.FlatAppearance.BorderSize = 0;
            this.btnBajaViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaViaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBajaViaje.ForeColor = System.Drawing.Color.White;
            this.btnBajaViaje.Location = new System.Drawing.Point(607, 13);
            this.btnBajaViaje.Name = "btnBajaViaje";
            this.btnBajaViaje.Size = new System.Drawing.Size(166, 41);
            this.btnBajaViaje.TabIndex = 5;
            this.btnBajaViaje.Text = "Bajar viaje";
            this.btnBajaViaje.UseVisualStyleBackColor = false;
            this.btnBajaViaje.Click += new System.EventHandler(this.btnBajaViaje_Click);
            // 
            // tableLayoutPanel_ContenedorPrincipal
            // 
            this.tableLayoutPanel_ContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel_ContenedorPrincipal.ColumnCount = 1;
            this.tableLayoutPanel_ContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorPrincipal.Controls.Add(this.tableLayoutPanel_ContenedorBotones, 0, 0);
            this.tableLayoutPanel_ContenedorPrincipal.Controls.Add(this.dgvViajesActivos, 0, 1);
            this.tableLayoutPanel_ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ContenedorPrincipal.Name = "tableLayoutPanel_ContenedorPrincipal";
            this.tableLayoutPanel_ContenedorPrincipal.RowCount = 2;
            this.tableLayoutPanel_ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50643F));
            this.tableLayoutPanel_ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.49357F));
            this.tableLayoutPanel_ContenedorPrincipal.Size = new System.Drawing.Size(795, 590);
            this.tableLayoutPanel_ContenedorPrincipal.TabIndex = 7;
            // 
            // tableLayoutPanel_ContenedorBotones
            // 
            this.tableLayoutPanel_ContenedorBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel_ContenedorBotones.ColumnCount = 4;
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.btnInspeccionarViaje, 0, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.btnBajaViaje, 3, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.btnVenderPasaje, 1, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.btnAltaViaje, 2, 0);
            this.tableLayoutPanel_ContenedorBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorBotones.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ContenedorBotones.Name = "tableLayoutPanel_ContenedorBotones";
            this.tableLayoutPanel_ContenedorBotones.RowCount = 1;
            this.tableLayoutPanel_ContenedorBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorBotones.Size = new System.Drawing.Size(789, 67);
            this.tableLayoutPanel_ContenedorBotones.TabIndex = 8;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 590);
            this.Controls.Add(this.tableLayoutPanel_ContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmViajes";
            this.Text = "FrmViajes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesActivos)).EndInit();
            this.tableLayoutPanel_ContenedorPrincipal.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorBotones.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.DataGridView dgvViajesActivos;
        private System.Windows.Forms.Button btnInspeccionarViaje;
        private System.Windows.Forms.Button btnVenderPasaje;
        private System.Windows.Forms.Button btnAltaViaje;
        private System.Windows.Forms.Button btnBajaViaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorBotones;
    }

}

        
    
