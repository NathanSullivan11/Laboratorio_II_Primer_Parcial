﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario usuarioLogueado;
        private FrmLogin formLogin;
        private FrmViajes formViajes;
        private FrmClientes formClientes;


        public FrmMenuPrincipal(FrmLogin formLogin, Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.usuarioLogueado = usuarioLogueado;
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            panel_SubMenuEstadisticas.Visible = true;
        }

        private void btn_ViajesTotales_Click(object sender, EventArgs e)
        {
            this.OcultarSubMenuEstadisticas();
        }

        private void btn_Viajes_Click(object sender, EventArgs e)
        {           
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formViajes = new FrmViajes();
            this.ConfigurarForm(formViajes);
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            this.VaciarPanelCentral();
            this.OcultarSubMenuEstadisticas();

            this.formClientes = new FrmClientes();
            this.ConfigurarForm(formClientes);
        }

        private void OcultarSubMenuEstadisticas()
        {
            if(panel_SubMenuEstadisticas.Visible == true)
            {
                panel_SubMenuEstadisticas.Visible = false;
            }
        }
        private void VaciarPanelCentral()
        {
            if (this.panel_Central.Controls.Count > 0)
            {
                this.panel_Central.Controls.RemoveAt(0);
            }           
        }
        /// <summary>
        /// Configura el formulario para que aparezca en la posicion correcta
        /// </summary>
        /// <param name="esteForm"></param>
        private void ConfigurarForm(Form esteForm)
        {
            esteForm.TopLevel = false;
            esteForm.Dock = DockStyle.Fill;
            this.panel_Central.Controls.Add(esteForm);
            this.panel_Central.Tag = esteForm;
            esteForm.Show();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                formLogin.Show();
            }
        }

        private void pbox_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbox_Maximizar_Click(object sender, EventArgs e)
        {
            pbox_Maximizar.Visible = false;
            pbox_Restaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pbox_Restaurar_Click(object sender, EventArgs e)
        {
            pbox_Restaurar.Visible = false;
            pbox_Maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void pbox_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void pbox_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
