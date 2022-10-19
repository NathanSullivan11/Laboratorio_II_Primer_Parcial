
namespace Vista
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbox_Logo = new System.Windows.Forms.PictureBox();
            this.pbox_Usuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbox_Password = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Autocompletar = new System.Windows.Forms.Label();
            this.lbl_Salir = new System.Windows.Forms.Label();
            this.tbox_Usuario = new System.Windows.Forms.TextBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Logo
            // 
            this.pbox_Logo.Image = global::Vista.Properties.Resources.cruise_ship_logo_template_vector_icon_design_cruise_ship_logo_template_134894227;
            this.pbox_Logo.Location = new System.Drawing.Point(-2, 0);
            this.pbox_Logo.Name = "pbox_Logo";
            this.pbox_Logo.Size = new System.Drawing.Size(301, 158);
            this.pbox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Logo.TabIndex = 0;
            this.pbox_Logo.TabStop = false;
            // 
            // pbox_Usuario
            // 
            this.pbox_Usuario.Image = global::Vista.Properties.Resources.user;
            this.pbox_Usuario.Location = new System.Drawing.Point(29, 208);
            this.pbox_Usuario.Name = "pbox_Usuario";
            this.pbox_Usuario.Size = new System.Drawing.Size(18, 17);
            this.pbox_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Usuario.TabIndex = 2;
            this.pbox_Usuario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.panel1.Location = new System.Drawing.Point(29, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 1);
            this.panel1.TabIndex = 3;
            // 
            // pbox_Password
            // 
            this.pbox_Password.Image = global::Vista.Properties.Resources.padlock__1_;
            this.pbox_Password.Location = new System.Drawing.Point(29, 272);
            this.pbox_Password.Name = "pbox_Password";
            this.pbox_Password.Size = new System.Drawing.Size(18, 17);
            this.pbox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Password.TabIndex = 2;
            this.pbox_Password.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.panel2.Location = new System.Drawing.Point(29, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 1);
            this.panel2.TabIndex = 3;
            // 
            // lbl_Autocompletar
            // 
            this.lbl_Autocompletar.AutoSize = true;
            this.lbl_Autocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Autocompletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Autocompletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.lbl_Autocompletar.Location = new System.Drawing.Point(155, 319);
            this.lbl_Autocompletar.Name = "lbl_Autocompletar";
            this.lbl_Autocompletar.Size = new System.Drawing.Size(107, 16);
            this.lbl_Autocompletar.TabIndex = 5;
            this.lbl_Autocompletar.Text = "Autocompletar";
            this.lbl_Autocompletar.Click += new System.EventHandler(this.lbl_Autocompletar_Click);
            // 
            // lbl_Salir
            // 
            this.lbl_Salir.AutoSize = true;
            this.lbl_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.lbl_Salir.Location = new System.Drawing.Point(123, 385);
            this.lbl_Salir.Name = "lbl_Salir";
            this.lbl_Salir.Size = new System.Drawing.Size(39, 16);
            this.lbl_Salir.TabIndex = 5;
            this.lbl_Salir.Text = "Salir";
            this.lbl_Salir.Click += new System.EventHandler(this.lbl_Salir_Click);
            // 
            // tbox_Usuario
            // 
            this.tbox_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbox_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.tbox_Usuario.Location = new System.Drawing.Point(53, 208);
            this.tbox_Usuario.Multiline = true;
            this.tbox_Usuario.Name = "tbox_Usuario";
            this.tbox_Usuario.Size = new System.Drawing.Size(199, 24);
            this.tbox_Usuario.TabIndex = 6;
            // 
            // tbox_Password
            // 
            this.tbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.tbox_Password.Location = new System.Drawing.Point(53, 272);
            this.tbox_Password.Multiline = true;
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = '*';
            this.tbox_Password.Size = new System.Drawing.Size(199, 24);
            this.tbox_Password.TabIndex = 6;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Location = new System.Drawing.Point(29, 338);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(233, 33);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(50, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dreams Cruise";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.tbox_Usuario);
            this.Controls.Add(this.lbl_Salir);
            this.Controls.Add(this.lbl_Autocompletar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbox_Password);
            this.Controls.Add(this.pbox_Usuario);
            this.Controls.Add(this.pbox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Logo;
        private System.Windows.Forms.PictureBox pbox_Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Autocompletar;
        private System.Windows.Forms.Label lbl_Salir;
        private System.Windows.Forms.TextBox tbox_Usuario;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label label1;
    }
}

