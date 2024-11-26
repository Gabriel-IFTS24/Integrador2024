using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class Vendedor
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string CUIT {  get; set; }

        public Vendedor(int pVendedorId, string pNombre, string pApellido, string pDNI, string pCUIT) 
        {
            this.VendedorId = pVendedorId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.CUIT = pCUIT;
        }
    }
}
