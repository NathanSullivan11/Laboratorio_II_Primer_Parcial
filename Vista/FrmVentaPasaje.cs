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
        #region Atributos
        private Viaje viajeDelPasajeAVender;
        public List<Pasajero> pasajerosCargados;
        private Pasajero pasajeroActual;
        private Cliente clienteActual;
        private Pasaporte pasaporteActual;
        private Equipaje equipajeActual;
        private float precioTotalAcumulado;
        private float precioActual;
        private float precioActualFinal;
        #endregion

        #region Constructor y evento Load
        public FrmVentaPasaje(Viaje viajeDelPasajeAVender)
        {
            InitializeComponent();
            this.pasajerosCargados = new List<Pasajero>();
            this.viajeDelPasajeAVender = viajeDelPasajeAVender;                  
            this.equipajeActual = null;
            this.pasaporteActual = null;
            this.clienteActual = null;
            this.precioTotalAcumulado = 0;
        }

        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            this.HabilitarSeleccionClienteExistente(false);
            this.HabilitarTextBoxIngresoCliente(false, false);
            this.InicializarComboBoxSexoPasaporte();
        }
        #endregion

        #region Propiedades
        public List<Pasajero> PasajerosCargados { get => this.pasajerosCargados; }
        private bool ClienteCargado
        {
            set
            {
                this.chkBox_ClienteCargado.Checked = value;
                if (value == true)
                {
                    this.lblClienteCargado.ForeColor = Color.Green;
                }
                else
                {
                    this.lblClienteCargado.ForeColor = Color.Red;
                }

            }
        }
        private bool EquipajeCargado
        {
            set
            {
                this.chkBox_EquipajeCargado.Checked = value;
                if (value == true)
                {
                    this.lblEquipajeCargado.ForeColor = Color.Green;
                }
                else
                {
                    this.lblEquipajeCargado.ForeColor = Color.Red;
                }

            }
        }
        private bool PasaporteCargado
        {
            set
            {
                this.chkBox_PasaporteCargado.Checked = value;
                if (value == true)
                {
                    this.lblPasaporteCargado.ForeColor = Color.Green;
                }
                else
                {
                    this.lblPasaporteCargado.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region Métodos y eventos para la carga de cliente
        /// <summary>
        /// Habilita el data grid, para seleccionar un cliente existente de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            this.ActualizarDataGridClientes();
            this.HabilitarSeleccionClienteExistente(true);
            this.HabilitarTextBoxIngresoCliente(false, true);
            this.HabilitarFiltroPorDni(true);
            this.ClienteCargado = false;
            this.VaciarPasaporteIngresado();
            this.VaciarEquipajeIngresado();
        }
        /// <summary>
        /// Permite el ingreso de un nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            this.HabilitarTextBoxIngresoCliente(true, true);
            this.HabilitarSeleccionClienteExistente(false);
            this.HabilitarFiltroPorDni(false);            
            this.VaciarDataGridClientes();
            this.ClienteCargado = false;
            this.VaciarPasaporteIngresado();
            this.VaciarEquipajeIngresado();
        }
     
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            this.HabilitarTextBoxIngresoCliente(false, false);
            
            Cliente clienteSeleccionado = (Cliente)this.dgvClientesExistentes.CurrentRow.DataBoundItem;
            if (clienteSeleccionado is null)
            {
                return;
            }
            this.ConfirmarDatosCliente(clienteSeleccionado);
            this.VaciarDataGridClientes();
            this.HabilitarFiltroPorDni(false);
            this.btnSeleccionarCliente.Enabled = false;
        }
        /// <summary>
        /// Agrega el cliente, siempre y cuando no exista en la base de datos y los datos ingresado sean válidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.lblMensajeErrorDatosCliente.Visible = false;

            if (DatosIngresadosClienteValidos())
            {
                if (this.YaCargoUnPasajeroConEseDni(Int32.Parse(this.txtDniCliente.Text)))
                {
                    this.MostrarMensajeErrorIngresoClienteNuevo("ERROR: Ya cargo un pasajero con el mismo DNI");
                    this.HabilitarTextBoxIngresoCliente(true, true);
                }
                else
                { 
                    this.VerificarClienteIngresado();                  
                }
            }
            else
            {
                this.MostrarMensajeErrorIngresoClienteNuevo("ERROR: Datos ingresados inválidos");
            }
        }
        /// <summary>
        /// Verifica que el cliente ingresado no exista en la base de datos
        /// </summary>
        private void VerificarClienteIngresado()
        {
            bool retorno = false;
            Cliente clienteExistente = Sistema.ClienteExisteEnBaseDeDatos(Int32.Parse(this.txtDniCliente.Text));
            if (clienteExistente != null)
            {
                if(!ClienteYaSeCargo(clienteExistente))
                {
                    if (MessageBox.Show(this, "Este cliente ya existe ¿Desea asignarlo?", "CLIENTE EXISTENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this.ConfirmarDatosCliente(clienteExistente);
                    }
                }              
            }
            else
            {
                this.CrearNuevoCliente();             
            }
        }
 
        private bool ClienteYaSeCargo(Cliente cliente)
        {
            bool seCargo = false;
            foreach(Pasajero auxP in this.pasajerosCargados)
            {
                if(auxP.ObtenerCliente().Equals(cliente))
                {
                    seCargo = true;
                    break;
                }
            }
            return seCargo;
        }

        private void CrearNuevoCliente()
        {
            Cliente clienteNuevo = new Cliente(this.txtNombreCliente.Text, this.txtApellidoCliente.Text, Int32.Parse(this.txtDniCliente.Text), (int)this.nudEdadCliente.Value, BaseDeDatos.ListaClientes.Count + 1);
            if (clienteNuevo is not null && !ClienteYaSeCargo(clienteNuevo))
            {
                this.ConfirmarDatosCliente(clienteNuevo);
                this.lblMensajeErrorDatosCliente.Visible = false;
            }
        }
        /// <summary>
        /// Confirma la carga de cliente
        /// </summary>
        /// <param name="auxCliente"></param>
        private void ConfirmarDatosCliente(Cliente auxCliente)
        {
            this.txtNombreCliente.Text = auxCliente.Nombre;
            this.txtApellidoCliente.Text = auxCliente.Apellido;
            this.txtDniCliente.Text = auxCliente.Dni.ToString();
            this.nudEdadCliente.Value = auxCliente.Edad;
            this.clienteActual = auxCliente;
            this.ClienteCargado = true;
            this.HabilitarTextBoxIngresoCliente(false, false);
        }

        private void VaciarClienteIngresado()
        {
            this.ClienteCargado = false;
            this.HabilitarSeleccionClienteExistente(false);
            this.HabilitarTextBoxIngresoCliente(false, true);
        }

        private void ActualizarDataGridClientes()
        {
            this.VaciarDataGridClientes();
            this.dgvClientesExistentes.DataSource = BaseDeDatos.ListaClientes;
        }

        private void VaciarDataGridClientes()
        {
            this.dgvClientesExistentes.DataSource = null;
        }

        private void MostrarMensajeErrorIngresoClienteNuevo(string mensaje)
        {
            this.lblMensajeErrorDatosCliente.Text = mensaje;
            this.lblMensajeErrorDatosCliente.Visible = true;
        }
        /// <summary>
        /// Si se carga un cliente, se habilita el ingreso de pasaporte. Y viceversa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBox_ClienteCargado_CheckedChanged(object sender, EventArgs e)
        {
            this.gboxPasaporte.Enabled = chkBox_ClienteCargado.Checked;
        }
        #endregion

        #region Métodos y eventos para la carga de pasaporte
        /// <summary>
        /// Crea y carga un pasaporte siempre y cuando sea válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarPasaporte_Click(object sender, EventArgs e)
        {
            this.lblMensajeErrorIngresoPasaporte.Visible = false;
            if (DatosIngresadosPasaporteValidos())
            {
                Pasaporte pasaporteCreado = new Pasaporte(this.txtNroPasaporte.Text, this.txtNacionalidadPasaporte.Text, (string)this.cmbSexoPasaporte.SelectedItem, this.dtpCaducidadPasaporte.Value);
                if (!Sistema.PasaporteEstaRepetido(pasaporteCreado, viajeDelPasajeAVender) && !this.PasaporteRepetidoEnListaCargada(this.txtNroPasaporte.Text))
                {
                    this.ConfirmarDatosPasaporte(pasaporteCreado);
                }
                else
                {
                    this.MostrarMensajeErrorIngresoPasaporte("ERROR: Pasaporte ingresado existente");
                }
            }
            else
            {
                this.MostrarMensajeErrorIngresoPasaporte("ERROR: Dato/s inválido/s");
            }
        }
        /// <summary>
        /// Confirma la carga de un pasaporte
        /// </summary>
        /// <param name="pasaporte"></param>
        private void ConfirmarDatosPasaporte(Pasaporte pasaporte)
        {
            this.PasaporteCargado = true;
            this.gboxPasaporte.Enabled = false;
            this.pasaporteActual = pasaporte;
        }

        /// <summary>
        /// Verifica que un pasaporte no este ingresado dentro del grupo familiar cargado
        /// </summary>
        /// <param name="pasaporteCreado"></param>
        /// <returns></returns>
        private bool PasaporteRepetidoEnListaCargada(string nroPasaporte)
        {
            bool estaRepetido = false;

            foreach (Pasajero auxPasajero in this.pasajerosCargados)
            {
                if (auxPasajero.NumeroPasaporte.Trim().ToLower() == this.txtNroPasaporte.Text.Trim().ToLower())
                {
                    estaRepetido = true;
                    break;
                }
            }
            return estaRepetido;
        }

        private void VaciarCamposIngresoPasaporte()
        {
            foreach (Control control in this.gboxPasaporte.Controls)
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

        private void VaciarPasaporteIngresado()
        {
            this.PasaporteCargado = false;
            this.VaciarCamposIngresoPasaporte();
        }

        private void InicializarComboBoxSexoPasaporte()
        {
            string[] sexos = { "Masculino", "Femenino", "No binario" };

            this.cmbSexoPasaporte.DataSource = sexos;
        }

        private void MostrarMensajeErrorIngresoPasaporte(string mensaje)
        {
            this.lblMensajeErrorIngresoPasaporte.Visible = true;
            this.lblMensajeErrorIngresoPasaporte.Text = mensaje;
        }
        /// <summary>
        /// Si se carga el pasaporte, se activa el ingreso de un equipaje. Y viceversa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBox_PasaporteCargado_CheckedChanged(object sender, EventArgs e)
        {
            this.gboxEquipaje.Enabled = chkBox_PasaporteCargado.Checked;
        }

        #endregion

        #region Métodos y eventos para la carga de equipaje
        /// <summary>
        /// Carga un equipaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {
            Equipaje auxEquipaje;

            bool equipajeDeMano = this.chkBoxEquipajeDeMano.Checked;
            int pesoEnKg = (int)this.nudPesoEquipaje.Value;

            auxEquipaje = new Equipaje(equipajeDeMano, pesoEnKg);
            this.ConfirmarDatosEquipaje(auxEquipaje);
        }
        /// <summary>
        /// Confirma los datos del equipaje ingresado
        /// </summary>
        /// <param name="equipaje"></param>
        private void ConfirmarDatosEquipaje(Equipaje equipaje)
        {
            this.EquipajeCargado = true;
            this.gboxEquipaje.Enabled = false;
            this.equipajeActual = equipaje;
        }
        /// <summary>
        /// Setea el maximo de kg de peso a 50, porque es pasajero premium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnPasajePremium_CheckedChanged(object sender, EventArgs e)
        {
            this.nudPesoEquipaje.Maximum = 50;
        }
        /// <summary>
        /// Setea el maximo de kg de peso a 25, porque es pasajero turista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnPasajeTurista_CheckedChanged(object sender, EventArgs e)
        {
            this.nudPesoEquipaje.Maximum = 25;
        }

        private void VaciarEquipajeIngresado()
        {
            this.EquipajeCargado = false;
            this.chkBoxEquipajeDeMano.Checked = false;
            this.nudPesoEquipaje.Value = 0;
            this.rbtnPasajeTurista.Checked = true;
        }
        /// <summary>
        /// Si se carga el equipaje, se activa la carga de un pasajero. Y viceversa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBox_EquipajeCargado_CheckedChanged(object sender, EventArgs e)
        {
            this.btnCargarPasajero.Enabled = chkBox_EquipajeCargado.Checked;
        }

        #endregion

        #region Métodos y evento para la carga de pasajero
        /// <summary>
        /// Carga un pasajero, si es que no excede el limite por grupo familiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {
            if (this.pasajerosCargados.Count < 4) // El grupo familiar no puede ser mayor a 4
            {
                this.lblMensajeErrorCargaPasajero.Visible = false;

                if (this.pasajerosCargados.Count == 0) // Como el grupo familiar tiene que ser del mismo servicio, al ingresar el primer
                {                                      // pasajero, se bloqueara la opción.
                    this.rbtnPasajePremium.Enabled = false;
                    this.rbtnPasajeTurista.Enabled = false;
                }

                if(this.CargarPasajero())
                {
                    this.CalcularPrecios();
                    this.btnFinalizarVenta.Enabled = true;
                }    
                else
                {
                    this.MostrarErrorCargaPasajero("ERROR: Ya cargo ese pasajero");

                }
                this.LimpiarCamposParaNuevaCargaDePasajero();
            }
            else
            {
                this.MostrarErrorCargaPasajero("ERROR: No puede vender mas de 4 pasajes a la vez!");
            }
        }

        private bool CargarPasajero()
        {
            bool seCargo = false;
            this.pasajeroActual = new Pasajero(clienteActual, pasaporteActual, this.rbtnPasajePremium.Checked, equipajeActual);
            if(!this.YaCargoUnPasajeroConEseDni(clienteActual.Dni))
            {
                this.pasajerosCargados.Add(pasajeroActual);
                seCargo = true;
            }
            return seCargo;
        }

        private void LimpiarCamposParaNuevaCargaDePasajero()
        {
            this.ActualizarpasajerosCargadoss();
            this.VaciarClienteIngresado();
            this.VaciarPasaporteIngresado();
            this.VaciarEquipajeIngresado();
        }

        private void ActualizarpasajerosCargadoss()
        {
            this.lboxListaPasajeros.DataSource = null;
            this.lboxListaPasajeros.DataSource = this.pasajerosCargados;
        }

        private void MostrarErrorCargaPasajero(string mensaje)
        {
            this.lblMensajeErrorCargaPasajero.Text = mensaje;
            this.lblMensajeErrorCargaPasajero.Visible = true;
        }
        #endregion

        #region Métodos validadores
        /// <summary>
        /// Verifica que los campos ingresado para el cliente sean válidos
        /// </summary>
        /// <returns></returns>
        private bool DatosIngresadosClienteValidos()
        {
            return Validador.EsValidoNombre(this.txtNombreCliente.Text) && Validador.EsValidoNombre(this.txtApellidoCliente.Text)
                            && Validador.EsValidoDni(this.txtDniCliente.Text) && this.nudEdadCliente.Value != 0;
        }
        /// <summary>
        /// Verifica que los campos ingresado para el pasaporte sean válidos
        /// </summary>
        /// <returns></returns>
        private bool DatosIngresadosPasaporteValidos()
        {
            return Validador.EsValidoNumeroPasaporte(this.txtNroPasaporte.Text) && (!string.IsNullOrEmpty(this.txtNacionalidadPasaporte.Text))
                            && Pasaporte.EstaEnReglaPasaporte(this.dtpCaducidadPasaporte.Value);
        }
        /// <summary>
        /// Verifica que no se haya cargado un pasajero dentro del mismo grupo familiar con el mismo dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        private bool YaCargoUnPasajeroConEseDni(int dni)
        {
            bool yaLoCargo = false;
            foreach (Pasajero pasajero in this.pasajerosCargados)
            {
                if (pasajero.ObtenerCliente().Dni == dni)
                {
                    yaLoCargo = true;
                }
            }
            return yaLoCargo;
        }
        #endregion

        #region Método para controlar ingreso de datos
        /// <summary>
        /// Habilita o no el boton para seleccionar un cliente del datagrid
        /// </summary>
        /// <param name="disponible"></param>
        private void HabilitarSeleccionClienteExistente(bool disponible)
        {
            this.btnSeleccionarCliente.Enabled = disponible;
        }

        /// <summary>
        /// Habilita o no el textbox para el filtrado por dni
        /// </summary>
        /// <param name="visible">si visible = true, se muestra. y viceversa</param>
        private void HabilitarFiltroPorDni(bool visible)
        {
            this.lblBuscarPorDni.Visible = visible;
            this.txtFiltroPorDni.Visible = visible;
        }

        /// <summary>
        /// Habilita o no los textbox para el ingreso de un nuevo cliente
        /// </summary>
        /// <param name="disponibles">Si disponible es true, la propiedad enabled = true y viceversa</param>
        /// <param name="vaciados">Si vaciados es true, se vacia el textbox</param>
        private void HabilitarTextBoxIngresoCliente(bool disponibles, bool vaciados)
        {
            foreach (Control controls in this.gboxDatosCliente.Controls)
            {
                if (controls is TextBox textBox)
                {
                    if (vaciados)
                    {
                        textBox.Text = string.Empty;
                    }
                    textBox.Enabled = disponibles;
                }
                else if (controls is NumericUpDown numerico)
                {
                    if (vaciados)
                    {
                        numerico.Value = 0;
                    }
                    numerico.Enabled = disponibles;
                }
                else if (controls is Button boton)
                {
                    boton.Enabled = disponibles;
                }
            }
        }
        #endregion

        #region Métodos para calcular precios
        /// <summary>
        /// Calcula los precios bruto, neto y final
        /// </summary>
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
            this.lblPrecioFinal.Text = $"Precio final(+ IVA): {this.precioActualFinal}";
            this.precioTotalAcumulado += this.precioActualFinal;
            this.lblPrecioAcumulado.Text = $"Total: {this.precioTotalAcumulado}";
            this.MostrarLabelPrecios();
        }
        /// <summary>
        /// Torna visible los labels de precios
        /// </summary>
        private void MostrarLabelPrecios()
        {
            this.lblPrecio.Visible = true;
            this.lblPrecioFinal.Visible = true;
            this.lblPrecioAcumulado.Visible = true;
        }
        #endregion

        #region Eventos para filtrado por dni
        /// <summary>
        /// Verifica que se ingrese solo dígitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltroPorDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros");
            }
        }
        /// <summary>
        /// Cuando cambia el texto, se filtra por coincidencia de DNI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltroPorDni_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFiltroPorDni.Text))
            {
                this.ActualizarDataGridClientes();
            }
            else
            {
                List<Cliente> listaClone = Sistema.FiltrarClientesPorDni(this.txtFiltroPorDni.Text);

                this.dgvClientesExistentes.DataSource = null;
                this.dgvClientesExistentes.DataSource = listaClone;
            }
        }


        #endregion

        #region Eventos de botones (FINALIZAR VENTA, CANCELAR, INFO CRUCERO, AYUDA)

        private void btnInfoCrucero_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.viajeDelPasajeAVender.ObtenerDatosBasicosCrucero(),"Info crucero",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se podra seleccionar un cliente existente de la base de datos, o agregar uno nuevo. (Si esta repetido te pregunta si queres traer sus datos " +
                "\nAl agregar el primer pasajero, la opcion de turista o premiuem se bloqueara acorde al tipo del primer pasajero cargado, " +
                "\nya que en un grupo familiar no pueden haber integrante de diferentes tipo de servicio\n" +
                "\nEl pasaporte debe tener mínimo 3 letras y luego solo numeros" +
                "\nNo hay validación para la nacionalidad, solo verifica que no sea null" +
                "\nNo se puede vender mas de 4 pasajes a la vez", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Finaliza la venta, siempre y cuando haya espacio disponible o el crucero no haya zarpado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            DialogResult seFinaliza = DialogResult.Cancel;
            if (Sistema.ViajeEstaDisponible(viajeDelPasajeAVender))
            {
                if (Sistema.EsGrupoFamiliarPremium(this.pasajerosCargados))
                {
                    if (this.pasajerosCargados.Count <= viajeDelPasajeAVender.ObtenerCantidadCamarotesLibrePremium())
                    {
                        Sistema.AgregarClientesNuevosABaseDeDatos(this.pasajerosCargados);
                        seFinaliza = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes camarotes libres de tipo premium", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                    }
                }
                else
                {
                    if (this.pasajerosCargados.Count <= viajeDelPasajeAVender.ObtenerCantidadCamarotesLibreTurista())
                    {
                        seFinaliza = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes camarotes libres de tipo turista", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se aceptan mas pasajeros; \n(El crucero esta lleno o ya zarpó)");
            }
            this.DialogResult = seFinaliza;
        }
        #endregion
    }
}
