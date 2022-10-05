
namespace Vista
{
    partial class FrmListadoDestinos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rbtnOrdenDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnOrdenAscendente = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrdenar.Location = new System.Drawing.Point(379, 3);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 28);
            this.btnOrdenar.TabIndex = 9;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rbtnOrdenDescendente
            // 
            this.rbtnOrdenDescendente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnOrdenDescendente.AutoSize = true;
            this.rbtnOrdenDescendente.Location = new System.Drawing.Point(275, 7);
            this.rbtnOrdenDescendente.Name = "rbtnOrdenDescendente";
            this.rbtnOrdenDescendente.Size = new System.Drawing.Size(93, 19);
            this.rbtnOrdenDescendente.TabIndex = 8;
            this.rbtnOrdenDescendente.TabStop = true;
            this.rbtnOrdenDescendente.Text = "Descendente";
            this.rbtnOrdenDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdenAscendente
            // 
            this.rbtnOrdenAscendente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnOrdenAscendente.AutoSize = true;
            this.rbtnOrdenAscendente.Location = new System.Drawing.Point(176, 7);
            this.rbtnOrdenAscendente.Name = "rbtnOrdenAscendente";
            this.rbtnOrdenAscendente.Size = new System.Drawing.Size(87, 19);
            this.rbtnOrdenAscendente.TabIndex = 7;
            this.rbtnOrdenAscendente.TabStop = true;
            this.rbtnOrdenAscendente.Text = "Ascendente";
            this.rbtnOrdenAscendente.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 574);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.551657F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42885F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.82651F));
            this.tableLayoutPanel2.Controls.Add(this.cmbBoxFiltro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnOrdenAscendente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOrdenar, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnOrdenDescendente, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1026, 34);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // cmbBoxFiltro
            // 
            this.cmbBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFiltro.FormattingEnabled = true;
            this.cmbBoxFiltro.Location = new System.Drawing.Point(3, 5);
            this.cmbBoxFiltro.Name = "cmbBoxFiltro";
            this.cmbBoxFiltro.Size = new System.Drawing.Size(165, 23);
            this.cmbBoxFiltro.TabIndex = 1;
            this.cmbBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFiltro_SelectedIndexChanged);
            // 
            // FrmListadoDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoDestinos";
            this.Text = "Lista destinos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmListadoDestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rbtnOrdenDescendente;
        private System.Windows.Forms.RadioButton rbtnOrdenAscendente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbBoxFiltro;
    }
}