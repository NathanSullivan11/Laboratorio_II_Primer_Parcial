using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
            this.CargarComboBoxFiltros();
            this.rbtnOrdenAscendente.Checked = true;
            this.Dock = DockStyle.Fill;
        }

        private void CargarComboBoxFiltros()
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Id");
            this.comboBox1.Items.Add("Cantidad de viajes");
            this.comboBox1.Items.Add("Dni");

            this.comboBox1.SelectedIndex = 0;
        }

        protected virtual void ActualizarDataGrid()
        {
          /*  this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BaseDeDatos.ListaClientes;*/
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            /*Sistema.OrdenarClientes(BaseDeDatos.ListaClientes, this.comboBox1.SelectedItem.ToString());

            if (rbtnOrdenDescendente.Checked)
            {
                BaseDeDatos.ListaClientes.Reverse();
            }
            this.ActualizarDataGrid();*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
