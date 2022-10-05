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
    public partial class FrmAltaViaje : Form
    {
        public Viaje auxViaje;
        List<Crucero> cruceros;

        public FrmAltaViaje()
        {
            InitializeComponent();
            this.cmbOrigen.DataSource = Enum.GetValues(typeof(EOrigen));
            this.rbtnRegional.Checked = true;
            this.CargarCrucerosEnComboBox();
        }

        private void CargarCrucerosEnComboBox()
        {
            cruceros = new List<Crucero>();
            cruceros = BaseDeDatos.ListaCruceros;
            foreach(Crucero auxCrucero in BaseDeDatos.ListaCruceros)
            {
                this.cmbCrucero.Items.Add(auxCrucero.Matricula);
            }
            this.cmbCrucero.SelectedIndex = 0;
                
        }

        private void FrmAltaViaje_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            /*if(((Button)sender).Text == "Agregar viaje")
            {
                AgregarViaje();
            }*/
            this.AgregarViaje();
        }
        
        private bool CamposEstanCompletados()
        {
            bool estanCompletos = true;
            if(string.IsNullOrEmpty(this.cmbCrucero.SelectedItem.ToString()))
            {
                estanCompletos = false;
            }
            return estanCompletos;
        }

        private void AgregarViaje()
        {
            if(!CamposEstanCompletados())
            {
                this.DialogResult = DialogResult.Cancel;
            }
            if (this.rbtnRegional.Checked)
            {
                EDestinoRegional destino = (EDestinoRegional)this.cmbDestino.SelectedItem;
                this.auxViaje = new Viaje(BaseDeDatos.ListaCruceros[this.cmbCrucero.SelectedIndex], (EOrigen)this.cmbOrigen.SelectedItem, this.dateTimePicker1.Value, true, EEstadoViaje.Disponible, destino);

            }
            else
            {
                EDestinoExtraRegional destino = (EDestinoExtraRegional)this.cmbDestino.SelectedItem;
                this.auxViaje = new Viaje(BaseDeDatos.ListaCruceros[this.cmbCrucero.SelectedIndex], (EOrigen)this.cmbOrigen.SelectedItem, this.dateTimePicker1.Value, false, EEstadoViaje.Disponible, destino);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void rbtnRegional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnRegional.Checked)
            {
                this.cmbDestino.DataSource = Enum.GetValues(typeof(EDestinoRegional));
            }
        }

        private void rbtnExtraregional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnExtraregional.Checked)
            {
                this.cmbDestino.DataSource = Enum.GetValues(typeof(EDestinoExtraRegional));
            }
        }
    }
}
