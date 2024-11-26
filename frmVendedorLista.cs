using Integrador2024.Datos;
using Integrador2024.Entidades;
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
    public partial class frmVendedorLista : Form
    {
        public frmVendedorLista()
        {
            InitializeComponent();
            llenarVendedores();
            ajustarDGV();
        }


        void llenarVendedores()
        {
            string vendedorApellido = txtVendedorApellido.Text;
            string vendedorNombre = txtVendedorNombre.Text;

            List<Vendedor> ListaVendedor = new List<Vendedor>();

            Dal dal = new Dal();

            // Llamada a ListarVendor que devuelve una lista
            ListaVendedor = dal.ListarVendedor(vendedorApellido, vendedorNombre);

            dgvVendedores.DataSource = ListaVendedor;

        }

        // Función para cambiar el formato del datagridview
        void ajustarDGV()
        {

            // Titulos
            dgvVendedores.Columns[0].HeaderText = "Id";


            // Orden
            dgvVendedores.Columns[1].DisplayIndex = 2;
            dgvVendedores.Columns[2].DisplayIndex = 1;

        }

        private void btnNuevoVendedor_Click(object sender, EventArgs e)
        {
            frmVendedorEditar frmVendedorEditar = new frmVendedorEditar();
            frmVendedorEditar.ShowDialog();
        }

        private void frmVendedorLista_Activated(object sender, EventArgs e)
        {
            llenarVendedores();
        }

        private void btnEditarVendedor_Click(object sender, EventArgs e)
        {
            EditarVendedor();
        }

        // Función que llama al form VendedorEditar pasando como parámetro el Id de donde está parado en la grilla
        void EditarVendedor()
        {
            int vendedorId;

            vendedorId = Convert.ToInt16(dgvVendedores.CurrentRow.Cells[0].Value);

            frmVendedorEditar editarVendedor = new frmVendedorEditar(vendedorId);
            editarVendedor.ShowDialog();
        }

        private void btnEliminarVendedor_Click(object sender, EventArgs e)
        {
            BorrarVendedor();
        }

        void BorrarVendedor()
        {
            int vendedorId;

            vendedorId = Convert.ToInt16(dgvVendedores.CurrentRow.Cells[0].Value);
            string? nombreVendedor = dgvVendedores.CurrentRow.Cells[2].Value.ToString() + " " + dgvVendedores.CurrentRow.Cells[1].Value.ToString();

            string mensaje = $"Esta seguro que desea eliminar al vendedor: {nombreVendedor}?";
            DialogResult dr = MessageBox.Show(mensaje, "Borrar vendedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dal dal = new Dal();
                dal.EliminarVendedor(vendedorId);
                llenarVendedores();
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            llenarVendedores();
        }

        private void txtVendedorApellido_TextChanged(object sender, EventArgs e)
        {
            llenarVendedores();
        }

        private void txtVendedorNombre_TextChanged(object sender, EventArgs e)
        {
            llenarVendedores();
        }
    }
}
