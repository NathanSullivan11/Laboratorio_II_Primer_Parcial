
namespace Vista
{
    partial class FrmViajesHistoricos
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
            this.tableLayoutPanel_Contenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecaudacionPorServicio = new System.Windows.Forms.Button();
            this.lblRecaudacionPorServicio = new System.Windows.Forms.Label();
            this.btnRecaudacionTotal = new System.Windows.Forms.Button();
            this.lblRecaudacionTotal = new System.Windows.Forms.Label();
            this.dgv_ListadoViajesHistoricos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_Contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoViajesHistoricos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Contenedor
            // 
            this.tableLayoutPanel_Contenedor.ColumnCount = 1;
            this.tableLayoutPanel_Contenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Contenedor.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_Contenedor.Controls.Add(this.dgv_ListadoViajesHistoricos, 0, 1);
            this.tableLayoutPanel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Contenedor.Name = "tableLayoutPanel_Contenedor";
            this.tableLayoutPanel_Contenedor.RowCount = 2;
            this.tableLayoutPanel_Contenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel_Contenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel_Contenedor.Size = new System.Drawing.Size(1027, 714);
            this.tableLayoutPanel_Contenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnRecaudacionPorServicio);
            this.panel1.Controls.Add(this.lblRecaudacionPorServicio);
            this.panel1.Controls.Add(this.btnRecaudacionTotal);
            this.panel1.Controls.Add(this.lblRecaudacionTotal);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 86);
            this.panel1.TabIndex = 9;
            // 
            // btnRecaudacionPorServicio
            // 
            this.btnRecaudacionPorServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecaudacionPorServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnRecaudacionPorServicio.FlatAppearance.BorderSize = 0;
            this.btnRecaudacionPorServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecaudacionPorServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecaudacionPorServicio.ForeColor = System.Drawing.Color.White;
            this.btnRecaudacionPorServicio.Location = new System.Drawing.Point(483, 28);
            this.btnRecaudacionPorServicio.MaximumSize = new System.Drawing.Size(247, 41);
            this.btnRecaudacionPorServicio.Name = "btnRecaudacionPorServicio";
            this.btnRecaudacionPorServicio.Size = new System.Drawing.Size(247, 41);
            this.btnRecaudacionPorServicio.TabIndex = 7;
            this.btnRecaudacionPorServicio.Text = "Recaudación por servicio";
            this.btnRecaudacionPorServicio.UseVisualStyleBackColor = false;
            this.btnRecaudacionPorServicio.Click += new System.EventHandler(this.btnRecaudacionPorServicio_Click);
            // 
            // lblRecaudacionPorServicio
            // 
            this.lblRecaudacionPorServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecaudacionPorServicio.AutoSize = true;
            this.lblRecaudacionPorServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacionPorServicio.ForeColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionPorServicio.Location = new System.Drawing.Point(745, 28);
            this.lblRecaudacionPorServicio.Name = "lblRecaudacionPorServicio";
            this.lblRecaudacionPorServicio.Size = new System.Drawing.Size(207, 19);
            this.lblRecaudacionPorServicio.TabIndex = 8;
            this.lblRecaudacionPorServicio.Text = "Recaudación por servicio";
            // 
            // btnRecaudacionTotal
            // 
            this.btnRecaudacionTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecaudacionTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(112)))), ((int)(((byte)(161)))));
            this.btnRecaudacionTotal.FlatAppearance.BorderSize = 0;
            this.btnRecaudacionTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecaudacionTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecaudacionTotal.ForeColor = System.Drawing.Color.White;
            this.btnRecaudacionTotal.Location = new System.Drawing.Point(34, 28);
            this.btnRecaudacionTotal.MaximumSize = new System.Drawing.Size(247, 41);
            this.btnRecaudacionTotal.Name = "btnRecaudacionTotal";
            this.btnRecaudacionTotal.Size = new System.Drawing.Size(187, 41);
            this.btnRecaudacionTotal.TabIndex = 7;
            this.btnRecaudacionTotal.Text = "Recaudación total";
            this.btnRecaudacionTotal.UseVisualStyleBackColor = false;
            this.btnRecaudacionTotal.Click += new System.EventHandler(this.btnRecaudacionTotal_Click);
            // 
            // lblRecaudacionTotal
            // 
            this.lblRecaudacionTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecaudacionTotal.AutoSize = true;
            this.lblRecaudacionTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacionTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionTotal.Location = new System.Drawing.Point(247, 40);
            this.lblRecaudacionTotal.Name = "lblRecaudacionTotal";
            this.lblRecaudacionTotal.Size = new System.Drawing.Size(152, 19);
            this.lblRecaudacionTotal.TabIndex = 8;
            this.lblRecaudacionTotal.Text = "Recaudación total";
            // 
            // dgv_ListadoViajesHistoricos
            // 
            this.dgv_ListadoViajesHistoricos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListadoViajesHistoricos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgv_ListadoViajesHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoViajesHistoricos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListadoViajesHistoricos.Location = new System.Drawing.Point(3, 95);
            this.dgv_ListadoViajesHistoricos.Name = "dgv_ListadoViajesHistoricos";
            this.dgv_ListadoViajesHistoricos.RowTemplate.Height = 25;
            this.dgv_ListadoViajesHistoricos.Size = new System.Drawing.Size(1021, 616);
            this.dgv_ListadoViajesHistoricos.TabIndex = 0;
            // 
            // FrmViajesHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1027, 714);
            this.Controls.Add(this.tableLayoutPanel_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmViajesHistoricos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmViajesHistoricos";
            this.Load += new System.EventHandler(this.FrmViajesHistoricos_Load);
            this.tableLayoutPanel_Contenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoViajesHistoricos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Contenedor;
        private System.Windows.Forms.DataGridView dgv_ListadoViajesHistoricos;
        protected System.Windows.Forms.Button btnRecaudacionTotal;
        protected System.Windows.Forms.Button btnRecaudacionPorServicio;
        private System.Windows.Forms.Label lblRecaudacionTotal;
        private System.Windows.Forms.Label lblRecaudacionPorServicio;
        private System.Windows.Forms.Panel panel1;
    }
}