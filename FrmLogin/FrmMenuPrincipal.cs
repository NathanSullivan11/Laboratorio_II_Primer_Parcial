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

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(Usuario usuarioLogueado, FrmLogin formLogin) : this()
        {          
            this.usuarioLogueado = usuarioLogueado;
            SetearMensajeUsuarioYFecha();
            //this.comboBox1.DataSource = Enum.GetNames(typeof(EDestinoRegional));
            this.formLogin = formLogin;
        }

        private void SetearMensajeUsuarioYFecha()
        {
            this.lblUsuarioLogueado.Text = $"Vendedor: {usuarioLogueado.Nombre} {usuarioLogueado.Apellido}";
            this.lblFechaLogueado.Text = DateTime.Now.ToLongDateString();             
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            this.dgvListadoClientes.DataSource = BaseDeDatos.ListaClientes;
            this.dgvListadoClientes.Visible = true;
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

        private void btnViajesActivos_Click(object sender, EventArgs e)
        {
            FrmViajesActivos formViajesActivos = new FrmViajesActivos();

            formViajesActivos.ShowDialog();
           


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
     
    }
}
