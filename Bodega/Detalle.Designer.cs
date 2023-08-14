namespace Bodega
{
    partial class Detalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDetalleProducto = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigoProducto = new TextBox();
            txtDescripcion = new TextBox();
            txtCantidadActual = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleProducto).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalleProducto
            // 
            dgvDetalleProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleProducto.Location = new Point(22, 149);
            dgvDetalleProducto.Name = "dgvDetalleProducto";
            dgvDetalleProducto.RowTemplate.Height = 25;
            dgvDetalleProducto.Size = new Size(766, 289);
            dgvDetalleProducto.TabIndex = 0;
            dgvDetalleProducto.CellBeginEdit += dgvDetalleProducto_CellBeginEdit;
            dgvDetalleProducto.CellEndEdit += dgvDetalleProducto_CellEndEdit;
            dgvDetalleProducto.DataError += dgvDetalleProducto_DataError;
            dgvDetalleProducto.UserDeletingRow += dgvDetalleProducto_UserDeletingRow;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 102);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 105);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad Actual";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(161, 58);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(161, 23);
            txtCodigoProducto.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(564, 99);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(160, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // txtCantidadActual
            // 
            txtCantidadActual.Location = new Point(161, 102);
            txtCantidadActual.Name = "txtCantidadActual";
            txtCantidadActual.Size = new Size(159, 23);
            txtCantidadActual.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(289, 9);
            label4.Name = "label4";
            label4.Size = new Size(232, 32);
            label4.TabIndex = 7;
            label4.Text = "Detalle del Producto";
            // 
            // txtNombre
            // 
            txtNombre.AcceptsReturn = true;
            txtNombre.Location = new Point(564, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 64);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre";
            // 
            // Detalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtCantidadActual);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetalleProducto);
            Name = "Detalle";
            Text = "Detalle";
            Load += Detalle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalleProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox txtCodigoProducto;
        private TextBox txtDescripcion;
        private TextBox txtCantidadActual;
        private Label label5;
    }
}