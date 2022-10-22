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
    public partial class FrmViajes : Form
    {
        //private Viaje viajeSeleccionado;

        public FrmViajes()
        {
            InitializeComponent();

        }

        private void FrmViajesActivos_Load(object sender, EventArgs e)
        {
            //this.dgvViajesActivos.DataSource = (List<Viaje>)BaseDeDatos.ListaViajesActivos;
            this.Dock = DockStyle.Fill;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnInspeccionarViaje_Click(object sender, EventArgs e)
        {
            /*int index = this.dgvViajesActivos.CurrentCell.RowIndex;
            viajeSeleccionado = BaseDeDatos.ListaViajesActivos.ElementAt(index);

            if (index > -1)
            {
                FrmInspeccionViaje formInspeccion = new FrmInspeccionViaje(viajeSeleccionado, this);

                formInspeccion.ShowDialog();

            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar un viaje antes...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            /*if (Sistema.ObtenerCrucerosDisponibles().Count <= 0)
            {
                MessageBox.Show(this, "Todos los cruceros estan ocupados, no se pueden agregar mas viaje", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FrmAltaViaje formAltaViaje = new FrmAltaViaje();

                if (formAltaViaje.ShowDialog() == DialogResult.OK)
                {
                    Viaje viajeAgregar = formAltaViaje.auxViaje;
                    if (Sistema.CruceroDisponibleEnEsasFechas(viajeAgregar))
                    {
                        BaseDeDatos.ListaViajesActivos.Add(viajeAgregar);
                        MessageBox.Show($"Se agrego!\n{viajeAgregar.ToString()}");
                        this.ActualizarListaViajes();
                    }
                    else
                    {
                        MessageBox.Show($"El crucero ya tiene un viaje programada en esas fechas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }*/

        }

        private void ActualizarListaViajes()
        {
           /*this.dgvViajesActivos.DataSource = null;
            this.dgvViajesActivos.DataSource = (List<Viaje>)BaseDeDatos.ListaViajesActivos;*/
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            /*Viaje esteViaje = BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex);

            FrmVentaPasaje formVenta = new FrmVentaPasaje(esteViaje);

            if (formVenta.ShowDialog() == DialogResult.OK)
            {
                List<Pasajero> pasajeros = formVenta.listaPasajerosCargado;
                esteViaje.AgregarGrupoFamiliar(pasajeros, Sistema.EsGrupoFamiliarPremium(pasajeros));
                MessageBox.Show("Venta efectuada CORRECTAMENTE!", "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void btnBajaViaje_Click(object sender, EventArgs e)
        {
            /*FrmBajaViaje formBaja = new FrmBajaViaje(BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex));

            if (formBaja.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Viaje dado de baja!");
                this.ActualizarListaViajes();
            }*/
        }
    }
}
