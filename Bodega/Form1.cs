using System.Collections;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Bodega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Clases.CConexion conexion = new Clases.CConexion();
            //conexion.estableceConexion();
            Clases.Producto objetoProducto = new Clases.Producto();
            objetoProducto.MostrarProducto(dgvProducto);

            formatosCelda();
        }

        private void formatosCelda()
        {
            dgvProducto.Columns[0].ReadOnly = true;
            //dgvProducto.Columns[0].Visible = false;

            dgvProducto.Columns[6].ReadOnly = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //----DataGridView - Iniciando al editar Celda
        private void dgvProducto_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvProducto.CurrentRow.Cells[0].Value.ToString() == "")
            {

                Clases.Producto objetoProducto = new Clases.Producto();
                objetoProducto.Insertar();

                int IdValor = objetoProducto.InsertarCodigoGridView();
                int tamanioDatagridview = dgvProducto.ColumnCount;
                dgvProducto.CurrentRow.Cells[0].Value = IdValor;

                dgvProducto.CurrentRow.Cells[1].Value = DateTime.Now.ToString("MM-dd-yyyy");
            }
        }


        //----DataGridView - Borrando Celda
        private void dgvProducto_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var numero = dgvProducto.CurrentRow.Cells[0].Value;
            Clases.Producto objetoProducto = new Clases.Producto();

            if (MessageBox.Show("Desea eliminar el registro numero:" + numero, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objetoProducto.Eliminar(numero);
                    MessageBox.Show("Se elimino correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se logro eliminar los registros, error =" + ex.ToString());
                }
            }

            else
            {

                e.Cancel = true;
            }
        }
        //----DataGridView - terminando de editar celda
        private void dgvProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Producto objetoProducto = new Clases.Producto();
            var parmId = dgvProducto.CurrentRow.Cells[0].Value;
            var parmFecha = dgvProducto.CurrentRow.Cells[1].Value;
            var parmCodigoProducto = dgvProducto.CurrentRow.Cells[2].Value;
            var parmNombre = dgvProducto.CurrentRow.Cells[3].Value;
            var parmDescripcion = dgvProducto.CurrentRow.Cells[4].Value;
            var parmInventarioInicial = dgvProducto.CurrentRow.Cells[5].Value;
            var parmCantidadActual = dgvProducto.CurrentRow.Cells[6].Value;
            var parmEstatus = dgvProducto.CurrentRow.Cells[7].Value;

            objetoProducto.Editar(parmId, parmFecha, parmCodigoProducto, parmNombre, parmDescripcion,
                            parmInventarioInicial, parmCantidadActual, parmEstatus);
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            Clases.Producto objetoPorducto = new Clases.Producto();
            objetoPorducto.BuscarCodigo(dgvProducto, txtCodigo);
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            Clases.Producto objetoPorducto = new Clases.Producto();
            objetoPorducto.BuscarNombre(dgvProducto, txtNombre);
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            Detalle form = new Detalle(dgvProducto.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void dgvProducto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Registro ingresado es invalido ");
        }

        public object GetId() {

            return dgvProducto.CurrentRow.Cells[0].Value;
        }
    }
}