namespace Solucion___Practica
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
            label1 = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            dgvDetalles = new DataGridView();
            colMaterial = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            cboMateriales = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtResponsable = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Responsable:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(94, 18);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(362, 23);
            dtpFecha.TabIndex = 2;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colMaterial, colStock, colCantidad, colAcciones });
            dgvDetalles.Location = new Point(13, 138);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(443, 157);
            dgvDetalles.TabIndex = 3;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colMaterial
            // 
            colMaterial.HeaderText = "MATERIAL";
            colMaterial.Name = "colMaterial";
            // 
            // colStock
            // 
            colStock.HeaderText = "STOCK";
            colStock.Name = "colStock";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "CANTIDAD";
            colCantidad.Name = "colCantidad";
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.Name = "colAcciones";
            colAcciones.Text = "Quitar";
            colAcciones.UseColumnTextForButtonValue = true;
            // 
            // cboMateriales
            // 
            cboMateriales.FormattingEnabled = true;
            cboMateriales.Location = new Point(13, 98);
            cboMateriales.Name = "cboMateriales";
            cboMateriales.Size = new Size(236, 23);
            cboMateriales.TabIndex = 4;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(255, 98);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(381, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(156, 312);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(237, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(94, 58);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(362, 23);
            txtResponsable.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 352);
            Controls.Add(txtResponsable);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(cboMateriales);
            Controls.Add(dgvDetalles);
            Controls.Add(dtpFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpFecha;
        private DataGridView dgvDetalles;
        private ComboBox cboMateriales;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtResponsable;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAcciones;
    }
}