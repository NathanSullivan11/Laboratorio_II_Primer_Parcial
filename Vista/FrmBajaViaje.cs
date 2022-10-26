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
    public partial class FrmBajaViaje : FrmAltaViaje
    {
        Viaje viajeADarDeBaja;

        #region Constructor y evento Load
        public FrmBajaViaje(Viaje viajeADarDeBaja)
        {
            InitializeComponent();
            this.viajeADarDeBaja = viajeADarDeBaja;
            
        }

        private void FrmBajaViaje_Load(object sender, EventArgs e)
        {
            this.SetearInformacionViaje();
            this.SetearControles();
        }
        #endregion

        #region Configuraciones para instanciar
        private void SetearInformacionViaje()
        {
            this.cmbCrucero.Text = this.viajeADarDeBaja.ObtenerCrucero().Matricula;
            this.dtp_FechaSalida.Value = DateTime.Parse(viajeADarDeBaja.FechaSalida);
            this.cmbOrigen.Text = viajeADarDeBaja.Origen;
            this.cmbDestino.Text = viajeADarDeBaja.Destino;

        }

        private void SetearControles()
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox cmbBox)
                {
                    cmbBox.Enabled = false;
                }
                else if (control is RadioButton rbtn)
                {
                    rbtn.Visible = false;
                }
                else if (control is DateTimePicker dtp)
                {
                    dtp.Enabled = false;
                }
            }
            this.btnAgregarViaje.Text = "Bajar viaje";
        }
        #endregion

        #region Override del boton heredado
        /// <summary>
        /// Se sobreescribe el evento de Agregar, para darle la funcion de dar de baja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas darlo de baja?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sistema.DarDeBajaUnViaje(viajeADarDeBaja);
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}
