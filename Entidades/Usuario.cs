using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class Usuario
    {
        string UsuarioID {  get; set; }
        string ApellidoNombre { get; set; }
        string Password { get; set; }

        public Usuario(string pUsuarioID, string pPassword)
        {
            this.UsuarioID = pUsuarioID;
            this.Password = pPassword;
        }

        public bool UsuarioValido()
        {
            return true;
        }
    }
}
