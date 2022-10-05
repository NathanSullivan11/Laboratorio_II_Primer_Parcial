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
    public partial class FrmListadoCruceros : Form
    {
        public FrmListadoCruceros()
        {
            InitializeComponent();
        }

        private void FrmListadoCruceros_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.CargarDataGridListaCompletaCruceros();
            this.chkBoxHorasPorCrucero.Checked = false;
        }

        private void CargarDataGridListaCompletaCruceros()
        {
            this.dataGridView1.DataSource = null;
           this.dataGridView1.DataSource = BaseDeDatos.ListaCruceros;
        }

        private void CargarDataGridListaCrucerosCantidadHoras()
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = BaseDeDatos.DiccionarioHorasViajadasPorCrucero; 
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[0].HeaderText = "Crucero";
            this.dataGridView1.Columns[0].HeaderText = "Hs de viaje";
 
        }

        private void chkBoxHorasPorCrucero_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxHorasPorCrucero.Checked)
            {
                this.CargarDataGridListaCrucerosCantidadHoras();
            }
            else
            {
                this.CargarDataGridListaCompletaCruceros();
            }
        }
    }
}
