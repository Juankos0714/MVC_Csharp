namespace MVC
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblAutor = new Label();
            lblAnio = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvLibros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(280, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CRUD Biblioteca";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(156, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del Libro:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(50, 140);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(61, 25);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(50, 190);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(64, 25);
            lblAnio.TabIndex = 5;
            lblAnio.Text = "Precio:";
            lblAnio.Click += lblAnio_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(212, 140);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(250, 31);
            txtAutor.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(212, 184);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(250, 31);
            txtAnio.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightGreen;
            btnAgregar.Location = new Point(500, 90);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightBlue;
            btnActualizar.Location = new Point(500, 140);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(500, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Location = new Point(500, 240);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 40);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeight = 34;
            dgvLibros.Location = new Point(50, 300);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(700, 200);
            dgvLibros.TabIndex = 11;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblAutor);
            Controls.Add(txtAutor);
            Controls.Add(lblAnio);
            Controls.Add(txtAnio);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvLibros);
            Name = "Main";
            Text = "CRUD Biblioteca";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblAutor;
        private Label lblAnio;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvLibros;
    }
}
