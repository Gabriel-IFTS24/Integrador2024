using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Integrador2024.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Integrador2024.Datos
{
    internal class Dal
    {
        private SqlConnection conn = new SqlConnection(Conexion.sConnection);
        private SqlCommand? cmd;
        private SqlDataReader? dr;

        // ***** Producto ***** //

        // ListarProducto devuelve una lista con todos los productos
        public List<Producto> ListarProducto(string Nombre = null, string Descripcion = null, string Proveedor = null)
        {
            List<Producto> ProductoLista = new List<Producto>();

            if (string.IsNullOrWhiteSpace(Nombre)) { Nombre = "NULL"; } else { Nombre = $"'{Nombre}'"; }
            if (string.IsNullOrWhiteSpace(Descripcion)) { Descripcion = "NULL"; } else { Descripcion = $"'{Descripcion}'"; }
            if (string.IsNullOrWhiteSpace(Proveedor)) { Proveedor = "NULL"; } else { Proveedor = $"'{Proveedor}'"; }

            string query = "declare @Nombre as varchar(100) " +
                "declare @Descripcion as varchar(100) " +
                "declare @Proveedor as varchar(100) " +
                $"SET @Nombre = {Nombre} " +
                $"SET @Descripcion = {Descripcion} " +
                $"SET @Proveedor = {Proveedor} " +

                "SELECT * FROM Producto " +
                "WHERE (@Nombre IS NULL OR NOMBRE LIKE '%' + @Nombre + '%') and (@Descripcion IS NULL OR DESCRIPCION LIKE '%' + @Descripcion + '%') and (@Proveedor IS NULL OR PROVEEDOR LIKE '%' + @Proveedor + '%') " + 
                "order by ID_PRODUCTO DESC ";

            try
            {
                conn.Open(); // Abro la conexión

                cmd = new SqlCommand(query, conn);

                dr = cmd.ExecuteReader(); // Ejecuta el datareader para obtener los datos

                if (dr != null) // Verifica si hay una fila en el resultado
                {
                    while (dr.Read())
                    {
                        
                        // Como para instanciar necesito todos los datos, primero los guardo y después instancio
                        int pProductoId = Convert.ToInt32(dr["ID_PRODUCTO"]);
                        string pNombre = dr["NOMBRE"].ToString();
                        string pDescripcion = dr["DESCRIPCION"].ToString();
                        decimal pPrecioCosto = Convert.ToDecimal(dr["PRECIOCOSTO"]);
                        string pProveedor = dr["PROVEEDOR"].ToString();
                        string pCategoria = dr["CATEGORIA"].ToString();
                        string pSubCategoria = dr["SUBCATEGORIA"].ToString();
                        double pMargen = Convert.ToDouble(dr["MARGEN"]);
                        double pIVA = Convert.ToDouble(dr["IVA"]);

                        // Instancio Producto
                        Producto producto = new Producto(pProductoId, pNombre, pDescripcion, pPrecioCosto, pProveedor, pCategoria, pSubCategoria, pMargen, pIVA);

                        ProductoLista.Add(producto); // Agrego cada producto a la lista
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return ProductoLista; // Retorno la lista con los productos
        }

        // Sobre carga de ListarProducto recibe el ID y devuelve el producto
        public Producto ListarProducto(int productoId)
        {
            string query = $"select ID_PRODUCTO, NOMBRE, DESCRIPCION, PRECIOCOSTO, PROVEEDOR, CATEGORIA, SUBCATEGORIA, MARGEN, IVA, SUBCATEGORIA, PRECIOBRUTO, PRECIOVENTA " +
                $"from Producto where ID_PRODUCTO = {productoId}";

            Producto producto = null;


            try
            {
                conn.Open(); // Abro la conexión

                cmd = new SqlCommand(query, conn);

                dr = cmd.ExecuteReader(); // Ejecuta el datareader para obtener los datos

                if (dr != null) // Verifica si hay una fila en el resultado
                {
                    while (dr.Read())
                    {
                        // Como para instanciar necesito todos los datos, primero los guardo y después instancio
                        string pNombre = dr["NOMBRE"].ToString();
                        int pProductoId = Convert.ToInt32(dr["ID_PRODUCTO"]);
                        string pDescripcion = dr["DESCRIPCION"].ToString();
                        decimal pPrecioCosto = Convert.ToDecimal(dr["PRECIOCOSTO"]);
                        string pProveedor = dr["PROVEEDOR"].ToString();
                        string pCategoria = dr["CATEGORIA"].ToString();
                        string pSubCategoria = dr["SUBCATEGORIA"].ToString();
                        double pMargen = Convert.ToDouble(dr["MARGEN"]);
                        double pIVA = Convert.ToDouble(dr["IVA"]);

                        // Instancio Producto
                        producto = new Producto(pProductoId, pNombre, pDescripcion, pPrecioCosto, pProveedor, pCategoria, pSubCategoria, pMargen, pIVA);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar el usuario:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return producto;

        }

        // Metodo CrearProducto recibe un producto sin Id (id=-1) y realiza el insert.
        public void CrearProducto(Producto producto)
        {
            // Defino las variables que voy a usar en la sentencia y las inicializo con los atributos que me viene del objeto Producto del form

            string pNombre = producto.Nombre;
            string pDescripcion = producto.Descripcion;
            string pPrecioCosto = Convert.ToString(producto.PrecioCosto).Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)
            string pProveedor = producto.Proveedor;
            string pCategoria = producto.Categoria;
            string pSubCategoria = producto.SubCategoria;
            string pMargen = producto.Margen.ToString().Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)
            double pIVA = producto.IVA;
            string pPrecioBruto = Convert.ToString(producto.PrecioBruto).Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)
            string pPrecioVenta = Convert.ToString(producto.PrecioVenta).Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)

            string insert = "INSERT INTO PRODUCTO ([NOMBRE], [DESCRIPCION], [PRECIOCOSTO], [PROVEEDOR], [CATEGORIA], [SUBCATEGORIA], [MARGEN], [IVA], [PRECIOBRUTO], [PRECIOVENTA]) " +
                            $"VALUES ('{pNombre}', '{pDescripcion}', '{pPrecioCosto}', '{pProveedor}', '{pCategoria}', '{pSubCategoria}', '{pMargen}', '{pIVA}', '{pPrecioBruto}', '{pPrecioVenta}')";

            try
            {
                // Abro la conexión con el metodo en la clase estática DatabaseConnection
                conn.Open();

                // Configuro el comando con la consulta y parametros
                cmd = new SqlCommand(insert, conn);

                // Ejecuta el insert
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        // Metodo EditarProducto recibe un producto con Id y realiza el update.
        public void EditarProducto(Producto producto)
        {
            // Defino las variables que voy a usar en la sentencia y las inicializo con los atributos que me viene del objeto Producto del form

            int pProductoId = producto.ProductoId;
            string pNombre = producto.Nombre;
            string pDescripcion = producto.Descripcion;
            string pPrecioCosto = producto.PrecioCosto.ToString().Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)
            string pProveedor = producto.Proveedor;
            string pCategoria = producto.Categoria;
            string pSubCategoria = producto.SubCategoria;
            string pMargen = producto.Margen.ToString().Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)
            double pIVA = producto.IVA;
            string pPrecioBruto = producto.PrecioBruto.ToString().Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)
            string pPrecioVenta = producto.PrecioVenta.ToString().Replace(",", "."); // como llegan con , el sql le agrega 2 decimales (de 123,00 pasa a 12300.00)

            string update = $"update PRODUCTO SET [NOMBRE] = '{pNombre}', [DESCRIPCION] = '{pDescripcion}', [PRECIOCOSTO] = '{pPrecioCosto}', [PROVEEDOR] = '{pProveedor}', [CATEGORIA] = '{pCategoria}', [SUBCATEGORIA] = '{pSubCategoria}', [MARGEN] = '{pMargen}', [IVA] = '{pIVA}', [PRECIOBRUTO] ='{pPrecioBruto}' , [PRECIOVENTA] = '{pPrecioVenta}' " +
                            $"where ID_PRODUCTO = '{pProductoId}'";

            try
            {
                // Abro la conexión con el metodo en la clase estática DatabaseConnection
                conn.Open();

                // Configuro el comando con la consulta y parametros
                cmd = new SqlCommand(update, conn);

                // Ejecuta el insert
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        // Metodo EliminarProducto recibe un id y realiza el delete
        public void EliminarProducto(int pProductoId)
        {
            string delete = $"delete from PRODUCTO where ID_PRODUCTO = '{pProductoId}'";

            try
            {
                // Abro la conexión con el metodo en la clase estática DatabaseConnection
                conn.Open();

                // Configuro el comando con la consulta y parametros
                cmd = new SqlCommand(delete, conn);

                // Ejecuta el insert
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }




        // ***** Vendedor ***** //

        // ListarVendedor devuelve una lista con todos los vendedores si no recibe parámetro, sino busca el Apellido y/o Nombre que recibe
        public List<Vendedor> ListarVendedor(string Apellido = null, string Nombre = null)
        {
            List<Vendedor> VendedorLista = new List<Vendedor>();

            if (string.IsNullOrWhiteSpace(Apellido)) { Apellido = "NULL"; } else {Apellido = $"'{Apellido}'"; }
            if (string.IsNullOrWhiteSpace(Nombre)) { Nombre = "NULL"; } else { Nombre = $"'{Nombre}'"; }

            string query = "declare @Apellido as varchar(100) " +
            "declare @Nombre as varchar(100) " +
            $"SET @Apellido = {Apellido} " +
            $"SET @Nombre = {Nombre} " +
            "SELECT * FROM VENDEDOR " +
            "WHERE (@Apellido IS NULL OR APELLIDO LIKE '%' + @Apellido + '%') and (@Nombre IS NULL OR NOMBRE LIKE '%' + @Nombre + '%') " + 
            "order by ID_VENDEDOR DESC";

            try
            {
                conn.Open(); // Abro la conexión

                cmd = new SqlCommand(query, conn);

                dr = cmd.ExecuteReader(); // Ejecuta el datareader para obtener los datos

                if ((dr != null)) // Verifica si hay una fila en el resultado
                {
                    while (dr.Read())
                    {

                        // Como para instanciar necesito todos los datos, primero los guardo y después instancio
                        int pVendedorId = Convert.ToInt32(dr["ID_VENDEDOR"]);
                        string pNombre = dr["NOMBRE"].ToString();
                        string pApellido = dr["APELLIDO"].ToString();
                        string pDNI = dr["DNI"].ToString();
                        string pCUIT = dr["CUIT"].ToString();

                        // Instancio Vendedor
                        Vendedor vendedor = new Vendedor(pVendedorId, pNombre, pApellido, pDNI, pCUIT);

                        VendedorLista.Add(vendedor); // Agrego cada vendedor a la lista
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return VendedorLista; // Retorno la lista con los vendedores
        }

        // Sobre carga de ListarVendedor recibe el ID y devuelve el producto
        public Vendedor ListarVendedor(int VendedorId)
        {
            string query = $"select ID_VENDEDOR, NOMBRE, APELLIDO, DNI, CUIT " +
                $"from vendedor where ID_VENDEDOR = {VendedorId}";

            Vendedor vendedor = null;


            try
            {
                conn.Open(); // Abro la conexión

                cmd = new SqlCommand(query, conn);

                dr = cmd.ExecuteReader(); // Ejecuta el datareader para obtener los datos

                if (dr != null) // Verifica si hay una fila en el resultado
                {
                    while (dr.Read())
                    {
                        // Como para instanciar necesito todos los datos, primero los guardo y después instancio
                        int pVendedorId = Convert.ToInt32(dr["ID_VENDEDOR"]);
                        string pNombre = dr["NOMBRE"].ToString();
                        string pApellido = dr["APELLIDO"].ToString();
                        string pDNI = dr["DNI"].ToString();
                        string pCUIT = dr["CUIT"].ToString();

                        // Instancio Vendedor
                        vendedor = new Vendedor(pVendedorId, pNombre, pApellido, pDNI, pCUIT);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrió un error inesperado al buscar el usuario:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return vendedor;

        }

        // Metodo CrearVendedor recibe un vendedor sin Id (id=-1) y realiza el insert.
        public void CrearVendedor(Vendedor vendedor)
        {
            // Defino las variables que voy a usar en la sentencia y las inicializo con los atributos que me viene del objeto Producto del form

            string pNombre = vendedor.Nombre;
            string pApellido = vendedor.Apellido;
            string pDNI = vendedor.DNI;
            string pCUIT = vendedor.CUIT;

            string insert = "INSERT INTO VENDEDOR ([NOMBRE], [APELLIDO], [DNI], [CUIT]) " +
                            $"VALUES ('{pNombre}', '{pApellido}', '{pDNI}', '{pCUIT}')";

            try
            {
                // Abro la conexión con el metodo en la clase estática DatabaseConnection
                conn.Open();

                // Configuro el comando con la consulta y parametros
                cmd = new SqlCommand(insert, conn);

                // Ejecuta el insert
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        // Metodo EditarProducto recibe un producto con Id y realiza el update.
        public void EditarVendedor(Vendedor vendedor)
        {
            // Defino las variables que voy a usar en la sentencia y las inicializo con los atributos que me viene del objeto Vendedor del form

            int pVendedorId = vendedor.VendedorId;
            string pNombre = vendedor.Nombre;
            string pApellido = vendedor.Apellido;
            string pDNI = vendedor.DNI; 
            string pCUIT = vendedor.CUIT;


            string update = $"update VENDEDOR SET [NOMBRE] = '{pNombre}', [APELLIDO] = '{pApellido}', [DNI] = '{pDNI}', [CUIT] = '{pCUIT}' " +
                            $"where ID_VENDEDOR = '{pVendedorId}'";

            try
            {
                // Abro la conexión con el metodo en la clase estática DatabaseConnection
                conn.Open();

                // Configuro el comando con la consulta y parametros
                cmd = new SqlCommand(update, conn);

                // Ejecuta el insert
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        // Metodo EliminarVendedor recibe un id y realiza el delete
        public void EliminarVendedor(int pVendedorId)
        {
            string delete = $"delete from VENDEDOR where ID_VENDEDOR = '{pVendedorId}'";

            try
            {
                // Abro la conexión con el metodo en la clase estática DatabaseConnection
                conn.Open();

                // Configuro el comando con la consulta y parametros
                cmd = new SqlCommand(delete, conn);

                // Ejecuta el insert
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error inesperado al buscar los datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }



        // ***** Usuario ***** //

        public Usuario BuscarUsuario(string username, string password)
        {
            string query = $"SELECT * FROM Usuario WHERE login = '{username}' AND passw = '{password}'";
            Usuario usuario = null;

            try
            {
                conn.Open(); // Abro la conexión

                cmd = new SqlCommand(query, conn);

                dr = cmd.ExecuteReader(); // Ejecuta el datareader para obtener los datos

                if (dr.Read())  // Verifica si hay una fila en el resultado
                {

                    string pUserName = dr["LOGIN"].ToString(); 
                    string pPassword = dr["PASSW"].ToString();
                    
                    usuario = new(pUserName, pPassword);
                    
                }
                else
                {
                    usuario = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error de conexión con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al buscar el usuario:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

         return usuario;

        }


    }
}
