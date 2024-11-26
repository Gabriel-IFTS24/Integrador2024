namespace Integrador2024
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            button1 = new Button();
            btnVendedores = new Button();
            btnClientes = new Button();
            btnEmpresas = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Productos;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(64, 28);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(195, 48);
            button1.TabIndex = 0;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.Image = Properties.Resources.Vendedores;
            btnVendedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendedores.Location = new Point(64, 98);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Padding = new Padding(10, 0, 0, 0);
            btnVendedores.Size = new Size(195, 48);
            btnVendedores.TabIndex = 1;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Image = Properties.Resources.Clientes;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(64, 168);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(195, 48);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnEmpresas
            // 
            btnEmpresas.Image = Properties.Resources.Empresas;
            btnEmpresas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpresas.Location = new Point(64, 238);
            btnEmpresas.Name = "btnEmpresas";
            btnEmpresas.Padding = new Padding(10, 0, 0, 0);
            btnEmpresas.Size = new Size(195, 48);
            btnEmpresas.TabIndex = 3;
            btnEmpresas.Text = "Empresas";
            btnEmpresas.UseVisualStyleBackColor = true;
            btnEmpresas.Click += btnEmpresas_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 313);
            Controls.Add(btnEmpresas);
            Controls.Add(btnClientes);
            Controls.Add(btnVendedores);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenuPrincipal";
            Text = "Menu principal";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnVendedores;
        private Button btnClientes;
        private Button btnEmpresas;
    }
}