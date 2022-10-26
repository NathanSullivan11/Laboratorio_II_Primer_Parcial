using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        #region Atributos
        private Usuario usuarioLogueado;
        private FrmLogin formLogin;
        private FrmViajes formViajes;
        private FrmClientes formClientes;
        private FrmEstadisticasDestinos formEstadisticasDestinos;
        private FrmEstadisticasCruceros formEstadisticasCruceros;
        private FrmViajesHistoricos formViajesHistoricos;
        private string mensajeAyuda;
        #endregion

        #region Constructor y evento load
        public FrmMenuPrincipal(FrmLogin formLogin, Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.usuarioLogueado = usuarioLogueado;
            this.mensajeAyuda = "Seleccione algun menú o submenú y vuelva a hacerme click!\nMi texto cambia dependendiendo que formulario este abierto";
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.SetearMensajeUsuarioYFecha();
        }
        #endregion

        #region Evento para instanciar formularios
        private void btn_CuentaUsuario_Click(object sender, EventArgs e)
        {
            FrmCuentaUsuario formCuentaUsuario = new FrmCuentaUsuario(usuarioLogueado);

            formCuentaUsuario.ShowDialog();

        }
        
        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            this.panel_SubMenuEstadisticas.Visible = !this.panel_SubMenuEstadisticas.Visible;
        }
        /// <summary>
        /// Instancia el formulario y prepara el entorno para su visualización
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViajesTotales_Click(object sender, EventArgs e)
        {
            this.OcultarSubMenuEstadisticas();
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formViajesHistoricos = new FrmViajesHistoricos();
            this.ConfigurarForm(this.formViajesHistoricos);
            this.mensajeAyuda = "Visualizar el listado de todos los viajes (activos y finalizados)\nCon la opción de calcular las ganancias totales,\ny las ganancias clasificadas por servicios.";
        }
        /// <summary>
        /// Instancia el formulario y prepara el entorno para su visualización
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EstadisticasDestinos_Click(object sender, EventArgs e)
        {
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formEstadisticasDestinos = new FrmEstadisticasDestinos();
            this.ConfigurarForm(this.formEstadisticasDestinos);
            this.mensajeAyuda = "Visualizar el listado de destinos disponibles\nCon la opción de filtrarlos y ordenarlos según algunos criterios";
        }
        /// <summary>
        /// Instancia el formulario y prepara el entorno para su visualización
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EstadisticasCruceros_Click(object sender, EventArgs e)
        {
            this.OcultarSubMenuEstadisticas();
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formEstadisticasCruceros = new FrmEstadisticasCruceros();
            this.ConfigurarForm(this.formEstadisticasCruceros);
            this.mensajeAyuda = "Visualizar los cruceros de la flota\nCon la opción de calcular la cantidad de horas acumuladas\npor cada uno.";
        }
        /// <summary>
        /// Instancia el formulario y prepara el entorno para su visualización
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Viajes_Click(object sender, EventArgs e)
        {
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formViajes = new FrmViajes();
            this.ConfigurarForm(this.formViajes);
            this.mensajeAyuda = "Visualizar el listado de viajes activos\nListar Pasajeros: Ver lista de pasajeros a bordo (pudiendo filtrarlos) y ver info detallada del crucero\nVenta de pasaje: Venderle a un pasajero o un grupo familiar, siempre y cuando\nel crucero este disponible (capacidad, bodega completa, etc)\nAgregar nuevos viajes: Agregar nuevos viajes, teniendo en cuenta si el crucero esta disponible en determinada fecha\nDar de baja viajes: Eliminar viaje de la lista de activos";
        }
        /// <summary>
        /// Instancia el formulario y prepara el entorno para su visualización
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formClientes = new FrmClientes();
            this.ConfigurarForm(this.formClientes);
            this.mensajeAyuda = "Visualizar el listado completo de clientes (no son pasajeros, son clientes que alguna vez sacaron un pasaje y quedaron registrados)\nPodremos filtrar y ordenar por diferentes criterios";
        }
        #endregion

        #region Configuraciones para visualizar los formularios correctamente
        private void OcultarSubMenuEstadisticas()
        {
            if (this.panel_SubMenuEstadisticas.Visible == true)
            {
                this.panel_SubMenuEstadisticas.Visible = false;
            }
        }

        private void VaciarPanelCentral()
        {
            if (this.panel_Central.Controls.Count > 0)
            {              
                foreach(Control item in this.panel_Central.Controls)
                {
                    if(item is Form)
                    {
                        this.panel_Central.Controls.Remove(item);
                    }
                }
            }
        }
        /// <summary>
        /// Configura el formulario para que aparezca en la posicion correcta
        /// </summary>
        /// <param name="esteForm"></param>
        private void ConfigurarForm(Form esteForm)
        {
            esteForm.TopLevel = false;
            esteForm.Dock = DockStyle.Fill;
            this.panel_Central.Controls.Add(esteForm);
            this.panel_Central.Tag = esteForm;
            this.pboxLogoGrande.Visible = false;
            esteForm.Show();
        }

        private void SetearMensajeUsuarioYFecha()
        { 
            this.lblUsuarioLogueado.Text = usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
            this.lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region Eventos de los botones pertenecientes A la barra superior
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

        private void pbox_Restaurar_Click(object sender, EventArgs e)
        {
            pbox_Restaurar.Visible = false;
            pbox_Maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void pbox_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.mensajeAyuda, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbox_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Eventos para el cierre del formulario
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                formLogin.Show();
            }
        }

        private void pbox_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
     
    }

}
