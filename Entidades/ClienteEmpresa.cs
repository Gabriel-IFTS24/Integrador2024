using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class ClienteEmpresa : Cliente
    {
        public string Contacto { get; set; }

        public ClienteEmpresa(string pNombre, string CUIT, string pContacto, string Email, string Telefono, string Direccion)
        {
            this.Nombre = pNombre;
            this.CUIT = CUIT;
            this.Contacto = pContacto;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;

        }

    }
}

