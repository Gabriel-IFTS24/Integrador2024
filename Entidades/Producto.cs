using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class Producto
    {
        // Agrego ProductoId para poder instanciarlo
        public int ProductoId { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        
        // PrecioBruto es calculado en función de PrecioCosto y Margen y se define un getter manual
        public decimal PrecioBruto 
        {   get 
            { 
                return Convert.ToDecimal(this.PrecioCosto) + Convert.ToDecimal(this.Margen);
            } 
        }
        // PrecioVenta es calculado en función de PrecioBruto e IVA y se define un getter manual
        public decimal PrecioVenta
        {
            get
            {
                return Convert.ToDecimal(this.PrecioBruto) + Convert.ToDecimal(this.IVA);
            }
        }
        
        // Instanciación de productos siempre debe tener todos los atributos.
        public Producto(int pProductoId, string pNombre, string pDescripcion, decimal pPrecioCosto, string pProveedor, string pCategoria, string pSubCategoria, double pMargen, double pIVA)
        {
            this.ProductoId = pProductoId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.PrecioCosto = pPrecioCosto;
            this.Proveedor = pProveedor;
            this.Categoria = pCategoria;
            this.SubCategoria = pSubCategoria;
            this.Margen = pMargen;
            this.IVA = pIVA;
        }

        // Instanciación de productos sin el ID para cuando voy a hacer el alta.
        public Producto(string pNombre, string pDescripcion, decimal pPrecioCosto, string pProveedor, string pCategoria, string pSubCategoria, double pMargen, double pIVA)
        {
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.PrecioCosto = pPrecioCosto;
            this.Proveedor = pProveedor;
            this.Categoria = pCategoria;
            this.SubCategoria = pSubCategoria;
            this.Margen = pMargen;
            this.IVA = pIVA;
        }
    }
}
