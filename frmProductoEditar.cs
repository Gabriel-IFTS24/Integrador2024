using Integrador2024.Datos;
using Integrador2024.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Integrador2024
{
    public partial class frmProductoEditar : Form
    {
        public frmProductoEditar()
        {
            InitializeComponent();

        }

        int productoIdSeleccionado;

        // En caso de que se cargue el form con el parametro del ProductoId corro la función de mostrar producto
        public frmProductoEditar(int ProductoId)
        {
            InitializeComponent();
            productoIdSeleccionado = ProductoId;
            MostrarProducto();

        }

        // Función que llama al método ListarProducto con el parámetro de productoId y serializa el objeto en el form
        void MostrarProducto()
        {
            Dal dal = new Dal();
            Producto producto = dal.ListarProducto(productoIdSeleccionado);

            txtId.Text = producto.ProductoId.ToString();
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecioCosto.Text = Convert.ToDouble(producto.PrecioCosto).ToString();
            txtProveedor.Text = producto.Proveedor;
            cbbCategoria.Text = producto.Categoria;
            cbbSubCategoria.Text = producto.SubCategoria;
            txtMargen.Text = Convert.ToDouble(producto.Margen).ToString();
            txtIVA.Text = Convert.ToDouble(producto.IVA).ToString();
            txtPrecioBruto.Text = Convert.ToDouble(producto.PrecioBruto).ToString();
            txtPrecioVenta.Text = Convert.ToDouble(producto.PrecioVenta).ToString();

        }

        // Función para guardar o crear producto (dependiendo si el ProductoId está vacío)
        void GuardarProducto()
        {
            // Como para instanciar necesito todos los datos, primero los guardo y después instancio

            int pProductoId = -1;

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                pProductoId = Convert.ToInt32(txtId.Text);
            }
            string pNombre = txtNombre.Text;
            string pDescripcion = txtDescripcion.Text;
            decimal pPrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            string pProveedor = txtProveedor.Text;
            string pCategoria = cbbCategoria.Text.ToString();
            string pSubCategoria = cbbSubCategoria.Text.ToString();
            double pMargen = Convert.ToDouble(txtMargen.Text);
            double pIVA = Convert.ToDouble(txtIVA.Text);
            double pPrecioBruto = Convert.ToDouble(txtPrecioBruto.Text);

            Producto producto = new Producto(pProductoId, pNombre, pDescripcion, pPrecioCosto, pProveedor, pCategoria, pSubCategoria, pMargen, pIVA);
            Dal dal = new Dal();

            if (string.IsNullOrEmpty(txtId.Text))
            {
                dal.CrearProducto(producto);
            }

            else
            {
                dal.EditarProducto(producto);
            }
        }

        private void btnGrabarProducto_Click_1(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                GuardarProducto();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Revise datos faltantes o erróneos");
            }
        }

        // Función que actualiza los precios (bruto, IVA y venta) en función de los datos cargados
        private void CalcularPrecios()
        {
            double precioCosto, margen;

            bool esNumeroPrecioCosto = double.TryParse(txtPrecioCosto.Text, out precioCosto);
            bool esNumeroMargen = double.TryParse(txtMargen.Text, out margen);
            string IVASeleccionado = cbbIVA.Text;
            double IVAaAplicar;

            if (esNumeroPrecioCosto && esNumeroMargen)
            {
                double sumaPrecioBruto = Math.Round(precioCosto + margen, 2);
                txtPrecioBruto.Text = sumaPrecioBruto.ToString();

            }
            else
            {
                txtPrecioBruto.Clear();
            }

            if (IVASeleccionado == "10,5%")
            {
                IVAaAplicar = 10.5;
            }
            else
            {
                IVAaAplicar = 21;
            }


            if (esNumeroPrecioCosto && esNumeroMargen && cbbIVA.SelectedIndex != -1)
            {
                double precioIVA = Math.Round((precioCosto + margen) * (IVAaAplicar / 100), 0);
                txtIVA.Text = precioIVA.ToString();
                double sumaPrecioVenta = precioCosto + margen + precioIVA;
                txtPrecioVenta.Text = sumaPrecioVenta.ToString();
            }
            else
            {
                txtPrecioVenta.Clear();

            }

        }

        // Cuando cambio el PrecioCosto llamo a la función para actualizar el precios
        private void txtPrecioCosto_Leave(object sender, EventArgs e)
        {
            txtPrecioCosto.Text = txtPrecioCosto.Text.Replace(".", ",");
            CalcularPrecios();
        }

        // Cuando cambio el Margen llamo a la función para actualizar el precios
        private void txtMargen_Leave(object sender, EventArgs e)
        {
            txtMargen.Text = txtMargen.Text.Replace(".", ",");
            CalcularPrecios();
        }

        // Cuando cambio la selección del combobox llamo a la función para actualizar el precios
        private void cbbIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private bool CamposValidos()
        {
            return txtNombre.Text.Trim() != ""
                && txtDescripcion.Text.Trim() != ""
                && txtPrecioCosto.Text.Trim() != ""
                && txtProveedor.Text.Trim() != ""
                && cbbCategoria.Text.Trim() != ""
                && txtIVA.Text.Trim() != ""
                && txtPrecioBruto.Text.Trim() != "";
               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
