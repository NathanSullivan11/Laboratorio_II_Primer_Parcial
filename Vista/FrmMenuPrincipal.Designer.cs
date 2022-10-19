
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
            this.panel_Central = new System.Windows.Forms.Panel();
            this.panel_BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Restaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_BarraSuperior
            // 
            this.panel_BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(184)))));
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
            this.panel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(41)))));
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Lateral.Location = new System.Drawing.Point(0, 35);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(200, 634);
            this.panel_Lateral.TabIndex = 1;
            // 
            // panel_Central
            // 
            this.panel_Central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(137)))), ((int)(((byte)(132)))));
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
            this.panel_BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Restaurar)).EndInit();
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
    }
}