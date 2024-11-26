using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador2024
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProductoLista frmProductoLista = new frmProductoLista();
            frmProductoLista.ShowDialog();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            frmVendedorLista frmVendedorLista = new frmVendedorLista();
            frmVendedorLista.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Funcion no implementada");
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Funcion no implementada");
        }
    }
}
