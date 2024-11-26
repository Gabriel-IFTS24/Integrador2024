namespace Integrador2024
{
    partial class frmProductoLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductoLista));
            dgvProductos = new DataGridView();
            btnNuevoProducto = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtProveedor = new TextBox();
            btnBuscarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 88);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(1122, 350);
            dgvProductos.TabIndex = 7;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Image = Properties.Resources.Nuevo;
            btnNuevoProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoProducto.Location = new Point(60, 12);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(130, 30);
            btnNuevoProducto.TabIndex = 0;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Image = Properties.Resources.Editar;
            btnEditarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarProducto.Location = new Point(219, 12);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(130, 30);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Image = (Image)resources.GetObject("btnEliminarProducto.Image");
            btnEliminarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.Location = new Point(374, 12);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(130, 30);
            btnEliminarProducto.TabIndex = 2;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese fragmento de Producto a buscar";
            txtNombre.Size = new Size(235, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(316, 58);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ingrese fragmento de Descripcion a buscar";
            txtDescripcion.Size = new Size(235, 23);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(572, 58);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.PlaceholderText = "Ingrese fragmento de Proveedor a buscar";
            txtProveedor.Size = new Size(235, 23);
            txtProveedor.TabIndex = 5;
            txtProveedor.TextChanged += txtProveedor_TextChanged;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Image = Properties.Resources.Buscar;
            btnBuscarProducto.Location = new Point(828, 59);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(39, 23);
            btnBuscarProducto.TabIndex = 6;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // frmProductoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 450);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtProveedor);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnNuevoProducto);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProductoLista";
            Text = "Listado de Productos";
            Activated += frmProductoLista_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnNuevoProducto;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtProveedor;
        private Button btnBuscarProducto;
    }
}