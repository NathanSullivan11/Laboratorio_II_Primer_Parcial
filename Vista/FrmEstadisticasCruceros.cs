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
    public partial class FrmEstadisticasCruceros : Form
    {
        #region Constructor y evento Load
        public FrmEstadisticasCruceros()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasCruceros_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.CargarDataGridListaCompletaCruceros();
            this.chkBox_MostrarHorasCruceros.Checked = false;
        }
        #endregion

        #region Funcionalidades para el data grid
        /// <summary>
        /// Carga el data grid con las lista de cruceros
        /// </summary>
        private void CargarDataGridListaCompletaCruceros()
        {
            this.dgv_ListadoCruceros.DataSource = null;
            this.dgv_ListadoCruceros.DataSource = BaseDeDatos.ListaCruceros;
        }
        /// <summary>
        /// Carga el data grid con las lista de cruceros y sus horas viajadas
        /// </summary>
        private void CargarDataGridListaCrucerosCantidadHoras()
        {
            this.dgv_ListadoCruceros.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = BaseDeDatos.DiccionarioHorasViajadasPorCrucero;
            this.dgv_ListadoCruceros.DataSource = bd;
            this.dgv_ListadoCruceros.Columns[0].HeaderText = "Crucero";
            this.dgv_ListadoCruceros.Columns[1].HeaderText = "Horas viajadas";
        }
        #endregion

        #region Evento del checkbox Mostrar Horas Cruceros
        private void chkBox_MostrarHorasCruceros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_MostrarHorasCruceros.Checked)
            {
                this.CargarDataGridListaCrucerosCantidadHoras();
            }
            else
            {
                this.CargarDataGridListaCompletaCruceros();
            }
        }
        #endregion

    }
}
