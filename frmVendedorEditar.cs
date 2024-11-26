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
    public partial class frmVendedorEditar : Form
    {
        public frmVendedorEditar()
        {
            InitializeComponent();
        }

        int vendedorIdSeleccionado;

        // En caso de que se cargue el form con el parametro del VendedorId corro la función de mostrar vendedor
        public frmVendedorEditar(int vendedorId)
        {
            InitializeComponent();
            vendedorIdSeleccionado = vendedorId;
            MostrarVendedor();

        }

        // Función que llama al método ListarVendedor con el parámetro de vendedorId y serializa el objeto en el form
        void MostrarVendedor()
        {
            Dal dal = new Dal();
            Vendedor vendedor = dal.ListarVendedor(vendedorIdSeleccionado);

            txtIdVendedor.Text = vendedor.VendedorId.ToString();
            txtApellidoVendedor.Text = vendedor.Apellido.ToString();
            txtNombreVendedor.Text = vendedor.Nombre.ToString();
            txtDNIVendedor.Text = vendedor.DNI.ToString();
            MTBCUITVendedor.Text = vendedor.CUIT.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabarProducto_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                GuardarVendedor();
                this.Close();
            }
            else
            {
                MessageBox.Show("Revise datos faltantes o erróneos");
            }
        }

        private bool CamposValidos()
        {
            return txtNombreVendedor.Text.Trim() != ""
                && txtApellidoVendedor.Text.Trim() != ""
                && txtDNIVendedor.Text.Trim() != ""
                && MTBCUITVendedor.MaskCompleted;

        }

        void GuardarVendedor()
        {
            //cliente.CUIT = Convert.ToInt64(txtCUIT.Text.Replace("-", ""));
            //cliente.RazonSocial = txtRazonSocial.Text;
            //cliente.DirCalle = txtCalle.Text;

            // Como para instanciar necesito todos los datos, primero los guardo y después instancio

            int pVendedorId = -1;

            if (!string.IsNullOrEmpty(txtIdVendedor.Text))
            {
                pVendedorId = Convert.ToInt32(txtIdVendedor.Text);
            }
            string pNombre = txtNombreVendedor.Text;
            string pApellido = txtApellidoVendedor.Text;
            string pDNI = txtDNIVendedor.Text;
            string pCUIT = MTBCUITVendedor.Text;

            Vendedor vendedor = new Vendedor(pVendedorId, pNombre, pApellido, pDNI, pCUIT);
            Dal dal = new Dal();

            if (string.IsNullOrEmpty(txtIdVendedor.Text))
            {
                dal.CrearVendedor(vendedor);
            }

            else
            {
                dal.EditarVendedor(vendedor);
            }
        }
    }
}
