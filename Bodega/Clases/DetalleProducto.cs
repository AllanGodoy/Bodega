using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Bodega.Clases
{
    internal class DetalleProducto
    {
        //-------- llena datos del producto---------------

        public void mostrarProducto(object Id, TextBox parmCodigoProducto, TextBox parmCantidadActual, TextBox parmDescripcion, TextBox parmNombre)
        {
            Clases.CConexion conexion = new Clases.CConexion();
            String sql = " Select * from producto where Id='" + Id + "'";
            SqlCommand comando = new SqlCommand(sql, conexion.estableceConexion());
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                parmCodigoProducto.Text = lector["CodigoProducto"].ToString();
                parmNombre.Text = lector["Nombre"].ToString();
                parmCantidadActual.Text = lector["CantidadActual"].ToString();
                parmDescripcion.Text = lector["Descripcion"].ToString();

                parmCodigoProducto.ReadOnly = true;
                parmNombre.ReadOnly = true;
                parmCantidadActual.ReadOnly = true;
                parmDescripcion.ReadOnly = true;

            }
        }


        //---------llena el datagridView con todo los codigos
        public void MostrarDetalleProducto(DataGridView tablaDetalleProducto, object Id)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                tablaDetalleProducto.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("select * from DetalleProducto where IdProducto='" + Id + "'", objectoConexion.estableceConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaDetalleProducto.DataSource = dt;
                objectoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar registros, error = " + ex.ToString());
            }
        }

        //------Insertar registro en Base de Datos
        public void Insertar(Object Id)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();

            try
            {
                string query = "insert into DetalleProducto (fecha, Descripcion, IdTipoTransaccion, Cantidad, IdProducto) values ('','','',''," + Id + ")";
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
            string query = "select top 1 Id from DetalleProducto order by Id desc";
            SqlCommand Comando = new SqlCommand(query, objectoConexion.estableceConexion());
            int Id = Convert.ToInt32(Comando.ExecuteScalar());
            // MessageBox.Show("VALOR:" + Id);
            return Id;
        }

        //----Editar registro en Base de Datos
        public void Editar(object paramId, object paramfecha, object parmDescripcion, object parmTransaccion, object parmCantidad)
        {

            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                string query = "update DetalleProducto set fecha='" + paramfecha + "',Descripcion = '" + parmDescripcion + "',IdTipoTransaccion ='" + parmTransaccion + "', cantidad='" + parmCantidad + "' where id='" + paramId + "'";
                //MessageBox.Show("Query = "+ query);
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                // MessageBox.Show("Se modifico correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los registro, error =" + ex.ToString());
            }
        }

        //---- Eliminar registro en Base de Datos
        public void Eliminar(Object Id)
        {
            Clases.CConexion objectoConexion = new Clases.CConexion();
            try
            {
                string query = "delete from DetalleProducto where id =" + Id;
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


        //------------Combobox
        public DataTable CargaCombobox()
        {
            Clases.CConexion conexion = new Clases.CConexion();
            SqlDataAdapter da = new SqlDataAdapter("sp_getCbxTipoTransaccion", conexion.estableceConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}