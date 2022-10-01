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
        Viaje esteViaje;
        FrmViajesActivos formViajesActivos;
        public FrmInspeccionViaje(Viaje esteViaje, FrmViajesActivos formViajesActivos)
        {
            InitializeComponent();
            this.esteViaje = esteViaje;
            this.formViajesActivos = formViajesActivos;
        }

        private void FrmInspeccionViaje_Load(object sender, EventArgs e)
        {
            this.dgvPasajerosDelViaje.DataSource = esteViaje.ObtenerListaPasajeros();
            this.CargarDatosCrucero();
        }

        private void CargarDatosCrucero()
        {
            this.lblNombreCrucero.Text = $"Nombre: {this.esteViaje.Crucero}";
            this.lblCapacidadBodega.Text = this.esteViaje.KgBodega;
            this.lblCamarotesPremium.Text = $"Camarotes premium en uso: {this.esteViaje.ObtenerCrucero().ObtenerListaCamarotesPremium().Count}";
            this.lblCamarotesTurista.Text = $"Camarotes turista en uso: {this.esteViaje.ObtenerCrucero().ObtenerListaCamarotesTurista().Count}";
            this.lblContieneCasino.Text = $"Cantidad de casinos: {this.esteViaje.ObtenerCrucero().CantidadCasinos}";
            this.lblSalonesCrucero.Text = $"Salones: {this.esteViaje.ObtenerCrucero().ListaSalones}";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
