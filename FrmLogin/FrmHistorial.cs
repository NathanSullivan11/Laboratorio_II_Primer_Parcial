using System;
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
    public partial class FrmHistorial : Form
    {
        FrmListadoClientes formListadoClientes;
        FrmListadoViajes formListadoViajes;
        FrmListadoDestinos formListadoDestinos;
        FrmListadoCruceros formListadoCruceros;

        public FrmHistorial()
        {
            InitializeComponent();
            formListadoClientes = new FrmListadoClientes();
            formListadoViajes = new FrmListadoViajes();
            formListadoDestinos = new FrmListadoDestinos();
            formListadoCruceros = new FrmListadoCruceros();
            this.IsMdiContainer = true;
            formListadoViajes.MdiParent = this;
            formListadoClientes.MdiParent = this;
            formListadoDestinos.MdiParent = this;
            formListadoCruceros.MdiParent = this;


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            formListadoClientes.StartPosition = FormStartPosition.CenterScreen;
            formListadoClientes.Show();
         
        }

        
        private void OcultarFormsMDI()
        {
            formListadoClientes.Hide();
            formListadoViajes.Hide();
            formListadoDestinos.Hide();
            formListadoCruceros.Hide();
        }
        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            formListadoViajes.StartPosition = FormStartPosition.CenterScreen;
            formListadoViajes.Show();
        }

        private void crucerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            formListadoCruceros.StartPosition = FormStartPosition.CenterScreen;
            formListadoCruceros.Show();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarFormsMDI();
            //formListadoDestinos.StartPosition = FormStartPosition.CenterScreen;
            formListadoDestinos.Show();
        }
    }
}
