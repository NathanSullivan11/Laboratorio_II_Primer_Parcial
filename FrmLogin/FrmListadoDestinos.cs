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
    public partial class FrmListadoDestinos : Form
    {
        private int opcionSeleccionada;

        public FrmListadoDestinos()
        {
            InitializeComponent();
            
        }

        private void FrmListadoDestinos_Load(object sender, EventArgs e)
        {
            this.EstablecerPredeterminados();
            this.Dock = DockStyle.Fill;
        }

        private void EstablecerPredeterminados()
        {
            this.CargarOpcionesComboBox();
            this.cmbBoxFiltro.SelectedIndex = 0;
          
            this.rbtnOrdenAscendente.Checked = true;

            AsignarDiccionarioFacturacionDataGrid(Sistema.OrdenarDiccionarioDestinosFacturacion(0));
            this.dataGridView1.Columns[0].HeaderText = "Destino";
        }


        private void CargarOpcionesComboBox()
        {
            this.cmbBoxFiltro.Items.Clear();
            this.cmbBoxFiltro.Items.Add("Facturación");
            this.cmbBoxFiltro.Items.Add("Mas pedidos");
            this.cmbBoxFiltro.SelectedIndex = 0;
        }


        private void cmbBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeleccionada = cmbBoxFiltro.SelectedIndex;
        }

        private void AsignarDiccionarioFacturacionDataGrid(Dictionary<string, float> diccionarioFacturacion)
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = diccionarioFacturacion;
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[1].HeaderText = "Facturado";

        }

        private void AsignarDiccionarioCantidadViajesDataGrid(Dictionary<string, int> diccionarioCantidadViajes)
        {
            this.dataGridView1.DataSource = null;
            BindingSource bd = new BindingSource();
            bd.DataSource = diccionarioCantidadViajes;
            this.dataGridView1.DataSource = bd;
            this.dataGridView1.Columns[1].HeaderText = "Viajes";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
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
                if(rbtnOrdenAscendente.Checked)
                {
                    AsignarDiccionarioCantidadViajesDataGrid(Sistema.OrdenarDiccionarioDestinosCantidadViajes(0));
                }
                else if (rbtnOrdenDescendente.Checked)
                {
                    AsignarDiccionarioCantidadViajesDataGrid(Sistema.OrdenarDiccionarioDestinosCantidadViajes(1));
                }
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
