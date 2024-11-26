using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class ClienteIndividuo : Cliente
    {
        public string Apellido { get; set; }

    public ClienteIndividuo(string pApellido, string pNombre, string CUIT, string Email, string Telefono, string Direccion)
    {
        this.Apellido = pApellido;
        this.Nombre = pNombre;
        this.CUIT = CUIT;
        this.Email = Email;
        this.Telefono = Telefono;
        this.Direccion = Direccion;

    }

    }
}
