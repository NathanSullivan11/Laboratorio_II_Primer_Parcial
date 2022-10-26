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
    public partial class FrmListadoPasajeros : Form
    {
        #region Atributos
        private Viaje esteViaje;
        private int opcionSeleccionadaFiltrado;
        #endregion

        #region Constructor y evneto Load
        public FrmListadoPasajeros(Viaje esteViaje)
        {
            InitializeComponent();
            this.esteViaje = esteViaje;
        }

        private void FrmListadoPasajeros_Load(object sender, EventArgs e)
        {
            this.ActualizarListadoPasajeros();          
            this.CargarOpcionesFiltrado();
            this.chkBoxFiltroPremium.Visible = false;
        }
        #endregion

        #region Configuraciones para instanciar
        private void ActualizarListadoPasajeros()
        {
            this.dgvListadoPasajeros.DataSource = null;
            this.dgvListadoPasajeros.DataSource = esteViaje.ObtenerListaPasajeros();
        }

        private void CargarOpcionesFiltrado()
        {
            string[] opciones = { "Sin filtro", "Nombre", "Apellido", "Pasaporte", "Edad" };
            this.cmbOpcionesFiltrado.DataSource = opciones;
            this.cmbOpcionesFiltrado.SelectedItem = "Sin filtro";
        }
        #endregion

        #region Funcionalidad para el filtrado
        /// <summary>
        /// Prepara el textbox segun el criterio de filtrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOpcionesFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chkBoxFiltroPremium.Visible = true;
            this.txtFiltro.Visible = true;
            switch (this.cmbOpcionesFiltrado.SelectedItem)
            {
                case "Sin filtro":
                    this.txtFiltro.PlaceholderText = string.Empty;
                    this.txtFiltro.Visible = false;
                    this.ActualizarListadoPasajeros();
                    break;
                case "Nombre":
                    this.txtFiltro.PlaceholderText = "Ingrese nombre";
                    this.opcionSeleccionadaFiltrado = 1;
                    break;
                case "Apellido":
                    this.txtFiltro.PlaceholderText = "Ingrese apellido";
                    this.opcionSeleccionadaFiltrado = 2;
                    break;
                case "Pasaporte":
                    this.txtFiltro.PlaceholderText = "Ingrese nro pasaporte";
                    this.opcionSeleccionadaFiltrado = 3;
                    break;
                case "Edad":
                    this.txtFiltro.PlaceholderText = "Ingrese edad";
                    this.opcionSeleccionadaFiltrado = 4;
                    break;
            }
            if (!string.IsNullOrEmpty(this.txtFiltro.Text))
            {
                this.FiltrarSegunOpcion();
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFiltro.Text))
            {
                this.ActualizarListadoPasajeros();
            }
            else
            {
                this.FiltrarSegunOpcion();
            }
        }

        private void FiltrarSegunOpcion()
        {
            switch (this.opcionSeleccionadaFiltrado)
            {
                case 1:
                    this.FiltrarPorNombre();
                    break;
                case 2:
                    this.FiltrarPorApellido();
                    break;
                case 3:
                    this.FiltrarPorPasaporte();
                    break;
                case 4:
                    this.FiltrarPorEdad();
                    break;
            }
        }

        private void FiltrarPorNombre()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorNombre(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvListadoPasajeros.DataSource = null;
            this.dgvListadoPasajeros.DataSource = listaAux;
        }

        private void FiltrarPorApellido()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorApellido(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvListadoPasajeros.DataSource = null;
            this.dgvListadoPasajeros.DataSource = listaAux;
        }

        private void FiltrarPorPasaporte()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorPasaporte(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvListadoPasajeros.DataSource = null;
            this.dgvListadoPasajeros.DataSource = listaAux;
        }

        private void FiltrarPorEdad()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorEdad(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvListadoPasajeros.DataSource = null;
            this.dgvListadoPasajeros.DataSource = listaAux;
        }
        #endregion

        #region Funcionalidades varias
        private void chkBoxFiltroPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesFiltrado.SelectedItem.ToString() == "Sin filtro" || cmbOpcionesFiltrado.SelectedItem == null)
            {
                if (chkBoxFiltroPremium.Checked)
                {
                    this.dgvListadoPasajeros.DataSource = null;
                    this.dgvListadoPasajeros.DataSource = Sistema.FiltrarPasajerosPremium(esteViaje);
                }

                this.ActualizarListadoPasajeros();
            }
            else
            {
                this.FiltrarSegunOpcion();
            }
        }

        private void btnInfoCrucero_Click(object sender, EventArgs e)
        {
            StringBuilder informacionCrucero = new StringBuilder();

            informacionCrucero.AppendLine(this.esteViaje.ObtenerDatosBasicosCrucero());

            MessageBox.Show(informacionCrucero.ToString(), "Información crucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbox_Regresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
