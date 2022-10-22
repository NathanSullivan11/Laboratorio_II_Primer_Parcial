
namespace Vista
{
    partial class FrmMenuPrincipal
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
            this.panel_BarraSuperior = new System.Windows.Forms.Panel();
            this.pbox_Maximizar = new System.Windows.Forms.PictureBox();
            this.pbox_Minimizar = new System.Windows.Forms.PictureBox();
            this.pbox_Cerrar = new System.Windows.Forms.PictureBox();
            this.pbox_Restaurar = new System.Windows.Forms.PictureBox();
            this.panel_Lateral = new System.Windows.Forms.Panel();
            this.panel_SubMenuEstadisticas = new System.Windows.Forms.Panel();
            this.btn_ReporteCruceros = new System.Windows.Forms.Button();
            this.btn_ReporteDestinos = new System.Windows.Forms.Button();
            this.btn_ViajesTotales = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbox_CerrarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btn_Viajes = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.panel_Central = new System.Windows.Forms.Panel();
            this.panel_BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Restaurar)).BeginInit();
            this.panel_Lateral.SuspendLayout();
            this.panel_SubMenuEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_CerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_BarraSuperior
            // 
            this.panel_BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel_BarraSuperior.Controls.Add(this.pbox_Maximizar);
            this.panel_BarraSuperior.Controls.Add(this.pbox_Minimizar);
            this.panel_BarraSuperior.Controls.Add(this.pbox_Cerrar);
            this.panel_BarraSuperior.Controls.Add(this.pbox_Restaurar);
            this.panel_BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panel_BarraSuperior.Name = "panel_BarraSuperior";
            this.panel_BarraSuperior.Size = new System.Drawing.Size(1166, 35);
            this.panel_BarraSuperior.TabIndex = 0;
            // 
            // pbox_Maximizar
            // 
            this.pbox_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Maximizar.Image = global::Vista.Properties.Resources.maximize__1_;
            this.pbox_Maximizar.Location = new System.Drawing.Point(1110, 4);
            this.pbox_Maximizar.Name = "pbox_Maximizar";
            this.pbox_Maximizar.Size = new System.Drawing.Size(25, 25);
            this.pbox_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Maximizar.TabIndex = 0;
            this.pbox_Maximizar.TabStop = false;
            this.pbox_Maximizar.Click += new System.EventHandler(this.pbox_Maximizar_Click);
            // 
            // pbox_Minimizar
            // 
            this.pbox_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Minimizar.Image = global::Vista.Properties.Resources.minus;
            this.pbox_Minimizar.Location = new System.Drawing.Point(1079, 4);
            this.pbox_Minimizar.Name = "pbox_Minimizar";
            this.pbox_Minimizar.Size = new System.Drawing.Size(25, 25);
            this.pbox_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Minimizar.TabIndex = 0;
            this.pbox_Minimizar.TabStop = false;
            this.pbox_Minimizar.Click += new System.EventHandler(this.pbox_Minimizar_Click);
            // 
            // pbox_Cerrar
            // 
            this.pbox_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Cerrar.Image = global::Vista.Properties.Resources.close;
            this.pbox_Cerrar.Location = new System.Drawing.Point(1141, 4);
            this.pbox_Cerrar.Name = "pbox_Cerrar";
            this.pbox_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.pbox_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Cerrar.TabIndex = 0;
            this.pbox_Cerrar.TabStop = false;
            this.pbox_Cerrar.Click += new System.EventHandler(this.pbox_Cerrar_Click);
            // 
            // pbox_Restaurar
            // 
            this.pbox_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Restaurar.Image = global::Vista.Properties.Resources.maximize;
            this.pbox_Restaurar.Location = new System.Drawing.Point(1110, 4);
            this.pbox_Restaurar.Name = "pbox_Restaurar";
            this.pbox_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.pbox_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Restaurar.TabIndex = 0;
            this.pbox_Restaurar.TabStop = false;
            this.pbox_Restaurar.Visible = false;
            this.pbox_Restaurar.Click += new System.EventHandler(this.pbox_Restaurar_Click);
            // 
            // panel_Lateral
            // 
            this.panel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_Lateral.Controls.Add(this.panel_SubMenuEstadisticas);
            this.panel_Lateral.Controls.Add(this.panel3);
            this.panel_Lateral.Controls.Add(this.panel2);
            this.panel_Lateral.Controls.Add(this.panel1);
            this.panel_Lateral.Controls.Add(this.pbox_CerrarSesion);
            this.panel_Lateral.Controls.Add(this.pictureBox1);
            this.panel_Lateral.Controls.Add(this.label3);
            this.panel_Lateral.Controls.Add(this.btn_Estadisticas);
            this.panel_Lateral.Controls.Add(this.btn_Viajes);
            this.panel_Lateral.Controls.Add(this.btn_Clientes);
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Lateral.Location = new System.Drawing.Point(0, 35);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(200, 634);
            this.panel_Lateral.TabIndex = 1;
            // 
            // panel_SubMenuEstadisticas
            // 
            this.panel_SubMenuEstadisticas.Controls.Add(this.btn_ReporteCruceros);
            this.panel_SubMenuEstadisticas.Controls.Add(this.btn_ReporteDestinos);
            this.panel_SubMenuEstadisticas.Controls.Add(this.btn_ViajesTotales);
            this.panel_SubMenuEstadisticas.Controls.Add(this.panel4);
            this.panel_SubMenuEstadisticas.Controls.Add(this.panel6);
            this.panel_SubMenuEstadisticas.Controls.Add(this.panel7);
            this.panel_SubMenuEstadisticas.Location = new System.Drawing.Point(21, 317);
            this.panel_SubMenuEstadisticas.Name = "panel_SubMenuEstadisticas";
            this.panel_SubMenuEstadisticas.Size = new System.Drawing.Size(181, 133);
            this.panel_SubMenuEstadisticas.TabIndex = 11;
            this.panel_SubMenuEstadisticas.Visible = false;
            // 
            // btn_ReporteCruceros
            // 
            this.btn_ReporteCruceros.FlatAppearance.BorderSize = 0;
            this.btn_ReporteCruceros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btn_ReporteCruceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReporteCruceros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ReporteCruceros.ForeColor = System.Drawing.Color.White;
            this.btn_ReporteCruceros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReporteCruceros.Location = new System.Drawing.Point(3, 89);
            this.btn_ReporteCruceros.Name = "btn_ReporteCruceros";
            this.btn_ReporteCruceros.Size = new System.Drawing.Size(173, 37);
            this.btn_ReporteCruceros.TabIndex = 1;
            this.btn_ReporteCruceros.Text = "Reporte cruceros";
            this.btn_ReporteCruceros.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteDestinos
            // 
            this.btn_ReporteDestinos.FlatAppearance.BorderSize = 0;
            this.btn_ReporteDestinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btn_ReporteDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReporteDestinos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ReporteDestinos.ForeColor = System.Drawing.Color.White;
            this.btn_ReporteDestinos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReporteDestinos.Location = new System.Drawing.Point(3, 46);
            this.btn_ReporteDestinos.Name = "btn_ReporteDestinos";
            this.btn_ReporteDestinos.Size = new System.Drawing.Size(175, 37);
            this.btn_ReporteDestinos.TabIndex = 1;
            this.btn_ReporteDestinos.Text = "Reporte destinos";
            this.btn_ReporteDestinos.UseVisualStyleBackColor = true;
            // 
            // btn_ViajesTotales
            // 
            this.btn_ViajesTotales.FlatAppearance.BorderSize = 0;
            this.btn_ViajesTotales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btn_ViajesTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViajesTotales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ViajesTotales.ForeColor = System.Drawing.Color.White;
            this.btn_ViajesTotales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViajesTotales.Location = new System.Drawing.Point(3, 3);
            this.btn_ViajesTotales.Name = "btn_ViajesTotales";
            this.btn_ViajesTotales.Size = new System.Drawing.Size(175, 37);
            this.btn_ViajesTotales.TabIndex = 1;
            this.btn_ViajesTotales.Text = "Viajes totales";
            this.btn_ViajesTotales.UseVisualStyleBackColor = true;
            this.btn_ViajesTotales.Click += new System.EventHandler(this.btn_ViajesTotales_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel4.Location = new System.Drawing.Point(-2, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 37);
            this.panel4.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 37);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel7.Location = new System.Drawing.Point(0, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 37);
            this.panel7.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 37);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel2.Location = new System.Drawing.Point(1, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 37);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(0, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 37);
            this.panel1.TabIndex = 10;
            // 
            // pbox_CerrarSesion
            // 
            this.pbox_CerrarSesion.Image = global::Vista.Properties.Resources.stand_by__1_;
            this.pbox_CerrarSesion.Location = new System.Drawing.Point(12, 583);
            this.pbox_CerrarSesion.Name = "pbox_CerrarSesion";
            this.pbox_CerrarSesion.Size = new System.Drawing.Size(50, 39);
            this.pbox_CerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_CerrarSesion.TabIndex = 1;
            this.pbox_CerrarSesion.TabStop = false;
            this.pbox_CerrarSesion.Click += new System.EventHandler(this.pbox_CerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.Costa_logo_20211;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(1, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sistema de gestión";
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_Estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_Estadisticas.Image = global::Vista.Properties.Resources.graph;
            this.btn_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estadisticas.Location = new System.Drawing.Point(3, 274);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(197, 37);
            this.btn_Estadisticas.TabIndex = 1;
            this.btn_Estadisticas.Text = "Estadísticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = true;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btn_Viajes
            // 
            this.btn_Viajes.FlatAppearance.BorderSize = 0;
            this.btn_Viajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btn_Viajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Viajes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Viajes.ForeColor = System.Drawing.Color.White;
            this.btn_Viajes.Image = global::Vista.Properties.Resources.cruise_ship__4_;
            this.btn_Viajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Viajes.Location = new System.Drawing.Point(3, 188);
            this.btn_Viajes.Name = "btn_Viajes";
            this.btn_Viajes.Size = new System.Drawing.Size(199, 37);
            this.btn_Viajes.TabIndex = 1;
            this.btn_Viajes.Text = "Viajes";
            this.btn_Viajes.UseVisualStyleBackColor = true;
            this.btn_Viajes.Click += new System.EventHandler(this.btn_Viajes_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Clientes.ForeColor = System.Drawing.Color.White;
            this.btn_Clientes.Image = global::Vista.Properties.Resources.audience;
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.Location = new System.Drawing.Point(4, 231);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(196, 37);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // panel_Central
            // 
            this.panel_Central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Central.Location = new System.Drawing.Point(200, 35);
            this.panel_Central.Name = "panel_Central";
            this.panel_Central.Size = new System.Drawing.Size(966, 634);
            this.panel_Central.TabIndex = 2;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1166, 669);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Central);
            this.Controls.Add(this.panel_Lateral);
            this.Controls.Add(this.panel_BarraSuperior);
            this.MinimumSize = new System.Drawing.Size(1182, 685);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.panel_BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Restaurar)).EndInit();
            this.panel_Lateral.ResumeLayout(false);
            this.panel_Lateral.PerformLayout();
            this.panel_SubMenuEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_CerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_BarraSuperior;
        private System.Windows.Forms.PictureBox pbox_Maximizar;
        private System.Windows.Forms.PictureBox pbox_Minimizar;
        private System.Windows.Forms.PictureBox pbox_Cerrar;
        private System.Windows.Forms.PictureBox pbox_Restaurar;
        private System.Windows.Forms.Panel panel_Lateral;
        private System.Windows.Forms.Panel panel_Central;
        private System.Windows.Forms.Button btn_Viajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Panel panel_SubMenuEstadisticas;
        private System.Windows.Forms.Button btn_ReporteDestinos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_ViajesTotales;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ReporteCruceros;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbox_CerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}