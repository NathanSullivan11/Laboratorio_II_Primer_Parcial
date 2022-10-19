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
    public partial class FrmMenuPrincipal : Form
    {
        FrmLogin formLogin;

        public FrmMenuPrincipal(FrmLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void pbox_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbox_Maximizar_Click(object sender, EventArgs e)
        {
            pbox_Maximizar.Visible = false;
            pbox_Restaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pbox_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin.Show(); 
        }

        private void pbox_Restaurar_Click(object sender, EventArgs e)
        {
            pbox_Restaurar.Visible = false;
            pbox_Maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
