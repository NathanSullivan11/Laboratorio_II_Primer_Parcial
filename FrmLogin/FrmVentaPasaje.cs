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
        public Pasajero pasajeroActual;
        public List<Pasajero> listaPasajerosCargado;
        private Equipaje equipajeActual = null;
        private Pasaporte pasaporteActual = null;
        private Cliente clienteActual = null;
        private float precioTotalAcumulado = 0;
        private float precioActual;
        private float precioActualFinal;

        public FrmVentaPasaje(Viaje viajeDelPasajeAVender)
        {
            InitializeComponent();
            this.viajeDelPasajeAVender = viajeDelPasajeAVender;
            this.listaPasajerosCargado = new List<Pasajero>();
        }

        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            this.ControlarSeleccionClienteExistente(false);
            this.ControlarCamposIngresoCliente(false, false);
            this.CargarComboBoxSexoPasaporte();
            ControlarCantidadMaletasDisponibles(false);
            this.nudMaleta2.Visible = false;
            this.CargarDatosCrucero();

        }

        #region Cliente
        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            this.CargarDataGridClientes();
            this.ControlarSeleccionClienteExistente(true);
            this.ControlarCamposIngresoCliente(false, true);
            this.ControlarFiltroPorDni(true);
        }

        private void CargarDataGridClientes()
        {
            this.dgvClientesExistentes.DataSource = null;
            this.dgvClientesExistentes.DataSource = BaseDeDatos.ListaClientes;
        }

        private void ControlarSeleccionClienteExistente(bool seMuestra)
        {
            this.btnSeleccionarCliente.Enabled = seMuestra;
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            this.ControlarCamposIngresoCliente(true, true);
            this.ControlarSeleccionClienteExistente(false);
            this.ControlarFiltroPorDni(false);
            this.dgvClientesExistentes.DataSource = null;
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            this.ControlarCamposIngresoCliente(false, false);
            Cliente clienteSeleccionado = (Cliente)this.dgvClientesExistentes.CurrentRow.DataBoundItem;
            if (clienteSeleccionado is null)
            {
                return;
            }
            this.CargarDatosCliente(clienteSeleccionado);


        }

        private void CargarDatosCliente(Cliente auxCliente)
        {
            this.txtNombreCliente.Text = auxCliente.Nombre;
            this.txtApellidoCliente.Text = auxCliente.Apellido;
            this.txtDniCliente.Text = auxCliente.Dni.ToString();
            this.nudEdadCliente.Value = auxCliente.Edad;
            this.txtClienteCargado.Text = auxCliente.ToString();
            this.clienteActual = auxCliente;

        }

        private void ControlarCamposIngresoCliente(bool disponible, bool vaciarlos)
        {
            foreach (Control controls in this.gboxDatosCliente.Controls)
            {
                if (controls is TextBox textBox)
                {
                    if (vaciarlos)
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

        private void ControlarFiltroPorDni(bool seMuestra)
        {
            this.lblBuscarPorDni.Visible = seMuestra;
            this.txtFiltroPorDni.Visible = seMuestra;
        }

        private void MostrarMensajeErrorIngresoClienteNuevo(string mensaje)
        {
            this.lblMensajeErrorDatosCliente.Text = mensaje;
            this.lblMensajeErrorDatosCliente.Visible = true;
        }
        #endregion


        #region Pasaporte

        private void CargarDatosPasaporte(Pasaporte pasaporte)
        {
            this.txtPasaporteCargado.Text = pasaporte.ToString();
            this.pasaporteActual = pasaporte;

        }

        private void btnCargarPasaporte_Click(object sender, EventArgs e)
        {
            this.lblMensajeErrorIngresoPasaporte.Visible = false;
            if (Validador.EsValidoNumeroPasaporte(this.txtNroPasaporte.Text) && (!string.IsNullOrEmpty(this.txtNacionalidadPasaporte.Text))
                && Pasaporte.EstaEnReglaPasaporte(this.dtpCaducidadPasaporte.Value))
            {                
                Pasaporte pasaporteCreado = new Pasaporte(this.txtNroPasaporte.Text, this.txtNacionalidadPasaporte.Text, (string)this.cmbSexoPasaporte.SelectedItem, this.dtpCaducidadPasaporte.Value);
                if(!Sistema.PasaporteEstaRepetido(pasaporteCreado, viajeDelPasajeAVender) || !this.PasaporteRepetidoEnListaCargada(pasaporteCreado))
                {
                    this.CargarDatosPasaporte(pasaporteCreado);
                }
                else
                {
                    this.MostrarMensajeErrorIngresoPasaporte("ERROR: Pasajero con mismo pasaporte");
                }
            }
            else
            {
                this.MostrarMensajeErrorIngresoPasaporte("ERROR: Dato/s inválido/s");
            }
        }

        private bool PasaporteRepetidoEnListaCargada(Pasaporte pasaporteCreado)
        {
            bool estaRepetido = false;

            foreach(Pasajero auxPasajero in this.listaPasajerosCargado)
            {
                if(auxPasajero.NumeroPasaporte == pasaporteCreado.Numero)
                {
                    estaRepetido = true;
                }
            }
            return estaRepetido;
        }

        private void MostrarMensajeErrorIngresoPasaporte(string mensaje)
        {
            this.lblMensajeErrorIngresoPasaporte.Visible = true;
            this.lblMensajeErrorIngresoPasaporte.Text = mensaje;
        }
        private void CargarComboBoxSexoPasaporte()
        {
            string[] sexos = { "Masculino", "Femenino", "No binario" };

            this.cmbSexoPasaporte.DataSource = sexos;
        }

        private void VaciarCamposIngresoPasaporte()
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is TextBox txtBox)
                {
                    txtBox.Text = string.Empty;
                }
                else if (control is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Today;
                }
            }
        }
        #endregion

        #region Equipaje
        private void ControlarCantidadMaletasDisponibles(bool esPremium)
        {
            List<int> cantidadMaletasDisponibles = new List<int>();
            cantidadMaletasDisponibles.Add(0);
            cantidadMaletasDisponibles.Add(1);

            if (esPremium)
            {
                cantidadMaletasDisponibles.Add(2);
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

        private void CargarDatosEquipaje(Equipaje equipaje)
        {
            this.txtEquipajeCargado.Text = equipaje.ToString();
            this.equipajeActual = equipaje;
        }

        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {
            Equipaje auxEquipaje;

            bool equipajeDeMano = this.chkBoxEquipajeDeMano.Checked;
            int cantidadMaletas = (int)this.cmbCantidadMaletas.SelectedItem;
            int pesoEnKg = 0;
            if (this.rbtnPasajePremium.Checked)
            {
                pesoEnKg = (int)(this.nudMaleta1.Value + this.nudMaleta2.Value);
            }
            else if (this.rbtnPasajeTurista.Checked)
            {
                pesoEnKg = (int)this.nudMaleta1.Value;
            }

            auxEquipaje = new Equipaje(equipajeDeMano, pesoEnKg, cantidadMaletas);
            this.CargarDatosEquipaje(auxEquipaje);
            //MessageBox.Show(auxEquipaje.ToString());

        }

        private void ControlarOpcionesEquipaje(bool tieneMaleta1, bool tieneMaleta2)
        {
            this.nudMaleta1.Visible = tieneMaleta1;
            this.lblPesoKgMaleta1.Visible = tieneMaleta1;
            this.nudMaleta2.Visible = tieneMaleta2;
            this.lblPesoKgMaleta2.Visible = tieneMaleta2;
        }

        private void cmbCantidadMaletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ControlarOpcionesEquipaje(false, false);
            if ((int)cmbCantidadMaletas.SelectedItem == 1)
            {
                this.ControlarOpcionesEquipaje(true, false);
            }
            else
            {
                if ((int)cmbCantidadMaletas.SelectedItem == 2)
                {
                    this.ControlarOpcionesEquipaje(true, true);
                }
            }

        }
        #endregion

        private bool YaCargoUnPasajeroConEseDni(int dni)
        {
            bool yaLoCargo = false;
            foreach (Pasajero pasajero in this.listaPasajerosCargado)
            {
                if (pasajero.ObtenerCliente().Dni == dni)
                {
                    yaLoCargo = true;
                }
            }
            return yaLoCargo;
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.lblMensajeErrorDatosCliente.Visible = false;

            if (Validador.EsValidoNombre(this.txtNombreCliente.Text) && Validador.EsValidoNombre(this.txtApellidoCliente.Text)
                && Validador.EsValidoDni(this.txtDniCliente.Text) && this.nudEdadCliente.Value != 0)
            {
                if (this.YaCargoUnPasajeroConEseDni(Int32.Parse(this.txtDniCliente.Text)))
                {
                    this.MostrarMensajeErrorIngresoClienteNuevo("ERROR: Ya cargo un pasajero con el mismo DNI");
                    this.ControlarCamposIngresoCliente(true, true);
                }
                else
                {
                    Cliente clienteExistente = Sistema.ClienteExisteEnBaseDeDatos(Int32.Parse(this.txtDniCliente.Text));
                    if (clienteExistente != null)
                    {
                        if (MessageBox.Show(this, "Este cliente ya existe ¿Desea asingarlo?", "CLIENTE EXISTENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {

                            this.CargarDatosCliente(clienteExistente);
                            this.ControlarCamposIngresoCliente(false, false);
                            // MessageBox.Show(clienteExistente.ToString());

                        }

                    }
                    else
                    {
                        Cliente clienteNuevo = new Cliente(this.txtNombreCliente.Text, this.txtApellidoCliente.Text, Int32.Parse(this.txtDniCliente.Text), (int)this.nudEdadCliente.Value, BaseDeDatos.ListaClientes.Count + 1);
                        this.CargarDatosCliente(clienteNuevo);
                        this.lblMensajeErrorDatosCliente.Visible = false;
                    }
                }
            }
            else
            {
                this.MostrarMensajeErrorIngresoClienteNuevo("ERROR: Datos ingresados inválidos");
            }

        }

        private void txtFiltroPorDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros");
            }
        }

        private void txtFiltroPorDni_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFiltroPorDni.Text))
            {
                this.CargarDataGridClientes();
            }
            else
            {
                List<Cliente> listaClone = Sistema.FiltrarClientesPorDni(this.txtFiltroPorDni.Text);

                this.dgvClientesExistentes.DataSource = null;
                this.dgvClientesExistentes.DataSource = listaClone;
            }
        }

        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {
            if(this.listaPasajerosCargado.Count < 4)
            {
                if (this.clienteActual != null && this.equipajeActual != null && this.pasaporteActual != null)
                {
                    this.lblMensajeErrorCargaPasajero.Visible = false;
                    if (this.listaPasajerosCargado.Count == 0)
                    {
                        this.rbtnPasajePremium.Enabled = false;
                        this.rbtnPasajeTurista.Enabled = false;
                    }

                    this.pasajeroActual = new Pasajero(clienteActual, pasaporteActual, this.rbtnPasajePremium.Checked, equipajeActual);
                    this.listaPasajerosCargado.Add(pasajeroActual);

                    this.CalcularPrecios();

                    this.ResetearCamposParaNuevaCargaDePasajero();
                }
                else
                {
                    this.MostrarErroCargaPasajero("ERROR: Asegurese de cargar todo!");
                }
            }
            else
            {
                this.MostrarErroCargaPasajero("ERROR: No puede vender mas de 4 pasajes a la vez!");
            }
           
        }

        private void MostrarErroCargaPasajero(string mensaje)
        {
            this.lblMensajeErrorCargaPasajero.Text = mensaje;
            this.lblMensajeErrorCargaPasajero.Visible = true;
        }

        private void MostrarLabelPrecios()
        {
            this.lblPrecio.Visible = true;
            this.lblPrecioFinal.Visible = true;
            this.lblPrecioAcumulado.Visible = true;

        }

        private void CalcularPrecios()
        {
            if (pasajeroActual.EsPremium)
            {
                this.precioActual = this.viajeDelPasajeAVender.CostoPremium;
            }
            else
            {
                this.precioActual = this.viajeDelPasajeAVender.CostoBase;
            }

            this.precioActualFinal = this.precioActual * 1.21f;
            this.lblPrecio.Text = $"Precio: {this.precioActual}";
            this.lblPrecioFinal.Text = $"Precio final(21% IVA): {this.precioActualFinal}";
            this.precioTotalAcumulado += this.precioActualFinal;
            this.lblPrecioAcumulado.Text = $"Total pasajes: {this.precioTotalAcumulado}";
            this.MostrarLabelPrecios();
        }

        private void CargarDatosCrucero()
        {
            this.lblInfoCrucero.Text = this.viajeDelPasajeAVender.ObtenerDatosCrucero();
            this.chkBoxTieneBar.Checked = this.viajeDelPasajeAVender.ObtenerCrucero().TieneBar;
            this.chkBoxTieneGimnasio.Checked = this.viajeDelPasajeAVender.ObtenerCrucero().TieneGimnasio;
            this.chkBoxTieneComedor.Checked = this.viajeDelPasajeAVender.ObtenerCrucero().TieneComedor;
            this.chkBoxTienePileta.Checked = this.viajeDelPasajeAVender.ObtenerCrucero().TienePileta;
        }

        private void ResetearCamposParaNuevaCargaDePasajero()
        {

            this.ActualizarListaPasajerosCargados();
            this.ControlarCamposIngresoCliente(false, true);
            this.VaciarCamposIngresoPasaporte();
            this.vaciarCamposCargados();
            this.ControlarCantidadMaletasDisponibles(this.rbtnPasajePremium.Checked);
            this.ControlarSeleccionClienteExistente(false);
            this.ControlarFiltroPorDni(false);
            this.dgvClientesExistentes.DataSource = null;

            this.equipajeActual = null;
            this.pasaporteActual = null;
            this.clienteActual = null;
        }

        private void vaciarCamposCargados()
        {
            this.txtClienteCargado.Text = string.Empty;
            this.txtPasaporteCargado.Text = string.Empty;
            this.txtEquipajeCargado.Text = string.Empty;
        }

        private void ActualizarListaPasajerosCargados()
        {
            this.lboxListaPasajeros.DataSource = null;
            this.lboxListaPasajeros.DataSource = this.listaPasajerosCargado;
        }

        

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            DialogResult seFinaliza = DialogResult.Cancel;
            if(Sistema.ViajeEstaDisponible(viajeDelPasajeAVender))
            { 
                if(Sistema.EsGrupoFamiliarPremium(this.listaPasajerosCargado))
                {
                    if (this.listaPasajerosCargado.Count <= viajeDelPasajeAVender.ObtenerCantidadCamarotesLibrePremium())
                    {
                        Sistema.AgregarClientesNuevosABaseDeDatos(this.listaPasajerosCargado);
                        seFinaliza = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes camarotes libres de tipo premium");
                    }
                }
                else
                {
                    if (this.listaPasajerosCargado.Count <= viajeDelPasajeAVender.ObtenerCantidadCamarotesLibreTurista())
                    {
                        seFinaliza = DialogResult.OK;
                    }
                    else
                    {
                    
                        MessageBox.Show("No hay suficientes camarotes libres de tipo turista");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se aceptan mas pasajeros; \n(El crucero esta lleno o ya zarpó)");
            }
            this.DialogResult = seFinaliza;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}