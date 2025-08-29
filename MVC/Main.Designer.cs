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
            lblEditorial = new Label();
            lblAnio = new Label();
            tbNombre = new TextBox();
            tbEditorial = new TextBox();
            tbPrecio = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvLibros = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
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
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(50, 140);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(80, 25);
            lblEditorial.TabIndex = 3;
            lblEditorial.Text = "Editorial:";
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
            // tbNombre
            // 
            tbNombre.Location = new Point(212, 90);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(250, 31);
            tbNombre.TabIndex = 2;
            // 
            // tbEditorial
            // 
            tbEditorial.Location = new Point(212, 140);
            tbEditorial.Name = "tbEditorial";
            tbEditorial.Size = new Size(250, 31);
            tbEditorial.TabIndex = 4;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(212, 184);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(250, 31);
            tbPrecio.TabIndex = 6;
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
            btnAgregar.Click += btnAgregar_Click;
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
            btnActualizar.Click += btnActualizar_Click;
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
            btnEliminar.Click += btnEliminar_Click;
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
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeight = 34;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { ID, Editorial, Precio });
            dgvLibros.Location = new Point(50, 300);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(700, 200);
            dgvLibros.TabIndex = 11;
            dgvLibros.CellContentClick += dgvLibros_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "Nombre";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.MinimumWidth = 8;
            Editorial.Name = "Editorial";
            Editorial.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(tbNombre);
            Controls.Add(lblEditorial);
            Controls.Add(tbEditorial);
            Controls.Add(lblAnio);
            Controls.Add(tbPrecio);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvLibros);
            Name = "Main";
            Text = "CRUD Biblioteca";
            Load += Main_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEditorial;
        private Label lblAnio;
        private TextBox tbNombre;
        private TextBox tbEditorial;
        private TextBox tbPrecio;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn Precio;
    }
}
