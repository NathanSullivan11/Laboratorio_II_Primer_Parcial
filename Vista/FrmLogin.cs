using System;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(!this.TextBoxEstanVacios())
            {
                this.IniciarSesion();                
            }
            else
            {
                this.MostrarMensajeError("ERROR: Hay campos vacíos");
            }

        }

        private void IniciarSesion()
        {
            Usuario usuarioLogueado = Sistema.LoguearUsuario(this.tbox_Usuario.Text, this.tbox_Password.Text);
            if (usuarioLogueado != null)
            {
                FrmMenuPrincipal formMenuPrincipal = new FrmMenuPrincipal(this, usuarioLogueado);
                formMenuPrincipal.Show();

                this.LimpiarCampos();
                this.lbl_MensajeError.Visible = false;
                this.Hide();
            }
            else
            {
                this.MostrarMensajeError("ERROR: Usuario o contraseña incorrectos");
            }
        }

        private bool TextBoxEstanVacios()
        {
            return string.IsNullOrEmpty(tbox_Usuario.Text) || string.IsNullOrEmpty(tbox_Password.Text);
        }

        private void LimpiarCampos()
        {
            this.tbox_Usuario.Clear();
            this.tbox_Password.Clear();
        }

        private void MostrarMensajeError(string mensaje)
        {
            this.lbl_MensajeError.Text = mensaje;
            this.lbl_MensajeError.Visible = true;
        }

        private void lbl_Autocompletar_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = Sistema.ObtenerUsuario();

            this.tbox_Usuario.Text = auxUsuario.NombreUsuario;
            this.tbox_Password.Text = auxUsuario.Password;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "Cierre de aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lbl_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
