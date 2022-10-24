using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmViajes : Form
    {
        private Viaje viajeSeleccionado;

        public FrmViajes()
        {
            InitializeComponent();
            this.ActualizarListaViajes();
        }

        private void ActualizarListaViajes()
        {
            this.dgvViajesActivos.DataSource = null;
            this.dgvViajesActivos.DataSource = BaseDeDatos.ListaViajesActivos;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_ListarPasajeros_Click(object sender, EventArgs e)
        {
            int index = this.dgvViajesActivos.CurrentCell.RowIndex;
            viajeSeleccionado = BaseDeDatos.ListaViajesActivos.ElementAt(index);

            if (index > -1)
            {
                FrmListadoPasajeros formListarPasajeros = new FrmListadoPasajeros(viajeSeleccionado);
                formListarPasajeros.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar un viaje antes...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            if (Sistema.ObtenerCrucerosDisponibles().Count <= 0)
            {
                MessageBox.Show(this, "Todos los cruceros estan ocupados, no se pueden agregar mas viaje", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FrmAltaViaje formAltaViaje = new FrmAltaViaje();

                if (formAltaViaje.ShowDialog() == DialogResult.OK)
                {
                    this.AgregarViaje(formAltaViaje.auxViaje);
                }
            }
        }


        private void AgregarViaje(Viaje viajeAgregar)
        {
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

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            //Viaje esteViaje = BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex);

            /* FrmVentaPasaje formVenta = new FrmVentaPasaje(esteViaje);

             if (formVenta.ShowDialog() == DialogResult.OK)
             {
                 List<Pasajero> pasajeros = formVenta.listaPasajerosCargado;
                 esteViaje.AgregarGrupoFamiliar(pasajeros, Sistema.EsGrupoFamiliarPremium(pasajeros));
                 MessageBox.Show("Venta efectuada CORRECTAMENTE!", "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }*/
        }

        private void btnBajaViaje_Click(object sender, EventArgs e)
        {
            FrmBajaViaje formBaja = new (BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex));

             if (formBaja.ShowDialog() == DialogResult.OK)
             {
                 MessageBox.Show("Viaje dado de baja!");
                 this.ActualizarListaViajes();
             }
        }
    }
}
