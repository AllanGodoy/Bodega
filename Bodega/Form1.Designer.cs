namespace Bodega
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducto = new DataGridView();
            label1 = new Label();
            txtCodigo = new TextBox();
            btnBuscarCodigo = new Button();
            btnBuscarNombre = new Button();
            txtNombre = new TextBox();
            btnTransaccion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(2, 142);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.Size = new Size(895, 305);
            dgvProducto.TabIndex = 0;
            dgvProducto.CellBeginEdit += dgvProducto_CellBeginEdit;
            dgvProducto.CellEndEdit += dgvProducto_CellEndEdit;
            dgvProducto.DataError += dgvProducto_DataError;
            dgvProducto.UserDeletingRow += dgvProducto_UserDeletingRow;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(225, 23);
            txtCodigo.TabIndex = 2;
            // 
            // btnBuscarCodigo
            // 
            btnBuscarCodigo.Location = new Point(243, 67);
            btnBuscarCodigo.Name = "btnBuscarCodigo";
            btnBuscarCodigo.Size = new Size(140, 23);
            btnBuscarCodigo.TabIndex = 3;
            btnBuscarCodigo.Text = "Buscar por codigo";
            btnBuscarCodigo.UseVisualStyleBackColor = true;
            btnBuscarCodigo.Click += btnBuscarCodigo_Click;
            // 
            // btnBuscarNombre
            // 
            btnBuscarNombre.Location = new Point(243, 107);
            btnBuscarNombre.Name = "btnBuscarNombre";
            btnBuscarNombre.Size = new Size(140, 23);
            btnBuscarNombre.TabIndex = 4;
            btnBuscarNombre.Text = "Buscar por Nombre";
            btnBuscarNombre.UseVisualStyleBackColor = true;
            btnBuscarNombre.Click += btnBuscarNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 5;
            // 
            // btnTransaccion
            // 
            btnTransaccion.Location = new Point(653, 84);
            btnTransaccion.Name = "btnTransaccion";
            btnTransaccion.Size = new Size(113, 46);
            btnTransaccion.TabIndex = 6;
            btnTransaccion.Text = "Agregar Transaccion";
            btnTransaccion.UseVisualStyleBackColor = true;
            btnTransaccion.Click += btnTransaccion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(btnTransaccion);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscarNombre);
            Controls.Add(btnBuscarCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(dgvProducto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducto;
        private Label label1;
        private TextBox textBox1;
        private Button btnBuscarCodigo;
        private Button btnBuscarNombre;
        private TextBox textBox2;
        private Button btnTransaccion;
        private TextBox txtCodigo;
        private TextBox txtNombre;
    }
}