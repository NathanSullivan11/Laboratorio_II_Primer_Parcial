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
    public partial class FrmViajesActivos : Form
    {
        private int banderaSeleccionoUnViaje = 0;
        private Viaje viajeSeleccionado;
        public FrmViajesActivos()
        {
            InitializeComponent();
        }

        private void FrmViajesActivos_Load(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
          //  bs.DataSource = BaseDeDatos.ListaViajesActivos.ElementAt(0);
            this.dgvViajesActivos.DataSource = (List<Viaje>)BaseDeDatos.ListaViajesActivos;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvViajesActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            viajeSeleccionado = BaseDeDatos.ListaViajesActivos.ElementAt(index);
        }

        private void btnInspeccionarViaje_Click(object sender, EventArgs e)
        {
            int index = this.dgvViajesActivos.CurrentCell.RowIndex;
            viajeSeleccionado = BaseDeDatos.ListaViajesActivos.ElementAt(index);

            if (index > -1)
            {
                FrmInspeccionViaje formInspeccion = new FrmInspeccionViaje(viajeSeleccionado, this);
          
                formInspeccion.ShowDialog();
            
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar un viaje antes...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            FrmAltaViaje formAltaViaje = new FrmAltaViaje();
            
            if(formAltaViaje.ShowDialog() == DialogResult.OK)
            {
                
                Viaje viajeAgregar = formAltaViaje.auxViaje;
                BaseDeDatos.ListaViajesActivos.Add(viajeAgregar);
                MessageBox.Show($"Se agrego!\n{viajeAgregar.ToString()}");
                this.ActualizarListaViajes();

            }
        }
        private void ActualizarListaViajes()
        {
            this.dgvViajesActivos.DataSource = null;
            this.dgvViajesActivos.DataSource = (List<Viaje>)BaseDeDatos.ListaViajesActivos;
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            FrmVentaPasaje formVenta = new FrmVentaPasaje(BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex));

            formVenta.ShowDialog();
        }
    }
}
