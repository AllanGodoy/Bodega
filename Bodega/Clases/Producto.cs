using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bodega.Clases
{
    internal class Producto
    {
        //---------llena el datagridView con todo los codigos
        public void MostrarProducto(DataGridView tablaProducto)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try{
                tablaProducto.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Producto;", objectoConexion.estableceConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProducto.DataSource = dt;
                objectoConexion.cerrarConexion();
            }
            catch (Exception ex){
                MessageBox.Show("No se logro mostrar registros, error = " + ex.ToString());
            }
        }

        //------Insertar registro en Base de Datos
        public void Insertar()
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {   string query = "insert into Producto (fecha, codigoProducto, nombre, Descripcion, InventarioInicial, CantidadActual, Estatus) values ('','','','','0','','')";
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                //  MessageBox.Show("Se guardo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar registros, error = " + ex.ToString());
            }
        }

        //------Inserta codigo en el datagrid
        public int InsertarCodigoGridView()
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            string query = "select top 1 Id from Producto order by Id desc";
            SqlCommand Comando = new SqlCommand(query, objectoConexion.estableceConexion());
            int Id = Convert.ToInt32(Comando.ExecuteScalar());
            // MessageBox.Show("VALOR:" + Id);
            return Id;
        }

        //----Editar registro en Base de Datos
        public void Editar(object paramId,object paramfecha, object paramCodigoProducto, object paramNombre, object paramDescripcion, 
                            object paramInventarioInicial, object paramCantidadActual, object paramEstatus)
        {
            

            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                string query = "update Producto set fecha='" + paramfecha + "',CodigoProducto = '" + paramCodigoProducto + "',nombre ='" + paramNombre + "', Descripcion='" + paramDescripcion + "', InventarioInicial='" + paramInventarioInicial + "', CantidadActual='" + paramCantidadActual + "', Estatus='" +paramEstatus + "' where id='" + paramId + "'";
                //MessageBox.Show("Query = "+ query);
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                // MessageBox.Show("Se modifico correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los registro, error ="+ex.ToString());
            }
        }

        //---- Eliminar registro en Base de Datos
        public void Eliminar(Object Id)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                string query = "delete from Producto where id =" + Id;
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                //  MessageBox.Show("Se elimino :"+ numero);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro eliminar los registros, error =" + ex.ToString());
            }
        }

        //----- Buscar Codigo
        public void BuscarCodigo(DataGridView tablaProducto, TextBox codigo)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                tablaProducto.DataSource = null;
                string sql = "select * from Producto where CodigoProducto like '%"+ codigo.Text+"%'";
                //MessageBox.Show("" + sql);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, objectoConexion.estableceConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProducto.DataSource = dt;
                objectoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar registros, error = " + ex.ToString());
            }
        }

        //----- Buscar Nombre
        public void BuscarNombre(DataGridView tablaProducto, TextBox Nombre)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                tablaProducto.DataSource = null;
                string sql = "select * from Producto where nombre like '%" + Nombre.Text + "%'";
                //MessageBox.Show("" + sql);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, objectoConexion.estableceConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProducto.DataSource = dt;
                objectoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar registros, error = " + ex.ToString());
            }
        }
    }
}