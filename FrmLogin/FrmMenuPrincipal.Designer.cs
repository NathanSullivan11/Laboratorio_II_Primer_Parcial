
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
            this.components = new System.ComponentModel.Container();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.lblFechaLogueado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCuentaUsuario = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnViajesActivos = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viajesActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(220, 144);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.RowTemplate.Height = 25;
            this.dgvListadoClientes.Size = new System.Drawing.Size(414, 189);
            this.dgvListadoClientes.TabIndex = 0;
            this.dgvListadoClientes.Visible = false;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarClientes.Location = new System.Drawing.Point(362, 115);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(112, 23);
            this.btnListarClientes.TabIndex = 2;
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioLogueado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogueado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(276, 12);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(150, 15);
            this.lblUsuarioLogueado.TabIndex = 3;
            this.lblUsuarioLogueado.Text = "Nombre usuario logueado";
            // 
            // lblFechaLogueado
            // 
            this.lblFechaLogueado.AutoSize = true;
            this.lblFechaLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaLogueado.ForeColor = System.Drawing.Color.White;
            this.lblFechaLogueado.Location = new System.Drawing.Point(432, 12);
            this.lblFechaLogueado.Name = "lblFechaLogueado";
            this.lblFechaLogueado.Size = new System.Drawing.Size(100, 15);
            this.lblFechaLogueado.TabIndex = 4;
            this.lblFechaLogueado.Text = "Fecha del logueo";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.btnCuentaUsuario);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.lblUsuarioLogueado);
            this.panel1.Controls.Add(this.lblFechaLogueado);
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 38);
            this.panel1.TabIndex = 5;
            // 
            // btnCuentaUsuario
            // 
            this.btnCuentaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaUsuario.Location = new System.Drawing.Point(12, 8);
            this.btnCuentaUsuario.Name = "btnCuentaUsuario";
            this.btnCuentaUsuario.Size = new System.Drawing.Size(102, 23);
            this.btnCuentaUsuario.TabIndex = 5;
            this.btnCuentaUsuario.Text = "Mi cuenta";
            this.btnCuentaUsuario.UseVisualStyleBackColor = true;
            this.btnCuentaUsuario.Click += new System.EventHandler(this.btnCuentaUsuario_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Location = new System.Drawing.Point(677, 8);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(102, 23);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnViajesActivos
            // 
            this.btnViajesActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViajesActivos.BackColor = System.Drawing.Color.SeaShell;
            this.btnViajesActivos.Location = new System.Drawing.Point(51, 51);
            this.btnViajesActivos.Name = "btnViajesActivos";
            this.btnViajesActivos.Size = new System.Drawing.Size(163, 80);
            this.btnViajesActivos.TabIndex = 7;
            this.btnViajesActivos.Text = "Viajes activos";
            this.btnViajesActivos.UseVisualStyleBackColor = false;
            this.btnViajesActivos.Click += new System.EventHandler(this.btnViajesActivos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajesActivosToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Text = "Viajes";
            // 
            // viajesActivosToolStripMenuItem
            // 
            this.viajesActivosToolStripMenuItem.Name = "viajesActivosToolStripMenuItem";
            this.viajesActivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viajesActivosToolStripMenuItem.Text = "Viajes activos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::Vista.Properties.Resources._2204_w023_n001_1929b_p1_1929;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViajesActivos);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Label lblFechaLogueado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCuentaUsuario;
        private System.Windows.Forms.Button btnViajesActivos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajesActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}