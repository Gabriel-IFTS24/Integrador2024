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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        
        // Función que controla si se presiona enter sobre el password; en ese caso hace el logueo
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtPassword.Text.Trim();

            Dal dal = new Dal();

            Usuario usuarioLogin = dal.BuscarUsuario(user, pass);

            if (usuarioLogin != null)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Error de Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = "MOSTRAR".Equals(pic_mostrarPass.Tag) ? '*' : '\0';

            pic_mostrarPass.Image = "MOSTRAR".Equals(pic_mostrarPass.Tag) ? Integrador2024.Properties.Resources.ojo_normal : Integrador2024.Properties.Resources.ojo_tapado;

            pic_mostrarPass.Tag = "MOSTRAR".Equals(pic_mostrarPass.Tag) ? "OCULTO" : "MOSTRAR";
        }

    }
}
