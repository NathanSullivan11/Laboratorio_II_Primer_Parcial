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
    public partial class FrmListadoViajes : Form
    {
        List<Viaje> viajesTotales;
        public FrmListadoViajes()
        {
            InitializeComponent();
            
        }

        private void FrmListadoViajes_Load(object sender, EventArgs e)
        {
            viajesTotales = new List<Viaje>(BaseDeDatos.ListaViajesFinalizados.Concat(BaseDeDatos.ListaViajesActivos));

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = viajesTotales;
            this.Dock = DockStyle.Fill;
        }

        private void btnRecaudacionTotal_Click(object sender, EventArgs e)
        {
            this.lblRecaudacionTotal.Text = $"Recaudación total: ${Sistema.CalcularRecaudacionTotalViajes()}";
        }

        private void btnRecaudacionPorServicio_Click(object sender, EventArgs e)
        {
            this.lblRecaudacionPorServicio.Text = $"Recaudación regional: ${Sistema.CalcularRecaudacionTotalViajesRegionales()}" +
                $"\nRecaudación Extra regional: ${Sistema.CalcularRecaudacionTotalViajesExtraRegionales()}";
        }
    }
}
