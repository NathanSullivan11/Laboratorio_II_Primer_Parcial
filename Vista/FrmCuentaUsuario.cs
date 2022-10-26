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

        #region Constructor y evento Load
        public FrmCuentaUsuario(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            
        }

        private void FrmCuentaUsuario_Load(object sender, EventArgs e)
        {
            this.CargarInfoDelUsuario();
        }
        #endregion

        #region Configuaracion para instanciar
        private void CargarInfoDelUsuario()
        {
            this.txtMail.Text = this.usuarioLogueado.Mail;
            this.txtUsuario.Text = this.usuarioLogueado.NombreUsuario;
            this.txtPassword.Text = this.usuarioLogueado.Password;
            this.DesactivarCamposTxt();

            this.lblDni.Text = $"Dni: {this.usuarioLogueado.GetHashCode()}";
            this.lblNombreCompleto.Text = this.usuarioLogueado.Nombre + " " + this.usuarioLogueado.Apellido;
        }
        #endregion

        #region Funcionalidades varias
        /// <summary>
        /// Desactiva los campos, dejandolos solo lectura
        /// </summary>
        private void DesactivarCamposTxt()
        {
            this.txtUsuario.Enabled = !(this.txtUsuario.Enabled);
            this.txtMail.Enabled = !(this.txtMail.Enabled);
            this.txtPassword.Enabled = !(this.txtPassword.Enabled);
        }
        /// <summary>
        /// Activa los campos de texto, para poder modificarlo los datos
        /// </summary>
        private void ActivarComponentesParaModificacion()
        {
            this.txtMail.Enabled = !(this.txtMail.Enabled);

            this.txtUsuario.Enabled = !(this.txtUsuario.Enabled);

            this.txtPassword.Enabled = !(this.txtPassword.Enabled);

            this.btnAceptarCambios.Visible = true;

            this.lblMensajeError.Visible = false;
        }
        /// <summary>
        /// Muestra un mensaje de error por pantalla
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar</param>
        private void ActivarMensajeError(string mensaje)
        {
            this.lblMensajeError.Visible = true;
            this.lblMensajeError.Text = mensaje;
        }
        #endregion

        #region Funcionalidades para editar el perfil
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ActivarComponentesParaModificacion();
        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            if (this.CamposVacios())
            {
                ActivarMensajeError("ERROR: No puede dejar campos vacíos");
            }
            else if (this.CheckearDatosIngresados())
            {
                ActivarMensajeError("ERROR: Debe modificar al menos un dato");
            }
            else
            {
                this.lblMensajeError.Visible = false;
                this.EditarPerfilUsuario();
            }
        }

        private void EditarPerfilUsuario()
        {
            if (Sistema.ModificarUsuario(usuarioLogueado, this.txtUsuario.Text, this.txtPassword.Text, this.txtMail.Text) == true)
            {
                this.DesactivarCamposTxt();
                this.btnAceptarCambios.Visible = false;
                MessageBox.Show("Cambios guardados correctamente!");
            }
            else
            {
                ActivarMensajeError("ERROR: La contraseña debe contener 4 dígitos únicamente");
            }
        }
        #endregion

        #region Validaciones
        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(this.txtMail.Text) || string.IsNullOrEmpty(this.txtUsuario.Text) || string.IsNullOrEmpty(this.txtPassword.Text);
        }

        private bool CheckearDatosIngresados()
        {
            return this.txtUsuario.Text == usuarioLogueado.NombreUsuario && this.txtMail.Text == usuarioLogueado.Mail && this.txtPassword.Text == usuarioLogueado.Password;
        }
        #endregion

        #region Evento para cerrar formulario
        private void pbox_Regresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
