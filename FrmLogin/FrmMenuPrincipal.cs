using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario usuarioLogueado;

        private FrmLogin formLogin;
        private FrmListadoClientes formListadoClientes;
        private FrmListadoViajes formListadoViajes;      
        private FrmListadoDestinos formListadoDestinos;
        private FrmListadoCruceros formListadoCruceros;
        private FrmViajesActivos formViajesActivos;


        public FrmMenuPrincipal() 
        {
            InitializeComponent();

            // Creo los listado childs
            this.formListadoClientes = new FrmListadoClientes();
            this.formListadoViajes = new FrmListadoViajes();
            this.formListadoDestinos = new FrmListadoDestinos();
            this.formListadoCruceros = new FrmListadoCruceros();
            this.formViajesActivos = new FrmViajesActivos();
            this.IsMdiContainer = true;
            this.formListadoViajes.MdiParent = this;
            this.formListadoClientes.MdiParent = this;
            this.formListadoDestinos.MdiParent = this;
            this.formListadoCruceros.MdiParent = this;
            this.formViajesActivos.MdiParent = this;
        }

        public FrmMenuPrincipal(Usuario usuarioLogueado, FrmLogin formLogin) : this()
        {          
            this.usuarioLogueado = usuarioLogueado;
            SetearMensajeUsuarioYFecha();
            this.formLogin = formLogin;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.MostrarFormViajesActivos();
        }

        private void SetearMensajeUsuarioYFecha()
        {
            this.lblUsuarioLogueado.Text = $"Vendedor: {usuarioLogueado.Nombre} {usuarioLogueado.Apellido}";
            this.lblFechaLogueado.Text = DateTime.Now.ToLongDateString();             
        }

 
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                formLogin.Show();
            }
        }


        private void OcultarFormsMDI()
        {
            this.formListadoClientes.Hide();
            this.formListadoViajes.Hide();
            this.formListadoDestinos.Hide();
            this.formListadoCruceros.Hide();
            this.formViajesActivos.Hide();
        }

        private void MostrarFormViajesActivos()
        {
            this.formViajesActivos.StartPosition = FormStartPosition.CenterScreen;
            this.formViajesActivos.Show();
        }

        private void viajesActivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OcultarFormsMDI();
            this.MostrarFormViajesActivos();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OcultarFormsMDI();
            formListadoClientes.StartPosition = FormStartPosition.CenterScreen;
            formListadoClientes.Show();

        }

        

        private void destinosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            formListadoDestinos.StartPosition = FormStartPosition.CenterScreen;
            formListadoDestinos.Show();
        }

        private void viajesTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            formListadoViajes.StartPosition = FormStartPosition.CenterScreen;
            formListadoViajes.Show();
        }

        private void crucerosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            formListadoCruceros.StartPosition = FormStartPosition.CenterScreen;
            formListadoCruceros.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCuentaUsuario_Click(object sender, EventArgs e)
        {
            FrmCuentaUsuario formCuenta = new FrmCuentaUsuario(usuarioLogueado);

            formCuenta.ShowDialog();

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 opciones, inspeccionar, venta de pasajes, alta y baja");
        }
    }
}
