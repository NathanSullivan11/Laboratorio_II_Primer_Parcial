using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FrmMenuPrincipal formMenuPrincipal = new FrmMenuPrincipal(this);
            formMenuPrincipal.Show();
            this.Hide();
            this.LimpiarCampos();
        }

        private void lbl_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void LimpiarCampos()
        {
            this.tbox_Usuario.Clear();
            this.tbox_Password.Clear();
        }

        private void lbl_Autocompletar_Click(object sender, EventArgs e)
        {
            this.tbox_Usuario.Text = "usernathan";
            this.tbox_Password.Text = "1234";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbox_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "Cierre de aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
