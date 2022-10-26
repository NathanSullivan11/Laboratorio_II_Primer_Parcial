
namespace Vista
{
    partial class FrmEstadisticasCruceros
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_ListadoCruceros = new System.Windows.Forms.DataGridView();
            this.chkBox_MostrarHorasCruceros = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_ListadoCruceros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkBox_MostrarHorasCruceros, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_ListadoCruceros
            // 
            this.dgv_ListadoCruceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListadoCruceros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgv_ListadoCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoCruceros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListadoCruceros.Location = new System.Drawing.Point(3, 77);
            this.dgv_ListadoCruceros.Name = "dgv_ListadoCruceros";
            this.dgv_ListadoCruceros.RowTemplate.Height = 25;
            this.dgv_ListadoCruceros.Size = new System.Drawing.Size(944, 515);
            this.dgv_ListadoCruceros.TabIndex = 0;
            // 
            // chkBox_MostrarHorasCruceros
            // 
            this.chkBox_MostrarHorasCruceros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chkBox_MostrarHorasCruceros.AutoSize = true;
            this.chkBox_MostrarHorasCruceros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBox_MostrarHorasCruceros.ForeColor = System.Drawing.Color.White;
            this.chkBox_MostrarHorasCruceros.Location = new System.Drawing.Point(339, 3);
            this.chkBox_MostrarHorasCruceros.Name = "chkBox_MostrarHorasCruceros";
            this.chkBox_MostrarHorasCruceros.Size = new System.Drawing.Size(272, 68);
            this.chkBox_MostrarHorasCruceros.TabIndex = 1;
            this.chkBox_MostrarHorasCruceros.Text = "Mostrar horas viajas de cada crucero";
            this.chkBox_MostrarHorasCruceros.UseVisualStyleBackColor = true;
            this.chkBox_MostrarHorasCruceros.CheckedChanged += new System.EventHandler(this.chkBox_MostrarHorasCruceros_CheckedChanged);
            // 
            // FrmEstadisticasCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(950, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticasCruceros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadísticas cruceros";
            this.Load += new System.EventHandler(this.FrmEstadisticasCruceros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoCruceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_ListadoCruceros;
        private System.Windows.Forms.CheckBox chkBox_MostrarHorasCruceros;
    }
}