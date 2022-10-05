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
    public partial class FrmInspeccionViaje : Form
    {
        private Viaje esteViaje;
        private FrmViajesActivos formViajesActivos;

        private int opcionSeleccionadaFiltrado;
        public FrmInspeccionViaje(Viaje esteViaje, FrmViajesActivos formViajesActivos)
        {
            InitializeComponent();
            this.esteViaje = esteViaje;
            this.formViajesActivos = formViajesActivos;
        }

        private void FrmInspeccionViaje_Load(object sender, EventArgs e)
        {
            
            this.CargarDatosCrucero();
            this.CargarOpcionesFiltrado();
        }

        private void ActualizarDataGrid()
        {
            this.dgvPasajerosDelViaje.DataSource = null;
            this.dgvPasajerosDelViaje.DataSource = esteViaje.ObtenerListaPasajeros();
        }

        private void CargarOpcionesFiltrado()
        {
            string[] opciones = {"Sin filtro", "Nombre", "Apellido", "Pasaporte", "Edad" };

            this.cmbOpcionesFiltrado.DataSource = opciones;
        }

        private void CargarDatosCrucero()
        {
            this.lblNombreCrucero.Text = $"Nombre: {this.esteViaje.Crucero}";
            this.lblCapacidadBodega.Text = this.esteViaje.KgBodega;
            this.lblCamarotesPremium.Text = $"Camarotes premium en uso: {this.esteViaje.ObtenerListaCamarotesPremium().Count}";
            this.lblCamarotesTurista.Text = $"Camarotes turista en uso: {this.esteViaje.ObtenerListaCamarotesTurista().Count}";
            this.lblContieneCasino.Text = $"Cantidad de casinos: {this.esteViaje.ObtenerCrucero().CantidadCasinos}";
            this.lblSalonesCrucero.Text = $"Salones: {this.esteViaje.ObtenerCrucero().ListaSalones}";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbOpcionesFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFiltro.Visible = true;
            switch(this.cmbOpcionesFiltrado.SelectedItem)
            {
                case "Sin filtro":
                    this.txtFiltro.PlaceholderText = string.Empty;
                    this.txtFiltro.Visible = false;
                    this.ActualizarDataGrid();
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
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFiltro.Text))
            {
                this.ActualizarDataGrid();
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

            this.dgvPasajerosDelViaje.DataSource = null;
            this.dgvPasajerosDelViaje.DataSource = listaAux;
        }
        private void FiltrarPorApellido()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorApellido(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvPasajerosDelViaje.DataSource = null;
            this.dgvPasajerosDelViaje.DataSource = listaAux;
        }
        private void FiltrarPorPasaporte()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorPasaporte(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvPasajerosDelViaje.DataSource = null;
            this.dgvPasajerosDelViaje.DataSource = listaAux;
        }
        private void FiltrarPorEdad()
        {
            List<Pasajero> listaAux = Sistema.FiltrarPasajerosPorEdad(this.esteViaje, this.txtFiltro.Text, this.chkBoxFiltroPremium.Checked);

            this.dgvPasajerosDelViaje.DataSource = null;
            this.dgvPasajerosDelViaje.DataSource = listaAux;
        }

        private void chkBoxFiltroPremium_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxFiltroPremium.Checked)
            {
                if(cmbOpcionesFiltrado.SelectedItem.ToString() == "Sin filtro")
                {
                    this.dgvPasajerosDelViaje.DataSource = null;
                    this.dgvPasajerosDelViaje.DataSource = Sistema.FiltrarPasajerosPremium(esteViaje);
                }
                else
                {
                    this.FiltrarSegunOpcion();
                }                     
            }
            else
            {
                if (cmbOpcionesFiltrado.SelectedItem.ToString() == "Sin filtro")
                {
                    this.ActualizarDataGrid();
                }
                else
                {
                    this.FiltrarSegunOpcion();
                }
                
            }
        }
    }
}
