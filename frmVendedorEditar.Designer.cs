namespace Integrador2024
{
    partial class frmVendedorEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedorEditar));
            pbxVendedor = new PictureBox();
            lblCUITVendedor = new Label();
            lblDNIVendedor = new Label();
            lblApellidoVendedor = new Label();
            lblNombreVendedor = new Label();
            MTBCUITVendedor = new MaskedTextBox();
            txtDNIVendedor = new TextBox();
            txtApellidoVendedor = new TextBox();
            txtNombreVendedor = new TextBox();
            btnCancelar = new Button();
            btnGrabarProducto = new Button();
            ID = new Label();
            txtIdVendedor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).BeginInit();
            SuspendLayout();
            // 
            // pbxVendedor
            // 
            pbxVendedor.Image = (Image)resources.GetObject("pbxVendedor.Image");
            pbxVendedor.Location = new Point(254, 15);
            pbxVendedor.Name = "pbxVendedor";
            pbxVendedor.Size = new Size(130, 116);
            pbxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVendedor.TabIndex = 17;
            pbxVendedor.TabStop = false;
            // 
            // lblCUITVendedor
            // 
            lblCUITVendedor.AutoSize = true;
            lblCUITVendedor.Location = new Point(24, 111);
            lblCUITVendedor.Name = "lblCUITVendedor";
            lblCUITVendedor.Size = new Size(32, 15);
            lblCUITVendedor.TabIndex = 16;
            lblCUITVendedor.Text = "CUIT";
            // 
            // lblDNIVendedor
            // 
            lblDNIVendedor.AutoSize = true;
            lblDNIVendedor.Location = new Point(24, 71);
            lblDNIVendedor.Name = "lblDNIVendedor";
            lblDNIVendedor.Size = new Size(27, 15);
            lblDNIVendedor.TabIndex = 15;
            lblDNIVendedor.Text = "DNI";
            // 
            // lblApellidoVendedor
            // 
            lblApellidoVendedor.AutoSize = true;
            lblApellidoVendedor.Location = new Point(24, 151);
            lblApellidoVendedor.Name = "lblApellidoVendedor";
            lblApellidoVendedor.Size = new Size(60, 15);
            lblApellidoVendedor.TabIndex = 14;
            lblApellidoVendedor.Text = "APELLIDO";
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Location = new Point(24, 191);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(56, 15);
            lblNombreVendedor.TabIndex = 13;
            lblNombreVendedor.Text = "NOMBRE";
            // 
            // MTBCUITVendedor
            // 
            MTBCUITVendedor.Location = new Point(90, 108);
            MTBCUITVendedor.Mask = "99-99999999-9";
            MTBCUITVendedor.Name = "MTBCUITVendedor";
            MTBCUITVendedor.Size = new Size(100, 23);
            MTBCUITVendedor.TabIndex = 1;
            // 
            // txtDNIVendedor
            // 
            txtDNIVendedor.Location = new Point(90, 68);
            txtDNIVendedor.MaxLength = 8;
            txtDNIVendedor.Name = "txtDNIVendedor";
            txtDNIVendedor.Size = new Size(100, 23);
            txtDNIVendedor.TabIndex = 0;
            // 
            // txtApellidoVendedor
            // 
            txtApellidoVendedor.CharacterCasing = CharacterCasing.Upper;
            txtApellidoVendedor.Location = new Point(90, 148);
            txtApellidoVendedor.Name = "txtApellidoVendedor";
            txtApellidoVendedor.Size = new Size(294, 23);
            txtApellidoVendedor.TabIndex = 2;
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.CharacterCasing = CharacterCasing.Upper;
            txtNombreVendedor.Location = new Point(90, 188);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(294, 23);
            txtNombreVendedor.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(268, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabarProducto
            // 
            btnGrabarProducto.Image = Properties.Resources.Guardar;
            btnGrabarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrabarProducto.Location = new Point(268, 227);
            btnGrabarProducto.Name = "btnGrabarProducto";
            btnGrabarProducto.Size = new Size(85, 30);
            btnGrabarProducto.TabIndex = 4;
            btnGrabarProducto.Text = "Grabar";
            btnGrabarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnGrabarProducto.UseVisualStyleBackColor = true;
            btnGrabarProducto.Click += btnGrabarProducto_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(24, 31);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 52;
            ID.Text = "ID";
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Enabled = false;
            txtIdVendedor.Location = new Point(90, 28);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(100, 23);
            txtIdVendedor.TabIndex = 10;
            txtIdVendedor.TextAlign = HorizontalAlignment.Right;
            // 
            // frmVendedorEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 312);
            Controls.Add(txtIdVendedor);
            Controls.Add(ID);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabarProducto);
            Controls.Add(pbxVendedor);
            Controls.Add(lblCUITVendedor);
            Controls.Add(lblDNIVendedor);
            Controls.Add(lblApellidoVendedor);
            Controls.Add(lblNombreVendedor);
            Controls.Add(MTBCUITVendedor);
            Controls.Add(txtDNIVendedor);
            Controls.Add(txtApellidoVendedor);
            Controls.Add(txtNombreVendedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVendedorEditar";
            Text = "Alta o edicion de vendedor";
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxVendedor;
        private Label lblCUITVendedor;
        private Label lblDNIVendedor;
        private Label lblApellidoVendedor;
        private Label lblNombreVendedor;
        private MaskedTextBox MTBCUITVendedor;
        private TextBox txtDNIVendedor;
        private TextBox txtApellidoVendedor;
        private TextBox txtNombreVendedor;
        private Button btnCancelar;
        private Button btnGrabarProducto;
        private Label ID;
        private TextBox txtIdVendedor;
    }
}