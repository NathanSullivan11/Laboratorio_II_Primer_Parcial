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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = Sistema.LoguearUsuario(this.txtUsuario.Text, this.txtPassword.Text);

            if(auxUsuario != null)
            {
                FrmMenuPrincipal formMenuPrincipal = new FrmMenuPrincipal(auxUsuario, this);

                formMenuPrincipal.Show();
                VaciarCampos();
                this.Hide();

            }
            else
            {
                this.lblMensajeError.Text = "ERROR: Usuario o contraseña incorrectos";
                this.lblMensajeError.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoCompletado_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = Sistema.ObtenerUsuario();

            this.txtUsuario.Text = auxUsuario.NombreUsuario;
            this.txtPassword.Text = auxUsuario.Password;
        }

        private void VaciarCampos()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox txtBox)
                {
                    txtBox.Text = string.Empty;
                }
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea cerrar la aplicacion?", "CIERRE DE APLICACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
