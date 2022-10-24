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
        private Viaje esteViaje;

        public FrmListadoPasajeros(Viaje esteViaje)
        {
            InitializeComponent();
            this.esteViaje = esteViaje;
        }

        private void cmbOpcionesFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_ContenedorBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmListadoPasajeros_Load(object sender, EventArgs e)
        {

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
    }
}
