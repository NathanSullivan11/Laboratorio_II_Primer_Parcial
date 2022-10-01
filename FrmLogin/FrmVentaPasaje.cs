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
    public partial class FrmVentaPasaje : Form
    {
        private Viaje viajeDelPasajeAVender;
        public Pasajero pasajeroCargado;
        public List<Pasajero> grupoFamiliarCargado;
        
        public FrmVentaPasaje(Viaje viajeDelPasajeAVender)
        {
            InitializeComponent();
            this.viajeDelPasajeAVender = viajeDelPasajeAVender;
        }

        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            this.ControlarSeleccionClienteExistente(false);
            this.ControlarCamposIngresoCliente(false, false);
        }

        private void CargarDataGridClientes()
        {
            this.dgvClientesExistentes.DataSource = null;
            this.dgvClientesExistentes.DataSource = BaseDeDatos.ListaClientes;
        }

        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            this.CargarDataGridClientes();
            this.ControlarSeleccionClienteExistente(true);           
            this.ControlarCamposIngresoCliente(false, true);
        }

        private void ControlarCamposIngresoCliente(bool disponible, bool vaciarlos)
        {
            foreach(Control controls in this.gboxDatosCliente.Controls)
            {                
                if(controls is TextBox textBox)
                {
                    if(vaciarlos)
                    {
                        textBox.Text = string.Empty;
                    }
                    textBox.Enabled = disponible;
                }
                else if (controls is NumericUpDown numerico)
                {
                    if (vaciarlos)
                    {
                        numerico.Value = 0;
                    }
                    numerico.Enabled = disponible;   
                }
                else if (controls is Button boton)
                {
                    boton.Enabled = disponible;
                }
            }
        }

        private void ControlarSeleccionClienteExistente(bool seMuestra)
        {

            this.btnSeleccionarCliente.Enabled = seMuestra;
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            this.ControlarCamposIngresoCliente(true, true);
            this.ControlarSeleccionClienteExistente(false);
            this.dgvClientesExistentes.DataSource = null;
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            int index = this.dgvClientesExistentes.CurrentCell.RowIndex;

            Cliente clienteSeleccionado = BaseDeDatos.ListaClientes.ElementAt(index);
            this.ControlarCamposIngresoCliente(false,true);
            this.CargarDatosClienteExistente(clienteSeleccionado);
            
        }

        private void CargarDatosClienteExistente(Cliente auxCliente)
        {
            this.txtNombreCliente.Text = auxCliente.Nombre;
            this.txtApellidoCliente.Text = auxCliente.Apellido;
            this.txtDniCliente.Text = auxCliente.Dni.ToString();
            this.nudEdadCliente.Value = auxCliente.Edad;
        }

        private void ControlarCantidadMaletasDisponibles(bool esPremium)
        {
            List<int> cantidadMaletasDisponibles = new List<int>();
            cantidadMaletasDisponibles.Add(0);
            cantidadMaletasDisponibles.Add(1);
            this.cmbCantidadMaletas.SelectedItem = cantidadMaletasDisponibles[0];

            if(esPremium)
            {
                cantidadMaletasDisponibles.Add(2);
                this.nudMaleta2.Visible = true;
            }
            else
            {
                this.nudMaleta2.Visible = false;
                this.lblPesoKgMaleta2.Visible = false;
            }

            this.cmbCantidadMaletas.DataSource = cantidadMaletasDisponibles;
        }

        private void rbtnPasajePremium_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlarCantidadMaletasDisponibles(true);
        }

        private void rbtnPasajeTurista_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlarCantidadMaletasDisponibles(false);
        }

        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {
            Equipaje auxEquipaje;

            bool equipajeDeMano = this.chkBoxEquipajeDeMano.Checked;
            int cantidadMaletas = (int)this.cmbCantidadMaletas.SelectedItem;
            int pesoEnKg = 0;
            if(this.rbtnPasajePremium.Checked)
            {
                pesoEnKg = (int)(this.nudMaleta1.Value + this.nudMaleta2.Value);           
            }
            else if(this.rbtnPasajeTurista.Checked)
            {
                pesoEnKg = (int)this.nudMaleta1.Value;
            }

            auxEquipaje = new Equipaje(equipajeDeMano, pesoEnKg, cantidadMaletas);
            MessageBox.Show(auxEquipaje.ToString());
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.lblMensajeErrorDatosCliente.Visible = false;
            if (Validador.EsValidoNombre(this.txtNombreCliente.Text) && Validador.EsValidoNombre(this.txtApellidoCliente.Text)
                && Validador.EsValidoDni(this.txtDniCliente.Text) && this.nudEdadCliente.Value != 0)
            {
                Cliente clienteNuevo = Sistema.AgregarCliente(new Cliente(this.txtNombreCliente.Text, this.txtApellidoCliente.Text, Int32.Parse(this.txtDniCliente.Text), (int)this.nudEdadCliente.Value, BaseDeDatos.ListaClientes.Count + 1));
                if (clienteNuevo != null)
                {
                    this.lblMensajeErrorDatosCliente.Visible = false;
                    MessageBox.Show(clienteNuevo.ToString());
                }
                else
                {
                    this.MostrarMensajeErrorIngresoClienteNuevo("ERROR: Este cliente ya existe");
                }
            }
            else
            {
                this.MostrarMensajeErrorIngresoClienteNuevo("ERROR: Datos ingresados inválidos");
            }
            
        }

        private void MostrarMensajeErrorIngresoClienteNuevo(string mensaje)
        {
            this.lblMensajeErrorDatosCliente.Text = mensaje;
            this.lblMensajeErrorDatosCliente.Visible = true;
        }

        private void btnCargarPasaporte_Click(object sender, EventArgs e)
        {

        }
    }
}
