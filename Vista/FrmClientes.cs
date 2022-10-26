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
    public partial class FrmClientes : Form
    {
        #region Constructor y evento Load
        public FrmClientes()
        {
            InitializeComponent();
        }

        protected virtual void FrmClientes_Load(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
            this.CargarComboBoxFiltros();
            this.rbtnOrdenAscendente.Checked = true;
            this.Dock = DockStyle.Fill;
        }
        #endregion

        #region Configuracion para instanciar
        protected virtual void CargarComboBoxFiltros()
        {
            this.cmbBox_Opciones.Items.Clear();
            this.cmbBox_Opciones.Items.Add("Id");
            this.cmbBox_Opciones.Items.Add("Cantidad de viajes");
            this.cmbBox_Opciones.Items.Add("Dni");
            this.cmbBox_Opciones.SelectedIndex = 0;
        }

        protected virtual void ActualizarDataGrid()
        {            
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BaseDeDatos.ListaClientes;
        }
        #endregion

        #region Boton ordenar
        protected virtual void btnOrdenar_Click(object sender, EventArgs e)
        {
            Sistema.OrdenarClientes(BaseDeDatos.ListaClientes, this.cmbBox_Opciones.SelectedItem.ToString());

            if (rbtnOrdenDescendente.Checked)
            {
                BaseDeDatos.ListaClientes.Reverse();
            }
            this.ActualizarDataGrid();
        }
        #endregion

        #region Evento virtual
        /// <summary>
        /// Evento virtual para sobreescribir en los formularios derivados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void cmbBox_Opciones_SelectedIndexChanged(object sender, EventArgs e) { }
        #endregion
    }
}
