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
    public partial class frmProductoLista : Form
    {
        public frmProductoLista()
        {
            InitializeComponent();

            // Funcion para llenar los productos
            llenarProductos();
            // Funcion para ajustar los encabezados
            ajustarDGV();
        }
        // Cuando la pantalla pasa a estar activa nuevamente llama a la función para llenar los productos
        private void frmProductoLista_Activated(object sender, EventArgs e)
        {
            llenarProductos();
        }

        void llenarProductos()
        {
            string productoNombre = txtNombre.Text;
            string productoDescripcion = txtDescripcion.Text;
            string productoProveedor = txtProveedor.Text;

            List<Producto> ListaProducto = new List<Producto>();

            Dal dal = new Dal();

            // Llamada a ListarProductos que devuelve una lista
            ListaProducto = dal.ListarProducto(productoNombre, productoDescripcion, productoProveedor);

            dgvProductos.DataSource = ListaProducto;
            // Para ocultar ProductoId
            // dgvClientes.Columns["ProductoId"].Visible = false;

        }
        // Función para cambiar el formato del datagridview
        void ajustarDGV()
        {

            // Titulos
            dgvProductos.Columns[0].HeaderText = "Id";
            dgvProductos.Columns[1].HeaderText = "Nombre";
            dgvProductos.Columns[2].HeaderText = "Descripción";
            dgvProductos.Columns[3].HeaderText = "Costo";
            dgvProductos.Columns[4].HeaderText = "Proveedor";
            dgvProductos.Columns[5].HeaderText = "Categoria";
            dgvProductos.Columns[6].HeaderText = "Sub categoria";
            dgvProductos.Columns[7].HeaderText = "Margen";
            dgvProductos.Columns[8].HeaderText = "IVA";
            dgvProductos.Columns[9].HeaderText = "Precio Bruto";
            dgvProductos.Columns[10].HeaderText = "Pcio de Vta";

            // Orden
            dgvProductos.Columns[0].DisplayIndex = 0;
            dgvProductos.Columns[1].DisplayIndex = 1;
            dgvProductos.Columns[2].DisplayIndex = 2;
            dgvProductos.Columns[4].DisplayIndex = 3;
            dgvProductos.Columns[5].DisplayIndex = 4;
            dgvProductos.Columns[6].DisplayIndex = 5;
            dgvProductos.Columns[3].DisplayIndex = 6;
            dgvProductos.Columns[7].DisplayIndex = 7;
            dgvProductos.Columns[9].DisplayIndex = 8;
            dgvProductos.Columns[8].DisplayIndex = 9;
            dgvProductos.Columns[10].DisplayIndex = 10;


            // Formato
            dgvProductos.Columns[3].DefaultCellStyle.Format = "#,0.00";
            dgvProductos.Columns[7].DefaultCellStyle.Format = "#,0.00";
            dgvProductos.Columns[8].DefaultCellStyle.Format = "#,0.00";
            dgvProductos.Columns[9].DefaultCellStyle.Format = "#,0.00";
            dgvProductos.Columns[10].DefaultCellStyle.Format = "#,0.00";

            // Alineación
            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

        }



        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProductoEditar frmProductoEditar = new frmProductoEditar();
            frmProductoEditar.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }


        // Función que llama al form ProductoEditar pasando como parámetro el Id de donde está parado en la grilla
        void EditarProducto()
        {
            int productoId;

            productoId = Convert.ToInt16(dgvProductos.CurrentRow.Cells[0].Value);

            frmProductoEditar editarproducto = new frmProductoEditar(productoId);
            editarproducto.ShowDialog();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            BorrarProducto();
        }

        void BorrarProducto()
        {
            int productoId;

            productoId = Convert.ToInt16(dgvProductos.CurrentRow.Cells[0].Value);
            string? nombreProducto = dgvProductos.CurrentRow.Cells[1].Value.ToString();

            string mensaje = $"Esta seguro que desea eliminar al producto: {nombreProducto}?";
            DialogResult dr = MessageBox.Show(mensaje, "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dal dal = new Dal();
                dal.EliminarProducto(productoId);
                llenarProductos();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            llenarProductos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            llenarProductos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            llenarProductos();
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            llenarProductos();
        }
    }
}
