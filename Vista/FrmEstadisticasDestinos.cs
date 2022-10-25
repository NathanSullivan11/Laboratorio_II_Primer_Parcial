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

        public FrmEstadisticasDestinos()
        {
            InitializeComponent();
        }

        protected override void FrmClientes_Load(object sender, EventArgs e)
        {
            this.EstablecerPredeterminados();
            this.Dock = DockStyle.Fill;
        }

        private void EstablecerPredeterminados()
        {
            this.CargarComboBoxFiltros();
            this.comboBox1.SelectedIndex = 0;

            this.rbtnOrdenAscendente.Checked = true;

            AsignarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(0));
            
        }

        private void AsignarDiccionarioFacturacionDataGrid(Dictionary<string, float> diccionarioFacturacion)
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = diccionarioFacturacion;
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[0].HeaderText = "Destino";
            this.dataGridView1.Columns[1].HeaderText = "Facturado";
        }

        private void AsignarDiccionarioCantidadViajesDataGrid(Dictionary<string, int> diccionarioCantidadViajes)
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = diccionarioCantidadViajes;
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[0].HeaderText = "Destino";
            this.dataGridView1.Columns[1].HeaderText = "Viajes";
        }

        protected override void CargarComboBoxFiltros()
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Facturación");
            this.comboBox1.Items.Add("pedidos de viajes");
            this.comboBox1.SelectedIndex = 0;
        }

        protected override void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeleccionada = this.comboBox1.SelectedIndex;
        }

        protected override void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0)
            {
                if (rbtnOrdenAscendente.Checked)
                {
                    AsignarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(0));
                }
                else if (rbtnOrdenDescendente.Checked)
                {
                    AsignarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(1));
                }
            }
            else
            {
                if (rbtnOrdenAscendente.Checked)
                {
                    AsignarDiccionarioCantidadViajesDataGrid(Sistema.OrdenarDiccionarioDestinosCantidadViajes(0));
                }
                else if (rbtnOrdenDescendente.Checked)
                {
                    AsignarDiccionarioCantidadViajesDataGrid(Sistema.OrdenarDiccionarioDestinosCantidadViajes(1));
                }
            }
        }
    }
}
