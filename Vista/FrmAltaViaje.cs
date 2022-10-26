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
        List<Crucero> cruceros;

        public FrmAltaViaje()
        {
            InitializeComponent();
        }

        #region Configuraciones para instanciar
        private void FrmAltaViaje_Load(object sender, EventArgs e)
        {
            this.cmbOrigen.DataSource = Enum.GetValues(typeof(EOrigen));
            this.rbtnRegional.Checked = true;
            this.CargarComboBoxCruceros();
        }

        protected void CargarComboBoxCruceros()
        {
            cruceros = new List<Crucero>();
            cruceros = BaseDeDatos.ListaCruceros;
            foreach (Crucero auxCrucero in BaseDeDatos.ListaCruceros)
            {
                this.cmbCrucero.Items.Add(auxCrucero.Matricula);
            }
            this.cmbCrucero.SelectedIndex = 0;
        }
        #endregion

        #region Botones Agregar y Cancelar
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            this.AgregarViaje();
        }
        #endregion

        #region Funcionalidades para agregar un viaje
        /// <summary>
        /// Agrega el viaje cargado dependiendo del destino
        /// </summary>
        private void AgregarViaje()
        {
            Viaje viajeAgregar;
            Crucero cruceroElegido = BaseDeDatos.ListaCruceros[this.cmbCrucero.SelectedIndex];
            DateTime fechaElegida = this.dtp_FechaSalida.Value;

            if (!cruceroElegido.CruceroEstaEnUso() || Sistema.CruceroDisponibleEnEsasFechas(cruceroElegido, fechaElegida))
            {
                viajeAgregar = this.InstanciarViajeSolicitado(cruceroElegido, fechaElegida);
                BaseDeDatos.ListaViajesActivos.Add(viajeAgregar);

                MessageBox.Show($"Se agrego!\n{viajeAgregar.ToString()}");
            }
            else
            {
                MessageBox.Show($"El crucero ya tiene un viaje programada en esas fechas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
        }

        private Viaje InstanciarViajeSolicitado(Crucero cruceroElegido, DateTime fechaElegida)
        {
            Viaje auxViaje;
            if (this.rbtnRegional.Checked)
            {
                auxViaje = new Viaje(cruceroElegido, (EOrigen)this.cmbOrigen.SelectedItem, fechaElegida, false, EEstadoViaje.Disponible, (EDestinoRegional)this.cmbDestino.SelectedItem);
            }
            else
            {
                auxViaje = new Viaje(cruceroElegido, (EOrigen)this.cmbOrigen.SelectedItem, fechaElegida, false, EEstadoViaje.Disponible, (EDestinoExtraRegional)this.cmbDestino.SelectedItem);
            }
            return auxViaje;
        }
        #endregion

        #region Eventos radiobuttons
        /// <summary>
        /// Carga los destinos regionales en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnRegional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnRegional.Checked)
            {
                this.cmbDestino.DataSource = Enum.GetValues(typeof(EDestinoRegional));
            }
        }
        /// <summary>
        /// Carga los destinos extra regionales en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnExtraregional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnExtraregional.Checked)
            {
                this.cmbDestino.DataSource = Enum.GetValues(typeof(EDestinoExtraRegional));
            }
        }
        #endregion
    }
}
