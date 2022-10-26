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
    public partial class FrmEstadisticasDestinos : FrmClientes
    {        
        private int opcionSeleccionada;

        #region Constructor y evento Load
        public FrmEstadisticasDestinos()
        {
            InitializeComponent();
        }

        protected override void FrmClientes_Load(object sender, EventArgs e)
        {
            this.EstablecerPredeterminados();
            this.Dock = DockStyle.Fill;
        }
        #endregion

        #region Configuraciones para instanciar
        private void EstablecerPredeterminados()
        {
            this.CargarComboBoxFiltros();
            this.cmbBox_Opciones.SelectedIndex = 0;
            this.rbtnOrdenAscendente.Checked = true;
            CargarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(0));
            
        }

        protected override void CargarComboBoxFiltros()
        {
            this.cmbBox_Opciones.Items.Clear();
            this.cmbBox_Opciones.Items.Add("Facturación");
            this.cmbBox_Opciones.Items.Add("pedidos de viajes");
            this.cmbBox_Opciones.SelectedIndex = 0;
        }
        #endregion

        #region Funcionalidades para cargar el data grid
        /// <summary>
        /// Carga el data grid con la información de los destinos por facturación
        /// </summary>
        /// <param name="diccionarioFacturacion"></param>
        private void CargarDiccionarioFacturacionDataGrid(Dictionary<string, float> diccionarioFacturacion)
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = diccionarioFacturacion;
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[0].HeaderText = "Destino";
            this.dataGridView1.Columns[1].HeaderText = "Facturado";
        }
        /// <summary>
        /// Carga el data grid con la información de los destinos por horas de viaje
        /// </summary>
        /// <param name="diccionarioCantidadViajes"></param>
        private void CargarDiccionarioCantidadViajesDataGrid(Dictionary<string, int> diccionarioCantidadViajes)
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = diccionarioCantidadViajes;
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[0].HeaderText = "Destino";
            this.dataGridView1.Columns[1].HeaderText = "Viajes";
        }
        #endregion

        #region Evento para cambiar la opcion seleccionada
        /// <summary>
        /// Setea la opcion seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void cmbBox_Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeleccionada = this.cmbBox_Opciones.SelectedIndex;
        }
        #endregion

        #region Funcionalidades para ordenar
        protected override void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0)
            {
                this.OrdenarPorFacturacion();
            }
            else
            {
                this.OrdenarPorCantidadDeViajes();
            }
        }

        private void OrdenarPorFacturacion()
        {
            if (rbtnOrdenAscendente.Checked)
            {
                CargarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(0));
            }
            else if (rbtnOrdenDescendente.Checked)
            {
                CargarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(1));
            }
        }

        private void OrdenarPorCantidadDeViajes()
        {
            if (rbtnOrdenAscendente.Checked)
            {
                CargarDiccionarioCantidadViajesDataGrid(Sistema.OrdenarDiccionarioDestinosCantidadViajes(0));
            }
            else if (rbtnOrdenDescendente.Checked)
            {
                CargarDiccionarioCantidadViajesDataGrid(Sistema.OrdenarDiccionarioDestinosCantidadViajes(1));
            }
        }
        #endregion

    }
}
