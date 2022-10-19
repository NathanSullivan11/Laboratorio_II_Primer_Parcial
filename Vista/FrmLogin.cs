using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
         private static extern IntPtr CreateRoundRectRgn
         (
           int nLeftRect,  
           int nTopRect,                            
           int nRightRect,                                
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse 
        );

        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
    }
}
