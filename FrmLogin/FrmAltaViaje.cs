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
        List<Crucero> crucerosDisponibles;

        public FrmAltaViaje()
        {
            InitializeComponent();
            crucerosDisponibles = new List<Crucero>();
        }

        private void FrmAltaViaje_Load(object sender, EventArgs e)
        {
            crucerosDisponibles = Sistema.ObtenerCrucerosDisponibles();

            if (crucerosDisponibles.Count > 0)
            {
                this.cmbCrucero.DataSource = crucerosDisponibles;
                this.cmbOrigen.DataSource = Enum.GetValues(typeof(EOrigen));
            }
            else
            {
                MessageBox.Show(this, "Todos los cruceros estan ocupados, no se puede agregar mas viaje", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                 
             }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            if (this.rbtnRegional.Checked)
            {
                EDestinoRegional destino = (EDestinoRegional)this.cmbDestino.SelectedItem;
                this.auxViaje = new Viaje((Crucero)this.cmbCrucero.SelectedItem, (EOrigen)this.cmbOrigen.SelectedItem, this.dateTimePicker1.Value, true, EEstadoViaje.Disponible, destino);
                
            }
            else
            {
                EDestinoExtraRegional destino = (EDestinoExtraRegional)this.cmbDestino.SelectedItem;
                this.auxViaje = new Viaje((Crucero)this.cmbCrucero.SelectedItem, (EOrigen)this.cmbOrigen.SelectedItem, this.dateTimePicker1.Value, false, EEstadoViaje.Disponible, destino);
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
