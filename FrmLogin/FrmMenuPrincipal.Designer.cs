
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viajesActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viajesActivosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crucerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_ContenedorBotonesFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCuentaUsuario = new System.Windows.Forms.Button();
            this.lblFechaLogueado = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel_ContenedorBotonesFooter.SuspendLayout();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajesActivosToolStripMenuItem1,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viajesActivosToolStripMenuItem1
            // 
            this.viajesActivosToolStripMenuItem1.Name = "viajesActivosToolStripMenuItem1";
            this.viajesActivosToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.viajesActivosToolStripMenuItem1.Text = "Viajes activos";
            this.viajesActivosToolStripMenuItem1.Click += new System.EventHandler(this.viajesActivosToolStripMenuItem1_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.destinosToolStripMenuItem,
            this.viajesTotalesToolStripMenuItem,
            this.crucerosToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.estadisticasToolStripMenuItem.Text = "⁫Historial";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // destinosToolStripMenuItem
            // 
            this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            this.destinosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.destinosToolStripMenuItem.Text = "Destinos";
            this.destinosToolStripMenuItem.Click += new System.EventHandler(this.destinosToolStripMenuItem_Click_1);
            // 
            // viajesTotalesToolStripMenuItem
            // 
            this.viajesTotalesToolStripMenuItem.Name = "viajesTotalesToolStripMenuItem";
            this.viajesTotalesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viajesTotalesToolStripMenuItem.Text = "Viajes totales";
            this.viajesTotalesToolStripMenuItem.Click += new System.EventHandler(this.viajesTotalesToolStripMenuItem_Click);
            // 
            // crucerosToolStripMenuItem
            // 
            this.crucerosToolStripMenuItem.Name = "crucerosToolStripMenuItem";
            this.crucerosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.crucerosToolStripMenuItem.Text = "Cruceros";
            this.crucerosToolStripMenuItem.Click += new System.EventHandler(this.crucerosToolStripMenuItem_Click_1);
            // 
            // tableLayoutPanel_ContenedorBotonesFooter
            // 
            this.tableLayoutPanel_ContenedorBotonesFooter.BackColor = System.Drawing.Color.Chocolate;
            this.tableLayoutPanel_ContenedorBotonesFooter.ColumnCount = 4;
            this.tableLayoutPanel_ContenedorBotonesFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ContenedorBotonesFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_ContenedorBotonesFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ContenedorBotonesFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ContenedorBotonesFooter.Controls.Add(this.btnCerrarSesion, 3, 0);
            this.tableLayoutPanel_ContenedorBotonesFooter.Controls.Add(this.btnCuentaUsuario, 0, 0);
            this.tableLayoutPanel_ContenedorBotonesFooter.Controls.Add(this.lblFechaLogueado, 2, 0);
            this.tableLayoutPanel_ContenedorBotonesFooter.Controls.Add(this.lblUsuarioLogueado, 1, 0);
            this.tableLayoutPanel_ContenedorBotonesFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_ContenedorBotonesFooter.Location = new System.Drawing.Point(0, 523);
            this.tableLayoutPanel_ContenedorBotonesFooter.Name = "tableLayoutPanel_ContenedorBotonesFooter";
            this.tableLayoutPanel_ContenedorBotonesFooter.RowCount = 1;
            this.tableLayoutPanel_ContenedorBotonesFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContenedorBotonesFooter.Size = new System.Drawing.Size(1309, 50);
            this.tableLayoutPanel_ContenedorBotonesFooter.TabIndex = 10;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Bisque;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1126, 13);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(102, 23);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCuentaUsuario
            // 
            this.btnCuentaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuentaUsuario.BackColor = System.Drawing.Color.Bisque;
            this.btnCuentaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaUsuario.Location = new System.Drawing.Point(79, 13);
            this.btnCuentaUsuario.Name = "btnCuentaUsuario";
            this.btnCuentaUsuario.Size = new System.Drawing.Size(102, 23);
            this.btnCuentaUsuario.TabIndex = 5;
            this.btnCuentaUsuario.Text = "Mi cuenta";
            this.btnCuentaUsuario.UseVisualStyleBackColor = false;
            this.btnCuentaUsuario.Click += new System.EventHandler(this.btnCuentaUsuario_Click);
            // 
            // lblFechaLogueado
            // 
            this.lblFechaLogueado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaLogueado.AutoSize = true;
            this.lblFechaLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaLogueado.ForeColor = System.Drawing.Color.White;
            this.lblFechaLogueado.Location = new System.Drawing.Point(864, 17);
            this.lblFechaLogueado.Name = "lblFechaLogueado";
            this.lblFechaLogueado.Size = new System.Drawing.Size(100, 15);
            this.lblFechaLogueado.TabIndex = 4;
            this.lblFechaLogueado.Text = "Fecha del logueo";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioLogueado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogueado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(447, 17);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(150, 15);
            this.lblUsuarioLogueado.TabIndex = 3;
            this.lblUsuarioLogueado.Text = "Nombre usuario logueado";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 573);
            this.Controls.Add(this.tableLayoutPanel_ContenedorBotonesFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel_ContenedorBotonesFooter.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorBotonesFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajesActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajesActivosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crucerosToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorBotonesFooter;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCuentaUsuario;
        private System.Windows.Forms.Label lblFechaLogueado;
        private System.Windows.Forms.Label lblUsuarioLogueado;
    }
}