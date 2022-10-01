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
    public partial class FrmCuentaUsuario : Form
    {
        Usuario usuarioLogueado;
        public FrmCuentaUsuario(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
        }

        private void FrmCuentaUsuario_Load(object sender, EventArgs e)
        {
            this.CargarInfoDelUsuario();
        }

        private void CargarInfoDelUsuario()
        {
            this.txtMail.Text = usuarioLogueado.Mail;
            this.txtUsuario.Text = usuarioLogueado.NombreUsuario;
            this.txtPassword.Text = usuarioLogueado.Password;
            this.DesactivarCamposTxt();
           
            this.lblDni.Text = $"Dni: {usuarioLogueado.GetHashCode()}";
            this.lblNombreCompleto.Text = usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
        }

        private void DesactivarCamposTxt()
        {
            this.txtUsuario.Enabled = !(this.txtUsuario.Enabled);
            this.txtMail.Enabled = !(this.txtMail.Enabled);
            this.txtPassword.Enabled = !(this.txtPassword.Enabled);
        }

        private void ActivarComponentesParaModificacion()
        {
            this.txtMail.Enabled = !(this.txtMail.Enabled);

            this.txtUsuario.Enabled = !(this.txtUsuario.Enabled);

            this.txtPassword.Enabled = !(this.txtPassword.Enabled);

            this.btnAceptarCambios.Visible = true;

            this.lblMensajeError.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ActivarComponentesParaModificacion();        
        }

        private bool CheckearCamposIngresados()
        {
            return string.IsNullOrEmpty(this.txtMail.Text) || string.IsNullOrEmpty(this.txtUsuario.Text) || string.IsNullOrEmpty(this.txtPassword.Text);      
        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            if(this.CheckearCamposIngresados())
            {
                ActivarMensajeError("ERROR: No puede dejar campos vacíos"); 
            }
            else
            {
                this.lblMensajeError.Visible = false;
                if (Sistema.ModificarUsuario(usuarioLogueado, this.txtUsuario.Text, this.txtPassword.Text, this.txtMail.Text) == true)
                {
                    this.DesactivarCamposTxt();
                    MessageBox.Show("Cambios guardados correctamente");
                }
                else
                {
                    ActivarMensajeError("ERROR: La contraseña debe contener 4 dígitos únicamente");
                }             
            }
        }

        private void ActivarMensajeError(string mensaje)
        {
            this.lblMensajeError.Visible = true;
            this.lblMensajeError.Text = mensaje;
        }
    }
}
