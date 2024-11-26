namespace Integrador2024
{
    partial class frmProductoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductoEditar));
            cbbIVA = new ComboBox();
            label1 = new Label();
            btnGrabarProducto = new Button();
            pbxFotoproducto = new PictureBox();
            cbbSubCategoria = new ComboBox();
            cbbCategoria = new ComboBox();
            txtProveedor = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioBruto = new TextBox();
            txtIVA = new TextBox();
            txtMargen = new TextBox();
            txtPrecioCosto = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            lblSubCategoriaProducto = new Label();
            lblCategoriaProducto = new Label();
            lblProveedorProducto = new Label();
            lblPrecioVentaProducto = new Label();
            lblPrecioBrutoProducto = new Label();
            lblIVAProducto = new Label();
            lblMargenProducto = new Label();
            lblPrecioCostoProducto = new Label();
            lblDescripcionProducto = new Label();
            lblNombreProducto = new Label();
            ID = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).BeginInit();
            SuspendLayout();
            // 
            // cbbIVA
            // 
            cbbIVA.FormattingEnabled = true;
            cbbIVA.Items.AddRange(new object[] { "21%", "10,5%" });
            cbbIVA.Location = new Point(107, 249);
            cbbIVA.Name = "cbbIVA";
            cbbIVA.RightToLeft = RightToLeft.No;
            cbbIVA.Size = new Size(58, 23);
            cbbIVA.TabIndex = 31;
            cbbIVA.SelectedIndexChanged += cbbIVA_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 252);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 46;
            label1.Text = "IVA";
            // 
            // btnGrabarProducto
            // 
            btnGrabarProducto.Image = Properties.Resources.Guardar;
            btnGrabarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrabarProducto.Location = new Point(311, 400);
            btnGrabarProducto.Name = "btnGrabarProducto";
            btnGrabarProducto.Size = new Size(85, 30);
            btnGrabarProducto.TabIndex = 39;
            btnGrabarProducto.Text = "Grabar";
            btnGrabarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnGrabarProducto.UseVisualStyleBackColor = true;
            btnGrabarProducto.Click += btnGrabarProducto_Click_1;
            // 
            // pbxFotoproducto
            // 
            pbxFotoproducto.Image = (Image)resources.GetObject("pbxFotoproducto.Image");
            pbxFotoproducto.Location = new Point(252, 132);
            pbxFotoproducto.Name = "pbxFotoproducto";
            pbxFotoproducto.Size = new Size(185, 179);
            pbxFotoproducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFotoproducto.TabIndex = 45;
            pbxFotoproducto.TabStop = false;
            // 
            // cbbSubCategoria
            // 
            cbbSubCategoria.FormattingEnabled = true;
            cbbSubCategoria.Items.AddRange(new object[] { "SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.C" });
            cbbSubCategoria.Location = new Point(107, 444);
            cbbSubCategoria.Name = "cbbSubCategoria";
            cbbSubCategoria.Size = new Size(135, 23);
            cbbSubCategoria.TabIndex = 38;
            // 
            // cbbCategoria
            // 
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Items.AddRange(new object[] { "CATEGORIA A", "CATEGORIA B", "CATEGORIA C" });
            cbbCategoria.Location = new Point(107, 405);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(135, 23);
            cbbCategoria.TabIndex = 35;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(107, 366);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(330, 23);
            txtProveedor.TabIndex = 34;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new Point(107, 327);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 44;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecioBruto
            // 
            txtPrecioBruto.Enabled = false;
            txtPrecioBruto.Location = new Point(107, 210);
            txtPrecioBruto.Name = "txtPrecioBruto";
            txtPrecioBruto.Size = new Size(100, 23);
            txtPrecioBruto.TabIndex = 43;
            txtPrecioBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtIVA
            // 
            txtIVA.Enabled = false;
            txtIVA.Location = new Point(107, 288);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 23);
            txtIVA.TabIndex = 42;
            txtIVA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMargen
            // 
            txtMargen.Location = new Point(107, 171);
            txtMargen.Name = "txtMargen";
            txtMargen.Size = new Size(100, 23);
            txtMargen.TabIndex = 30;
            txtMargen.TextAlign = HorizontalAlignment.Right;
            txtMargen.Leave += txtMargen_Leave;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(107, 132);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(100, 23);
            txtPrecioCosto.TabIndex = 28;
            txtPrecioCosto.TextAlign = HorizontalAlignment.Right;
            txtPrecioCosto.Leave += txtPrecioCosto_Leave;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(107, 88);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(330, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(330, 23);
            txtNombre.TabIndex = 24;
            // 
            // lblSubCategoriaProducto
            // 
            lblSubCategoriaProducto.AutoSize = true;
            lblSubCategoriaProducto.Location = new Point(10, 447);
            lblSubCategoriaProducto.Name = "lblSubCategoriaProducto";
            lblSubCategoriaProducto.Size = new Size(90, 15);
            lblSubCategoriaProducto.TabIndex = 41;
            lblSubCategoriaProducto.Text = "SUBCATEGORIA";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Location = new Point(12, 408);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.RightToLeft = RightToLeft.Yes;
            lblCategoriaProducto.Size = new Size(69, 15);
            lblCategoriaProducto.TabIndex = 40;
            lblCategoriaProducto.Text = "CATEGORIA";
            // 
            // lblProveedorProducto
            // 
            lblProveedorProducto.AutoSize = true;
            lblProveedorProducto.Location = new Point(10, 369);
            lblProveedorProducto.Name = "lblProveedorProducto";
            lblProveedorProducto.Size = new Size(73, 15);
            lblProveedorProducto.TabIndex = 37;
            lblProveedorProducto.Text = "PROVEEDOR";
            // 
            // lblPrecioVentaProducto
            // 
            lblPrecioVentaProducto.AutoSize = true;
            lblPrecioVentaProducto.Location = new Point(12, 330);
            lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            lblPrecioVentaProducto.Size = new Size(85, 15);
            lblPrecioVentaProducto.TabIndex = 36;
            lblPrecioVentaProducto.Text = "PRECIO VENTA";
            // 
            // lblPrecioBrutoProducto
            // 
            lblPrecioBrutoProducto.AutoSize = true;
            lblPrecioBrutoProducto.Location = new Point(10, 213);
            lblPrecioBrutoProducto.Name = "lblPrecioBrutoProducto";
            lblPrecioBrutoProducto.Size = new Size(86, 15);
            lblPrecioBrutoProducto.TabIndex = 33;
            lblPrecioBrutoProducto.Text = "PRECIO BRUTO";
            // 
            // lblIVAProducto
            // 
            lblIVAProducto.AutoSize = true;
            lblIVAProducto.Location = new Point(12, 291);
            lblIVAProducto.Name = "lblIVAProducto";
            lblIVAProducto.Size = new Size(67, 15);
            lblIVAProducto.TabIndex = 32;
            lblIVAProducto.Text = "PRECIO IVA";
            // 
            // lblMargenProducto
            // 
            lblMargenProducto.AutoSize = true;
            lblMargenProducto.Location = new Point(10, 174);
            lblMargenProducto.Name = "lblMargenProducto";
            lblMargenProducto.Size = new Size(56, 15);
            lblMargenProducto.TabIndex = 29;
            lblMargenProducto.Text = "MARGEN";
            // 
            // lblPrecioCostoProducto
            // 
            lblPrecioCostoProducto.AutoSize = true;
            lblPrecioCostoProducto.Location = new Point(10, 135);
            lblPrecioCostoProducto.Name = "lblPrecioCostoProducto";
            lblPrecioCostoProducto.Size = new Size(87, 15);
            lblPrecioCostoProducto.TabIndex = 27;
            lblPrecioCostoProducto.Text = "PRECIO COSTO";
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.AutoSize = true;
            lblDescripcionProducto.Location = new Point(10, 96);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(81, 15);
            lblDescripcionProducto.TabIndex = 26;
            lblDescripcionProducto.Text = "DESCRIPCION";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(12, 57);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(56, 15);
            lblNombreProducto.TabIndex = 23;
            lblNombreProducto.Text = "NOMBRE";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(12, 25);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 47;
            ID.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(107, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 48;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(311, 439);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmProductoEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 492);
            Controls.Add(btnCancelar);
            Controls.Add(txtId);
            Controls.Add(ID);
            Controls.Add(cbbIVA);
            Controls.Add(label1);
            Controls.Add(btnGrabarProducto);
            Controls.Add(pbxFotoproducto);
            Controls.Add(cbbSubCategoria);
            Controls.Add(cbbCategoria);
            Controls.Add(txtProveedor);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioBruto);
            Controls.Add(txtIVA);
            Controls.Add(txtMargen);
            Controls.Add(txtPrecioCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblSubCategoriaProducto);
            Controls.Add(lblCategoriaProducto);
            Controls.Add(lblProveedorProducto);
            Controls.Add(lblPrecioVentaProducto);
            Controls.Add(lblPrecioBrutoProducto);
            Controls.Add(lblIVAProducto);
            Controls.Add(lblMargenProducto);
            Controls.Add(lblPrecioCostoProducto);
            Controls.Add(lblDescripcionProducto);
            Controls.Add(lblNombreProducto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProductoEditar";
            Text = "Alta o edicion de producto";
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbIVA;
        private Label label1;
        private Button btnGrabarProducto;
        private PictureBox pbxFotoproducto;
        private ComboBox cbbSubCategoria;
        private ComboBox cbbCategoria;
        private TextBox txtProveedor;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioBruto;
        private TextBox txtIVA;
        private TextBox txtMargen;
        private TextBox txtPrecioCosto;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblSubCategoriaProducto;
        private Label lblCategoriaProducto;
        private Label lblProveedorProducto;
        private Label lblPrecioVentaProducto;
        private Label lblPrecioBrutoProducto;
        private Label lblIVAProducto;
        private Label lblMargenProducto;
        private Label lblPrecioCostoProducto;
        private Label lblDescripcionProducto;
        private Label lblNombreProducto;
        private Label ID;
        private TextBox txtId;
        private Button btnCancelar;
    }
}