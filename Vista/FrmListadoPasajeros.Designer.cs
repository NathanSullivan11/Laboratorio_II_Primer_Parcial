
namespace Vista
{
    partial class FrmListadoPasajeros
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
            this.cmbOpcionesFiltrado = new System.Windows.Forms.ComboBox();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.chkBoxFiltroPremium = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_ContenedorPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ContenedorBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnInfoCrucero = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox_Regresar = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvListadoPasajeros = new System.Windows.Forms.DataGridView();
            this.dgv_ListadoPasajeros = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_ContenedorPrincipal.SuspendLayout();
            this.tableLayoutPanel_ContenedorBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOpcionesFiltrado
            // 
            this.cmbOpcionesFiltrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOpcionesFiltrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.cmbOpcionesFiltrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOpcionesFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesFiltrado.ForeColor = System.Drawing.Color.Yellow;
            this.cmbOpcionesFiltrado.FormattingEnabled = true;
            this.cmbOpcionesFiltrado.Location = new System.Drawing.Point(86, 16);
            this.cmbOpcionesFiltrado.Name = "cmbOpcionesFiltrado";
            this.cmbOpcionesFiltrado.Size = new System.Drawing.Size(140, 23);
            this.cmbOpcionesFiltrado.TabIndex = 4;
            this.cmbOpcionesFiltrado.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesFiltrado_SelectedIndexChanged);
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiltrarPor.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarPor.Location = new System.Drawing.Point(4, 19);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(74, 16);
            this.lblFiltrarPor.TabIndex = 5;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // chkBoxFiltroPremium
            // 
            this.chkBoxFiltroPremium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxFiltroPremium.AutoSize = true;
            this.chkBoxFiltroPremium.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxFiltroPremium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxFiltroPremium.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBoxFiltroPremium.ForeColor = System.Drawing.Color.White;
            this.chkBoxFiltroPremium.Location = new System.Drawing.Point(561, 24);
            this.chkBoxFiltroPremium.Name = "chkBoxFiltroPremium";
            this.chkBoxFiltroPremium.Size = new System.Drawing.Size(121, 20);
            this.chkBoxFiltroPremium.TabIndex = 6;
            this.chkBoxFiltroPremium.Text = "Solo premiums";
            this.chkBoxFiltroPremium.UseVisualStyleBackColor = false;
            this.chkBoxFiltroPremium.Visible = false;
            this.chkBoxFiltroPremium.CheckedChanged += new System.EventHandler(this.chkBoxFiltroPremium_CheckedChanged);
            // 
            // tableLayoutPanel_ContenedorPrincipal
            // 
            this.tableLayoutPanel_ContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel_ContenedorPrincipal.ColumnCount = 1;
            this.tableLayoutPanel_ContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorPrincipal.Controls.Add(this.tableLayoutPanel_ContenedorBotones, 0, 0);
            this.tableLayoutPanel_ContenedorPrincipal.Controls.Add(this.dgvListadoPasajeros, 0, 1);
            this.tableLayoutPanel_ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ContenedorPrincipal.Name = "tableLayoutPanel_ContenedorPrincipal";
            this.tableLayoutPanel_ContenedorPrincipal.RowCount = 2;
            this.tableLayoutPanel_ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50643F));
            this.tableLayoutPanel_ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.49357F));
            this.tableLayoutPanel_ContenedorPrincipal.Size = new System.Drawing.Size(1145, 604);
            this.tableLayoutPanel_ContenedorPrincipal.TabIndex = 8;
            // 
            // tableLayoutPanel_ContenedorBotones
            // 
            this.tableLayoutPanel_ContenedorBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel_ContenedorBotones.ColumnCount = 6;
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.571428F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.42177F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.4966F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.76964F));
            this.tableLayoutPanel_ContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 436F));
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.btnInfoCrucero, 5, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.chkBoxFiltroPremium, 4, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.pbox_Regresar, 0, 0);
            this.tableLayoutPanel_ContenedorBotones.Controls.Add(this.txtFiltro, 3, 0);
            this.tableLayoutPanel_ContenedorBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorBotones.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ContenedorBotones.Name = "tableLayoutPanel_ContenedorBotones";
            this.tableLayoutPanel_ContenedorBotones.RowCount = 1;
            this.tableLayoutPanel_ContenedorBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorBotones.Size = new System.Drawing.Size(1139, 69);
            this.tableLayoutPanel_ContenedorBotones.TabIndex = 8;
            // 
            // btnInfoCrucero
            // 
            this.btnInfoCrucero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInfoCrucero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnInfoCrucero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoCrucero.FlatAppearance.BorderSize = 0;
            this.btnInfoCrucero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoCrucero.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfoCrucero.ForeColor = System.Drawing.Color.White;
            this.btnInfoCrucero.Location = new System.Drawing.Point(862, 15);
            this.btnInfoCrucero.Name = "btnInfoCrucero";
            this.btnInfoCrucero.Size = new System.Drawing.Size(116, 38);
            this.btnInfoCrucero.TabIndex = 2;
            this.btnInfoCrucero.Text = "Info crucero";
            this.btnInfoCrucero.UseVisualStyleBackColor = false;
            this.btnInfoCrucero.Click += new System.EventHandler(this.btnInfoCrucero_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.lblFiltrarPor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbOpcionesFiltrado, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(156, 7);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(229, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 55);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // pbox_Regresar
            // 
            this.pbox_Regresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbox_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Regresar.Image = global::Vista.Properties.Resources.arrow;
            this.pbox_Regresar.Location = new System.Drawing.Point(26, 16);
            this.pbox_Regresar.Name = "pbox_Regresar";
            this.pbox_Regresar.Size = new System.Drawing.Size(37, 36);
            this.pbox_Regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Regresar.TabIndex = 10;
            this.pbox_Regresar.TabStop = false;
            this.pbox_Regresar.Click += new System.EventHandler(this.pbox_Regresar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltro.Location = new System.Drawing.Point(394, 23);
            this.txtFiltro.MaximumSize = new System.Drawing.Size(176, 23);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PlaceholderText = "Filtrar acá";
            this.txtFiltro.Size = new System.Drawing.Size(145, 23);
            this.txtFiltro.TabIndex = 11;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvListadoPasajeros
            // 
            this.dgvListadoPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoPasajeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvListadoPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPasajeros.Location = new System.Drawing.Point(3, 78);
            this.dgvListadoPasajeros.Name = "dgvListadoPasajeros";
            this.dgvListadoPasajeros.ReadOnly = true;
            this.dgvListadoPasajeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoPasajeros.RowHeadersVisible = false;
            this.dgvListadoPasajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListadoPasajeros.RowTemplate.Height = 25;
            this.dgvListadoPasajeros.Size = new System.Drawing.Size(1139, 523);
            this.dgvListadoPasajeros.TabIndex = 9;
            // 
            // dgv_ListadoPasajeros
            // 
            this.dgv_ListadoPasajeros.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ListadoPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListadoPasajeros.Location = new System.Drawing.Point(0, 0);
            this.dgv_ListadoPasajeros.Name = "dgv_ListadoPasajeros";
            this.dgv_ListadoPasajeros.RowTemplate.Height = 25;
            this.dgv_ListadoPasajeros.Size = new System.Drawing.Size(1145, 604);
            this.dgv_ListadoPasajeros.TabIndex = 9;
            // 
            // FrmListadoPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1145, 604);
            this.Controls.Add(this.tableLayoutPanel_ContenedorPrincipal);
            this.Controls.Add(this.dgv_ListadoPasajeros);
            this.MinimumSize = new System.Drawing.Size(1161, 643);
            this.Name = "FrmListadoPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de pasajeros";
            this.Load += new System.EventHandler(this.FrmListadoPasajeros_Load);
            this.tableLayoutPanel_ContenedorPrincipal.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorBotones.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorBotones.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOpcionesFiltrado;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.CheckBox chkBoxFiltroPremium;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_ListadoPasajeros;
        private System.Windows.Forms.Button btnInfoCrucero;
        private System.Windows.Forms.PictureBox pbox_Regresar;
        private System.Windows.Forms.DataGridView dgvListadoPasajeros;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}