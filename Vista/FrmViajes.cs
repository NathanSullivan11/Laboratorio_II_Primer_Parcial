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

        #region Constructor
        public FrmViajes()
        {
            InitializeComponent();
            this.ActualizarListaViajes();
        }
        #endregion

        #region Configuracion de datagrid
        private void ActualizarListaViajes()
        {
            this.dgvViajesActivos.DataSource = null;
            this.dgvViajesActivos.DataSource = BaseDeDatos.ListaViajesActivos;
        }
        #endregion

        #region Evento para listar los pasajeros 
        private void btn_ListarPasajeros_Click(object sender, EventArgs e)
        {
            int index = this.dgvViajesActivos.CurrentCell.RowIndex;
            viajeSeleccionado = BaseDeDatos.ListaViajesActivos.ElementAt(index);

            if (index > -1)
            {
                FrmListadoPasajeros formListarPasajeros = new FrmListadoPasajeros(BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex));
                formListarPasajeros.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar un viaje antes...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Evento para vender pasajes
        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            Viaje esteViaje = BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex);

            FrmVentaPasaje formVenta = new FrmVentaPasaje(esteViaje);

             if (formVenta.ShowDialog() == DialogResult.OK)
             {
                 /*List<Pasajero> pasajeros = formVenta.listaPasajerosCargado;
                 esteViaje.AgregarGrupoFamiliar(pasajeros, Sistema.EsGrupoFamiliarPremium(pasajeros));
                 MessageBox.Show("Venta efectuada CORRECTAMENTE!", "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
             }
        }
        #endregion

        #region Evento para dar de alta un nuevo viaje
        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            if (Sistema.ObtenerCrucerosDisponibles().Count <= 0)
            {
                MessageBox.Show(this, "Todos los cruceros estan ocupados, no se pueden agregar mas viaje", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FrmAltaViaje formAltaViaje = new FrmAltaViaje();

                if(formAltaViaje.ShowDialog() == DialogResult.OK)
                {
                    this.ActualizarListaViajes();

                }
            }
        }
        #endregion        

        #region Evento para dar de baja un viaje
        private void btnBajaViaje_Click(object sender, EventArgs e)
        {
            FrmBajaViaje formBaja = new FrmBajaViaje(BaseDeDatos.ListaViajesActivos.ElementAt(this.dgvViajesActivos.CurrentCell.RowIndex));

             if (formBaja.ShowDialog() == DialogResult.OK)
             {
                 MessageBox.Show("Viaje dado de baja!");
                 this.ActualizarListaViajes();
             }
        }
        #endregion

        #region Evento para cerrar el formulario
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
