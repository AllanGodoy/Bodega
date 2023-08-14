using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class Detalle : Form
    {
        public object ProductoId = 0;
        public Detalle(object Id)
        {
            InitializeComponent();

            Form1 productoForm = new Form1();
            Clases.DetalleProducto objetoDetalleProducto = new Clases.DetalleProducto();
            objetoDetalleProducto.MostrarDetalleProducto(dgvDetalleProducto, Id);

            objetoDetalleProducto.mostrarProducto(Id, txtCodigoProducto, txtCantidadActual, txtDescripcion, txtNombre);
            formatosCelda();
            ProductoId = Id;
        }

        private void formatosCelda()
        {

            dgvDetalleProducto.Columns[5].Visible = false;
                       
        }
    


        //--- combobox 
        private void Detalle_Load(object sender, EventArgs e)
        {
            Clases.DetalleProducto objetoDetalleProducto = new Clases.DetalleProducto();
            cboTipoTransaccion.DataSource = objetoDetalleProducto.CargaCombobox();
            cboTipoTransaccion.DisplayMember = "Nombre";
            cboTipoTransaccion.ValueMember = "Id";


            
            //var combobox = (DataGridViewComboBoxColumn)dgvDetalleProducto.Columns["TipoTransaccion"];
            //combobox.DataSource = objetoDetalleProducto.CargaCombobox();
            //combobox.DisplayMember = "Nombre";
            //combobox.ValueMember = "Id";
            //dgvDetalleProducto.DataSource = combobox;

        }


        //------------Error en el DatagridView
        private void dgvDetalleProducto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Registro ingresado es invalido ");
        }

        private void dgvDetalleProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            Clases.DetalleProducto objetoDetalleProducto = new Clases.DetalleProducto();
            var parmId = dgvDetalleProducto.CurrentRow.Cells[0].Value;
            var parmFecha = dgvDetalleProducto.CurrentRow.Cells[1].Value;
            var parmDescripcion = dgvDetalleProducto.CurrentRow.Cells[2].Value;
            var parmTipoTransaccion = dgvDetalleProducto.CurrentRow.Cells[3].Value;
            var parmCantidad = dgvDetalleProducto.CurrentRow.Cells[4].Value;


            objetoDetalleProducto.Editar(parmId, parmFecha, parmDescripcion, parmTipoTransaccion, parmCantidad);

        }

        private void dgvDetalleProducto_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            if (dgvDetalleProducto.CurrentRow.Cells[0].Value.ToString() == "")
            {

                Clases.DetalleProducto objetoDetalleProducto = new Clases.DetalleProducto();
                objetoDetalleProducto.Insertar("" + ProductoId);

                int IdValor = objetoDetalleProducto.InsertarCodigoGridView();
                int tamanioDatagridview = dgvDetalleProducto.ColumnCount;
                dgvDetalleProducto.CurrentRow.Cells[0].Value = IdValor;
                dgvDetalleProducto.CurrentRow.Cells[5].Value = ProductoId;
                dgvDetalleProducto.CurrentRow.Cells[1].Value = DateTime.Now.ToString("MM-dd-yyyy");
            }
        }

        private void dgvDetalleProducto_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var numero = dgvDetalleProducto.CurrentRow.Cells[0].Value;
            Clases.DetalleProducto objetoDetalleProducto = new Clases.DetalleProducto();

            if (MessageBox.Show("Desea eliminar el registro numero:" + numero, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objetoDetalleProducto.Eliminar(numero);
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
    }
}
