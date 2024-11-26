namespace Integrador2024
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tbcPrincipal = new TabControl();
            tcbProducto = new TabPage();
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
            tbcVendedor = new TabPage();
            pbxVendedor = new PictureBox();
            lblCUITVendedor = new Label();
            lblDNIVendedor = new Label();
            lblApellidoVendedor = new Label();
            lblNombreVendedor = new Label();
            MTBCUITVendedor = new MaskedTextBox();
            txtDNIVendedor = new TextBox();
            txtApellidoVendedor = new TextBox();
            txtNombreVendedor = new TextBox();
            tbcClienteIndividuo = new TabPage();
            tbcClienteEmpresa = new TabPage();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            tbcPrincipal.SuspendLayout();
            tcbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).BeginInit();
            tbcVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 20);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Alt | Keys.F4;
            toolStripMenuItem2.Size = new Size(138, 22);
            toolStripMenuItem2.Text = "Salir";
            // 
            // tbcPrincipal
            // 
            tbcPrincipal.Controls.Add(tcbProducto);
            tbcPrincipal.Controls.Add(tbcVendedor);
            tbcPrincipal.Controls.Add(tbcClienteIndividuo);
            tbcPrincipal.Controls.Add(tbcClienteEmpresa);
            tbcPrincipal.Dock = DockStyle.Fill;
            tbcPrincipal.ImageList = imageList1;
            tbcPrincipal.Location = new Point(0, 24);
            tbcPrincipal.Name = "tbcPrincipal";
            tbcPrincipal.SelectedIndex = 0;
            tbcPrincipal.Size = new Size(564, 482);
            tbcPrincipal.SizeMode = TabSizeMode.Fixed;
            tbcPrincipal.TabIndex = 1;
            // 
            // tcbProducto
            // 
            tcbProducto.Controls.Add(cbbIVA);
            tcbProducto.Controls.Add(label1);
            tcbProducto.Controls.Add(btnGrabarProducto);
            tcbProducto.Controls.Add(pbxFotoproducto);
            tcbProducto.Controls.Add(cbbSubCategoria);
            tcbProducto.Controls.Add(cbbCategoria);
            tcbProducto.Controls.Add(txtProveedor);
            tcbProducto.Controls.Add(txtPrecioVenta);
            tcbProducto.Controls.Add(txtPrecioBruto);
            tcbProducto.Controls.Add(txtIVA);
            tcbProducto.Controls.Add(txtMargen);
            tcbProducto.Controls.Add(txtPrecioCosto);
            tcbProducto.Controls.Add(txtDescripcion);
            tcbProducto.Controls.Add(txtNombre);
            tcbProducto.Controls.Add(lblSubCategoriaProducto);
            tcbProducto.Controls.Add(lblCategoriaProducto);
            tcbProducto.Controls.Add(lblProveedorProducto);
            tcbProducto.Controls.Add(lblPrecioVentaProducto);
            tcbProducto.Controls.Add(lblPrecioBrutoProducto);
            tcbProducto.Controls.Add(lblIVAProducto);
            tcbProducto.Controls.Add(lblMargenProducto);
            tcbProducto.Controls.Add(lblPrecioCostoProducto);
            tcbProducto.Controls.Add(lblDescripcionProducto);
            tcbProducto.Controls.Add(lblNombreProducto);
            tcbProducto.ImageIndex = 2;
            tcbProducto.Location = new Point(4, 24);
            tcbProducto.Name = "tcbProducto";
            tcbProducto.Padding = new Padding(3);
            tcbProducto.Size = new Size(556, 454);
            tcbProducto.TabIndex = 0;
            tcbProducto.Text = "Productos";
            tcbProducto.ToolTipText = "P";
            tcbProducto.UseVisualStyleBackColor = true;
            // 
            // cbbIVA
            // 
            cbbIVA.FormattingEnabled = true;
            cbbIVA.Items.AddRange(new object[] { "21%", "10,5%" });
            cbbIVA.Location = new Point(113, 211);
            cbbIVA.Name = "cbbIVA";
            cbbIVA.Size = new Size(100, 23);
            cbbIVA.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 214);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 22;
            label1.Text = "IVA";
            // 
            // btnGrabarProducto
            // 
            btnGrabarProducto.Location = new Point(308, 385);
            btnGrabarProducto.Name = "btnGrabarProducto";
            btnGrabarProducto.Size = new Size(75, 23);
            btnGrabarProducto.TabIndex = 8;
            btnGrabarProducto.Text = "Grabar";
            btnGrabarProducto.UseVisualStyleBackColor = true;
            // 
            // pbxFotoproducto
            // 
            pbxFotoproducto.Image = (Image)resources.GetObject("pbxFotoproducto.Image");
            pbxFotoproducto.Location = new Point(258, 94);
            pbxFotoproducto.Name = "pbxFotoproducto";
            pbxFotoproducto.Size = new Size(185, 179);
            pbxFotoproducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFotoproducto.TabIndex = 20;
            pbxFotoproducto.TabStop = false;
            // 
            // cbbSubCategoria
            // 
            cbbSubCategoria.FormattingEnabled = true;
            cbbSubCategoria.Items.AddRange(new object[] { "SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.C" });
            cbbSubCategoria.Location = new Point(113, 406);
            cbbSubCategoria.Name = "cbbSubCategoria";
            cbbSubCategoria.Size = new Size(121, 23);
            cbbSubCategoria.TabIndex = 7;
            // 
            // cbbCategoria
            // 
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Items.AddRange(new object[] { "CATEGORIA A", "CATEGORIA B", "CATEGORIA C" });
            cbbCategoria.Location = new Point(113, 367);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(121, 23);
            cbbCategoria.TabIndex = 6;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(113, 328);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(330, 23);
            txtProveedor.TabIndex = 5;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new Point(113, 289);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 16;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecioBruto
            // 
            txtPrecioBruto.Enabled = false;
            txtPrecioBruto.Location = new Point(113, 172);
            txtPrecioBruto.Name = "txtPrecioBruto";
            txtPrecioBruto.Size = new Size(100, 23);
            txtPrecioBruto.TabIndex = 15;
            txtPrecioBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtIVA
            // 
            txtIVA.Enabled = false;
            txtIVA.Location = new Point(113, 250);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 23);
            txtIVA.TabIndex = 14;
            txtIVA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMargen
            // 
            txtMargen.Location = new Point(113, 133);
            txtMargen.Name = "txtMargen";
            txtMargen.Size = new Size(100, 23);
            txtMargen.TabIndex = 3;
            txtMargen.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(113, 94);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(100, 23);
            txtPrecioCosto.TabIndex = 2;
            txtPrecioCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(113, 50);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(330, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(330, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblSubCategoriaProducto
            // 
            lblSubCategoriaProducto.AutoSize = true;
            lblSubCategoriaProducto.Location = new Point(16, 409);
            lblSubCategoriaProducto.Name = "lblSubCategoriaProducto";
            lblSubCategoriaProducto.Size = new Size(90, 15);
            lblSubCategoriaProducto.TabIndex = 9;
            lblSubCategoriaProducto.Text = "SUBCATEGORIA";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Location = new Point(18, 370);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.RightToLeft = RightToLeft.Yes;
            lblCategoriaProducto.Size = new Size(69, 15);
            lblCategoriaProducto.TabIndex = 8;
            lblCategoriaProducto.Text = "CATEGORIA";
            // 
            // lblProveedorProducto
            // 
            lblProveedorProducto.AutoSize = true;
            lblProveedorProducto.Location = new Point(16, 331);
            lblProveedorProducto.Name = "lblProveedorProducto";
            lblProveedorProducto.Size = new Size(73, 15);
            lblProveedorProducto.TabIndex = 7;
            lblProveedorProducto.Text = "PROVEEDOR";
            // 
            // lblPrecioVentaProducto
            // 
            lblPrecioVentaProducto.AutoSize = true;
            lblPrecioVentaProducto.Location = new Point(18, 292);
            lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            lblPrecioVentaProducto.Size = new Size(85, 15);
            lblPrecioVentaProducto.TabIndex = 6;
            lblPrecioVentaProducto.Text = "PRECIO VENTA";
            // 
            // lblPrecioBrutoProducto
            // 
            lblPrecioBrutoProducto.AutoSize = true;
            lblPrecioBrutoProducto.Location = new Point(16, 175);
            lblPrecioBrutoProducto.Name = "lblPrecioBrutoProducto";
            lblPrecioBrutoProducto.Size = new Size(86, 15);
            lblPrecioBrutoProducto.TabIndex = 5;
            lblPrecioBrutoProducto.Text = "PRECIO BRUTO";
            // 
            // lblIVAProducto
            // 
            lblIVAProducto.AutoSize = true;
            lblIVAProducto.Location = new Point(18, 253);
            lblIVAProducto.Name = "lblIVAProducto";
            lblIVAProducto.Size = new Size(67, 15);
            lblIVAProducto.TabIndex = 4;
            lblIVAProducto.Text = "PRECIO IVA";
            // 
            // lblMargenProducto
            // 
            lblMargenProducto.AutoSize = true;
            lblMargenProducto.Location = new Point(16, 136);
            lblMargenProducto.Name = "lblMargenProducto";
            lblMargenProducto.Size = new Size(56, 15);
            lblMargenProducto.TabIndex = 3;
            lblMargenProducto.Text = "MARGEN";
            // 
            // lblPrecioCostoProducto
            // 
            lblPrecioCostoProducto.AutoSize = true;
            lblPrecioCostoProducto.Location = new Point(16, 97);
            lblPrecioCostoProducto.Name = "lblPrecioCostoProducto";
            lblPrecioCostoProducto.Size = new Size(87, 15);
            lblPrecioCostoProducto.TabIndex = 2;
            lblPrecioCostoProducto.Text = "PRECIO COSTO";
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.AutoSize = true;
            lblDescripcionProducto.Location = new Point(16, 58);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(81, 15);
            lblDescripcionProducto.TabIndex = 1;
            lblDescripcionProducto.Text = "DESCRIPCION";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(18, 19);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(56, 15);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "NOMBRE";
            // 
            // tbcVendedor
            // 
            tbcVendedor.Controls.Add(pbxVendedor);
            tbcVendedor.Controls.Add(lblCUITVendedor);
            tbcVendedor.Controls.Add(lblDNIVendedor);
            tbcVendedor.Controls.Add(lblApellidoVendedor);
            tbcVendedor.Controls.Add(lblNombreVendedor);
            tbcVendedor.Controls.Add(MTBCUITVendedor);
            tbcVendedor.Controls.Add(txtDNIVendedor);
            tbcVendedor.Controls.Add(txtApellidoVendedor);
            tbcVendedor.Controls.Add(txtNombreVendedor);
            tbcVendedor.ImageIndex = 3;
            tbcVendedor.Location = new Point(4, 24);
            tbcVendedor.Name = "tbcVendedor";
            tbcVendedor.Padding = new Padding(3);
            tbcVendedor.Size = new Size(556, 454);
            tbcVendedor.TabIndex = 1;
            tbcVendedor.Text = "Vendedores";
            tbcVendedor.ToolTipText = "V";
            tbcVendedor.UseVisualStyleBackColor = true;
            // 
            // pbxVendedor
            // 
            pbxVendedor.Image = (Image)resources.GetObject("pbxVendedor.Image");
            pbxVendedor.Location = new Point(258, 94);
            pbxVendedor.Name = "pbxVendedor";
            pbxVendedor.Size = new Size(185, 179);
            pbxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVendedor.TabIndex = 8;
            pbxVendedor.TabStop = false;
            // 
            // lblCUITVendedor
            // 
            lblCUITVendedor.AutoSize = true;
            lblCUITVendedor.Location = new Point(18, 136);
            lblCUITVendedor.Name = "lblCUITVendedor";
            lblCUITVendedor.Size = new Size(32, 15);
            lblCUITVendedor.TabIndex = 7;
            lblCUITVendedor.Text = "CUIT";
            // 
            // lblDNIVendedor
            // 
            lblDNIVendedor.AutoSize = true;
            lblDNIVendedor.Location = new Point(18, 102);
            lblDNIVendedor.Name = "lblDNIVendedor";
            lblDNIVendedor.Size = new Size(27, 15);
            lblDNIVendedor.TabIndex = 6;
            lblDNIVendedor.Text = "DNI";
            // 
            // lblApellidoVendedor
            // 
            lblApellidoVendedor.AutoSize = true;
            lblApellidoVendedor.Location = new Point(18, 58);
            lblApellidoVendedor.Name = "lblApellidoVendedor";
            lblApellidoVendedor.Size = new Size(60, 15);
            lblApellidoVendedor.TabIndex = 5;
            lblApellidoVendedor.Text = "APELLIDO";
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Location = new Point(18, 19);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(56, 15);
            lblNombreVendedor.TabIndex = 4;
            lblNombreVendedor.Text = "NOMBRE";
            // 
            // MTBCUITVendedor
            // 
            MTBCUITVendedor.Location = new Point(113, 133);
            MTBCUITVendedor.Mask = "99-99999999-9";
            MTBCUITVendedor.Name = "MTBCUITVendedor";
            MTBCUITVendedor.Size = new Size(100, 23);
            MTBCUITVendedor.TabIndex = 3;
            // 
            // txtDNIVendedor
            // 
            txtDNIVendedor.Location = new Point(113, 94);
            txtDNIVendedor.Name = "txtDNIVendedor";
            txtDNIVendedor.Size = new Size(100, 23);
            txtDNIVendedor.TabIndex = 2;
            // 
            // txtApellidoVendedor
            // 
            txtApellidoVendedor.Location = new Point(113, 55);
            txtApellidoVendedor.Name = "txtApellidoVendedor";
            txtApellidoVendedor.Size = new Size(330, 23);
            txtApellidoVendedor.TabIndex = 1;
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(113, 16);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(330, 23);
            txtNombreVendedor.TabIndex = 0;
            // 
            // tbcClienteIndividuo
            // 
            tbcClienteIndividuo.ImageIndex = 0;
            tbcClienteIndividuo.Location = new Point(4, 24);
            tbcClienteIndividuo.Name = "tbcClienteIndividuo";
            tbcClienteIndividuo.Size = new Size(556, 454);
            tbcClienteIndividuo.TabIndex = 2;
            tbcClienteIndividuo.Text = "Clientes";
            tbcClienteIndividuo.ToolTipText = "C";
            tbcClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // tbcClienteEmpresa
            // 
            tbcClienteEmpresa.ImageIndex = 1;
            tbcClienteEmpresa.Location = new Point(4, 24);
            tbcClienteEmpresa.Name = "tbcClienteEmpresa";
            tbcClienteEmpresa.Size = new Size(556, 454);
            tbcClienteEmpresa.TabIndex = 3;
            tbcClienteEmpresa.Text = "Empresas";
            tbcClienteEmpresa.ToolTipText = "E";
            tbcClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Clientes.ico");
            imageList1.Images.SetKeyName(1, "Empresas.ico");
            imageList1.Images.SetKeyName(2, "Productos.ico");
            imageList1.Images.SetKeyName(3, "Vendedores.ico");
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 506);
            Controls.Add(tbcPrincipal);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSUMOS DE COMPUTACIÓN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbcPrincipal.ResumeLayout(false);
            tcbProducto.ResumeLayout(false);
            tcbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).EndInit();
            tbcVendedor.ResumeLayout(false);
            tbcVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private TabControl tbcPrincipal;
        private TabPage tcbProducto;
        private TabPage tbcVendedor;
        private TabPage tbcClienteIndividuo;
        private TabPage tbcClienteEmpresa;
        private ImageList imageList1;
        private Label lblPrecioCostoProducto;
        private Label lblDescripcionProducto;
        private Label lblNombreProducto;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblSubCategoriaProducto;
        private Label lblCategoriaProducto;
        private Label lblProveedorProducto;
        private Label lblPrecioVentaProducto;
        private Label lblPrecioBrutoProducto;
        private Label lblIVAProducto;
        private Label lblMargenProducto;
        private ComboBox cbbSubCategoria;
        private ComboBox cbbCategoria;
        private TextBox txtProveedor;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioBruto;
        private TextBox txtIVA;
        private TextBox txtMargen;
        private TextBox txtPrecioCosto;
        private PictureBox pbxFotoproducto;
        private TextBox txtNombreVendedor;
        private MaskedTextBox MTBCUITVendedor;
        private TextBox txtDNIVendedor;
        private TextBox txtApellidoVendedor;
        private Label lblCUITVendedor;
        private Label lblDNIVendedor;
        private Label lblApellidoVendedor;
        private Label lblNombreVendedor;
        private PictureBox pbxVendedor;
        private Button btnGrabarProducto;
        private ComboBox cbbIVA;
        private Label label1;
    }
}
