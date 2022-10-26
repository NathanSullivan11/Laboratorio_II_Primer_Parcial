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
    public partial class FrmViajesHistoricos : Form
    {
        private List<Viaje> viajesTotales;

        #region Constructor y evento Load
        public FrmViajesHistoricos()
        {
            InitializeComponent();
        }
      
        private void FrmViajesHistoricos_Load(object sender, EventArgs e)
        {
            viajesTotales = new List<Viaje>(BaseDeDatos.ListaViajesFinalizados.Concat(BaseDeDatos.ListaViajesActivos));

            this.dgv_ListadoViajesHistoricos.DataSource = null;
            this.dgv_ListadoViajesHistoricos.DataSource = viajesTotales;
            this.Dock = DockStyle.Fill;
        }
        #endregion

        #region Eventos para mostrar las recaudaciones
        private void btnRecaudacionTotal_Click(object sender, EventArgs e)
        {
            this.lblRecaudacionTotal.Text = $"${Sistema.CalcularRecaudacionTotalViajes()}";
        }

        private void btnRecaudacionPorServicio_Click(object sender, EventArgs e)
        {
            this.lblRecaudacionPorServicio.Text = $"Regional: ${Sistema.CalcularRecaudacionTotalViajesRegionales()}" +
                $"\nExtra regional: ${Sistema.CalcularRecaudacionTotalViajesExtraRegionales()}";
        }
        #endregion
    }
}
