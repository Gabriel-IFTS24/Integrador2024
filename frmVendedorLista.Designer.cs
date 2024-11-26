namespace Integrador2024
{
    partial class frmVendedorLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedorLista));
            dgvVendedores = new DataGridView();
            btnEliminarVendedor = new Button();
            btnEditarVendedor = new Button();
            btnNuevoVendedor = new Button();
            txtVendedorApellido = new TextBox();
            btnBuscarVendedor = new Button();
            txtVendedorNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // dgvVendedores
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvVendedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVendedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(12, 105);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dgvVendedores.Size = new Size(560, 291);
            dgvVendedores.TabIndex = 6;
            // 
            // btnEliminarVendedor
            // 
            btnEliminarVendedor.Image = (Image)resources.GetObject("btnEliminarVendedor.Image");
            btnEliminarVendedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarVendedor.Location = new Point(428, 12);
            btnEliminarVendedor.Name = "btnEliminarVendedor";
            btnEliminarVendedor.Size = new Size(130, 30);
            btnEliminarVendedor.TabIndex = 2;
            btnEliminarVendedor.Text = "Eliminar Vendedor";
            btnEliminarVendedor.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarVendedor.UseVisualStyleBackColor = true;
            btnEliminarVendedor.Click += btnEliminarVendedor_Click;
            // 
            // btnEditarVendedor
            // 
            btnEditarVendedor.Image = Properties.Resources.Editar;
            btnEditarVendedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarVendedor.Location = new Point(227, 12);
            btnEditarVendedor.Name = "btnEditarVendedor";
            btnEditarVendedor.Size = new Size(130, 30);
            btnEditarVendedor.TabIndex = 1;
            btnEditarVendedor.Text = "Editar Vendedor";
            btnEditarVendedor.TextAlign = ContentAlignment.MiddleRight;
            btnEditarVendedor.UseVisualStyleBackColor = true;
            btnEditarVendedor.Click += btnEditarVendedor_Click;
            // 
            // btnNuevoVendedor
            // 
            btnNuevoVendedor.Image = Properties.Resources.Nuevo;
            btnNuevoVendedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoVendedor.Location = new Point(26, 12);
            btnNuevoVendedor.Name = "btnNuevoVendedor";
            btnNuevoVendedor.Size = new Size(130, 30);
            btnNuevoVendedor.TabIndex = 0;
            btnNuevoVendedor.Text = "Nuevo Vendedor";
            btnNuevoVendedor.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoVendedor.UseVisualStyleBackColor = true;
            btnNuevoVendedor.Click += btnNuevoVendedor_Click;
            // 
            // txtVendedorApellido
            // 
            txtVendedorApellido.Location = new Point(26, 59);
            txtVendedorApellido.Name = "txtVendedorApellido";
            txtVendedorApellido.PlaceholderText = "Ingrese fragmento del Apellido a buscar";
            txtVendedorApellido.Size = new Size(220, 23);
            txtVendedorApellido.TabIndex = 3;
            txtVendedorApellido.TextChanged += txtVendedorApellido_TextChanged;
            // 
            // btnBuscarVendedor
            // 
            btnBuscarVendedor.Image = Properties.Resources.Buscar;
            btnBuscarVendedor.Location = new Point(528, 54);
            btnBuscarVendedor.Name = "btnBuscarVendedor";
            btnBuscarVendedor.Size = new Size(29, 30);
            btnBuscarVendedor.TabIndex = 5;
            btnBuscarVendedor.UseVisualStyleBackColor = true;
            btnBuscarVendedor.Click += btnBuscarVendedor_Click;
            // 
            // txtVendedorNombre
            // 
            txtVendedorNombre.Location = new Point(277, 59);
            txtVendedorNombre.Name = "txtVendedorNombre";
            txtVendedorNombre.PlaceholderText = "Ingrese fragmento del Nombre a buscar";
            txtVendedorNombre.Size = new Size(220, 23);
            txtVendedorNombre.TabIndex = 4;
            txtVendedorNombre.TextChanged += txtVendedorNombre_TextChanged;
            // 
            // frmVendedorLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 408);
            Controls.Add(txtVendedorNombre);
            Controls.Add(btnBuscarVendedor);
            Controls.Add(txtVendedorApellido);
            Controls.Add(btnEliminarVendedor);
            Controls.Add(btnEditarVendedor);
            Controls.Add(btnNuevoVendedor);
            Controls.Add(dgvVendedores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVendedorLista";
            Text = "Listado de Vendedores";
            Activated += frmVendedorLista_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVendedores;
        private Button btnEliminarVendedor;
        private Button btnEditarVendedor;
        private Button btnNuevoVendedor;
        private TextBox txtVendedorApellido;
        private Button btnBuscarVendedor;
        private TextBox txtVendedorNombre;
    }
}