namespace Reto2RutaTesoro;

partial class FrmRutaTesoro
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
        this.grpDatos = new System.Windows.Forms.GroupBox();
        this.nudPeligro = new System.Windows.Forms.NumericUpDown();
        this.lblPeligro = new System.Windows.Forms.Label();
        this.txtPista = new System.Windows.Forms.TextBox();
        this.lblPista = new System.Windows.Forms.Label();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.lblNombre = new System.Windows.Forms.Label();
        this.nudId = new System.Windows.Forms.NumericUpDown();
        this.lblId = new System.Windows.Forms.Label();
        this.grpAcciones = new System.Windows.Forms.GroupBox();
        this.btnVaciar = new System.Windows.Forms.Button();
        this.btnRecorrer = new System.Windows.Forms.Button();
        this.btnCargarEjemplo = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.btnEliminar = new System.Windows.Forms.Button();
        this.btnModificar = new System.Windows.Forms.Button();
        this.btnBuscar = new System.Windows.Forms.Button();
        this.btnInsertarInicio = new System.Windows.Forms.Button();
        this.btnInsertarFinal = new System.Windows.Forms.Button();
        this.grpVisualizacion = new System.Windows.Forms.GroupBox();
        this.dgvRuta = new System.Windows.Forms.DataGridView();
        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPeligro = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPista = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSiguiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pnlInferior = new System.Windows.Forms.Panel();
        this.txtEsquema = new System.Windows.Forms.TextBox();
        this.lblEsquema = new System.Windows.Forms.Label();
        this.lblTotalNodos = new System.Windows.Forms.Label();
        this.pnlSuperior = new System.Windows.Forms.Panel();
        this.picMapa = new System.Windows.Forms.PictureBox();
        this.lblSubtitulo = new System.Windows.Forms.Label();
        this.lblTitulo = new System.Windows.Forms.Label();

        this.grpDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudPeligro)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
        this.grpAcciones.SuspendLayout();
        this.grpVisualizacion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRuta)).BeginInit();
        this.pnlInferior.SuspendLayout();
        this.pnlSuperior.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picMapa)).BeginInit();
        this.SuspendLayout();

        // 
        // pnlSuperior
        // 
        this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlSuperior.Controls.Add(this.picMapa);
        this.pnlSuperior.Controls.Add(this.lblSubtitulo);
        this.pnlSuperior.Controls.Add(this.lblTitulo);
        this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
        this.pnlSuperior.Name = "pnlSuperior";
        this.pnlSuperior.Size = new System.Drawing.Size(984, 60);
        this.pnlSuperior.TabIndex = 0;

        // 
        // picMapa
        // 
        this.picMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picMapa.Location = new System.Drawing.Point(12, 8);
        this.picMapa.Name = "picMapa";
        this.picMapa.Size = new System.Drawing.Size(44, 44);
        this.picMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        this.picMapa.TabIndex = 2;
        this.picMapa.TabStop = false;

        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitulo.Location = new System.Drawing.Point(64, 10);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(325, 21);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Reto 2 - La Ruta del Tesoro Perdido";

        // 
        // lblSubtitulo
        // 
        this.lblSubtitulo.AutoSize = true;
        this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblSubtitulo.Location = new System.Drawing.Point(65, 33);
        this.lblSubtitulo.Name = "lblSubtitulo";
        this.lblSubtitulo.Size = new System.Drawing.Size(258, 15);
        this.lblSubtitulo.TabIndex = 1;
        this.lblSubtitulo.Text = "Listas simplemente enlazadas creadas desde cero";

        // 
        // grpDatos
        // 
        this.grpDatos.Controls.Add(this.nudPeligro);
        this.grpDatos.Controls.Add(this.lblPeligro);
        this.grpDatos.Controls.Add(this.txtPista);
        this.grpDatos.Controls.Add(this.lblPista);
        this.grpDatos.Controls.Add(this.txtNombre);
        this.grpDatos.Controls.Add(this.lblNombre);
        this.grpDatos.Controls.Add(this.nudId);
        this.grpDatos.Controls.Add(this.lblId);
        this.grpDatos.Location = new System.Drawing.Point(12, 70);
        this.grpDatos.Name = "grpDatos";
        this.grpDatos.Size = new System.Drawing.Size(320, 240);
        this.grpDatos.TabIndex = 1;
        this.grpDatos.TabStop = false;
        this.grpDatos.Text = "Datos de ubicación";

        // 
        // lblId
        // 
        this.lblId.AutoSize = true;
        this.lblId.Location = new System.Drawing.Point(15, 25);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(87, 15);
        this.lblId.TabIndex = 0;
        this.lblId.Text = "ID de ubicación:";

        // 
        // nudId
        // 
        this.nudId.Location = new System.Drawing.Point(18, 43);
        this.nudId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        this.nudId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudId.Name = "nudId";
        this.nudId.Size = new System.Drawing.Size(120, 23);
        this.nudId.TabIndex = 1;
        this.nudId.Value = new decimal(new int[] { 1, 0, 0, 0 });

        // 
        // lblNombre
        // 
        this.lblNombre.AutoSize = true;
        this.lblNombre.Location = new System.Drawing.Point(15, 75);
        this.lblNombre.Name = "lblNombre";
        this.lblNombre.Size = new System.Drawing.Size(54, 15);
        this.lblNombre.TabIndex = 2;
        this.lblNombre.Text = "Nombre:";

        // 
        // txtNombre
        // 
        this.txtNombre.Location = new System.Drawing.Point(18, 93);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(280, 23);
        this.txtNombre.TabIndex = 3;

        // 
        // lblPista
        // 
        this.lblPista.AutoSize = true;
        this.lblPista.Location = new System.Drawing.Point(15, 125);
        this.lblPista.Name = "lblPista";
        this.lblPista.Size = new System.Drawing.Size(35, 15);
        this.lblPista.TabIndex = 4;
        this.lblPista.Text = "Pista:";

        // 
        // txtPista
        // 
        this.txtPista.Location = new System.Drawing.Point(18, 143);
        this.txtPista.Multiline = true;
        this.txtPista.Name = "txtPista";
        this.txtPista.Size = new System.Drawing.Size(280, 40);
        this.txtPista.TabIndex = 5;

        // 
        // lblPeligro
        // 
        this.lblPeligro.AutoSize = true;
        this.lblPeligro.Location = new System.Drawing.Point(15, 192);
        this.lblPeligro.Name = "lblPeligro";
        this.lblPeligro.Size = new System.Drawing.Size(123, 15);
        this.lblPeligro.TabIndex = 6;
        this.lblPeligro.Text = "Nivel de peligro (1-10):";

        // 
        // nudPeligro
        // 
        this.nudPeligro.Location = new System.Drawing.Point(150, 190);
        this.nudPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        this.nudPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudPeligro.Name = "nudPeligro";
        this.nudPeligro.Size = new System.Drawing.Size(60, 23);
        this.nudPeligro.TabIndex = 7;
        this.nudPeligro.Value = new decimal(new int[] { 5, 0, 0, 0 });

        // 
        // grpAcciones
        // 
        this.grpAcciones.Controls.Add(this.btnVaciar);
        this.grpAcciones.Controls.Add(this.btnRecorrer);
        this.grpAcciones.Controls.Add(this.btnCargarEjemplo);
        this.grpAcciones.Controls.Add(this.btnLimpiar);
        this.grpAcciones.Controls.Add(this.btnEliminar);
        this.grpAcciones.Controls.Add(this.btnModificar);
        this.grpAcciones.Controls.Add(this.btnBuscar);
        this.grpAcciones.Controls.Add(this.btnInsertarInicio);
        this.grpAcciones.Controls.Add(this.btnInsertarFinal);
        this.grpAcciones.Location = new System.Drawing.Point(12, 320);
        this.grpAcciones.Name = "grpAcciones";
        this.grpAcciones.Size = new System.Drawing.Size(320, 275);
        this.grpAcciones.TabIndex = 2;
        this.grpAcciones.TabStop = false;
        this.grpAcciones.Text = "Operaciones de la lista";

        // 
        // btnInsertarFinal
        // 
        this.btnInsertarFinal.Location = new System.Drawing.Point(18, 25);
        this.btnInsertarFinal.Name = "btnInsertarFinal";
        this.btnInsertarFinal.Size = new System.Drawing.Size(130, 30);
        this.btnInsertarFinal.TabIndex = 0;
        this.btnInsertarFinal.Text = "Insertar al final";
        this.btnInsertarFinal.UseVisualStyleBackColor = true;
        this.btnInsertarFinal.Click += new System.EventHandler(this.btnInsertarFinal_Click);

        // 
        // btnInsertarInicio
        // 
        this.btnInsertarInicio.Location = new System.Drawing.Point(168, 25);
        this.btnInsertarInicio.Name = "btnInsertarInicio";
        this.btnInsertarInicio.Size = new System.Drawing.Size(130, 30);
        this.btnInsertarInicio.TabIndex = 1;
        this.btnInsertarInicio.Text = "Insertar al inicio";
        this.btnInsertarInicio.UseVisualStyleBackColor = true;
        this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click);

        // 
        // btnBuscar
        // 
        this.btnBuscar.Location = new System.Drawing.Point(18, 65);
        this.btnBuscar.Name = "btnBuscar";
        this.btnBuscar.Size = new System.Drawing.Size(130, 30);
        this.btnBuscar.TabIndex = 2;
        this.btnBuscar.Text = "Buscar por ID";
        this.btnBuscar.UseVisualStyleBackColor = true;
        this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

        // 
        // btnModificar
        // 
        this.btnModificar.Location = new System.Drawing.Point(168, 65);
        this.btnModificar.Name = "btnModificar";
        this.btnModificar.Size = new System.Drawing.Size(130, 30);
        this.btnModificar.TabIndex = 3;
        this.btnModificar.Text = "Modificar";
        this.btnModificar.UseVisualStyleBackColor = true;
        this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);

        // 
        // btnEliminar
        // 
        this.btnEliminar.Location = new System.Drawing.Point(18, 105);
        this.btnEliminar.Name = "btnEliminar";
        this.btnEliminar.Size = new System.Drawing.Size(130, 30);
        this.btnEliminar.TabIndex = 4;
        this.btnEliminar.Text = "Eliminar";
        this.btnEliminar.UseVisualStyleBackColor = true;
        this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

        // 
        // btnLimpiar
        // 
        this.btnLimpiar.Location = new System.Drawing.Point(168, 105);
        this.btnLimpiar.Name = "btnLimpiar";
        this.btnLimpiar.Size = new System.Drawing.Size(130, 30);
        this.btnLimpiar.TabIndex = 5;
        this.btnLimpiar.Text = "Limpiar campos";
        this.btnLimpiar.UseVisualStyleBackColor = true;
        this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

        // 
        // btnCargarEjemplo
        // 
        this.btnCargarEjemplo.Location = new System.Drawing.Point(18, 145);
        this.btnCargarEjemplo.Name = "btnCargarEjemplo";
        this.btnCargarEjemplo.Size = new System.Drawing.Size(280, 30);
        this.btnCargarEjemplo.TabIndex = 6;
        this.btnCargarEjemplo.Text = "Cargar datos de ejemplo";
        this.btnCargarEjemplo.UseVisualStyleBackColor = true;
        this.btnCargarEjemplo.Click += new System.EventHandler(this.btnCargarEjemplo_Click);

        // 
        // btnRecorrer
        // 
        this.btnRecorrer.Location = new System.Drawing.Point(18, 185);
        this.btnRecorrer.Name = "btnRecorrer";
        this.btnRecorrer.Size = new System.Drawing.Size(280, 30);
        this.btnRecorrer.TabIndex = 7;
        this.btnRecorrer.Text = "Recorrer ruta";
        this.btnRecorrer.UseVisualStyleBackColor = true;
        this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);

        // 
        // btnVaciar
        // 
        this.btnVaciar.Location = new System.Drawing.Point(18, 225);
        this.btnVaciar.Name = "btnVaciar";
        this.btnVaciar.Size = new System.Drawing.Size(280, 30);
        this.btnVaciar.TabIndex = 8;
        this.btnVaciar.Text = "Vaciar lista";
        this.btnVaciar.UseVisualStyleBackColor = true;
        this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);

        // 
        // grpVisualizacion
        // 
        this.grpVisualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.grpVisualizacion.Controls.Add(this.dgvRuta);
        this.grpVisualizacion.Location = new System.Drawing.Point(345, 70);
        this.grpVisualizacion.Name = "grpVisualizacion";
        this.grpVisualizacion.Size = new System.Drawing.Size(627, 430);
        this.grpVisualizacion.TabIndex = 3;
        this.grpVisualizacion.TabStop = false;
        this.grpVisualizacion.Text = "Visualización de la lista enlazada (DataGridView solo para lectura)";

        // 
        // dgvRuta
        // 
        this.dgvRuta.AllowUserToAddRows = false;
        this.dgvRuta.AllowUserToDeleteRows = false;
        this.dgvRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvRuta.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colPeligro,
            this.colPista,
            this.colSiguiente});
        this.dgvRuta.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvRuta.Location = new System.Drawing.Point(3, 19);
        this.dgvRuta.MultiSelect = false;
        this.dgvRuta.Name = "dgvRuta";
        this.dgvRuta.ReadOnly = true;
        this.dgvRuta.RowHeadersVisible = false;
        this.dgvRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvRuta.Size = new System.Drawing.Size(621, 408);
        this.dgvRuta.TabIndex = 0;
        this.dgvRuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuta_CellClick);

        // 
        // colId
        // 
        this.colId.FillWeight = 40F;
        this.colId.HeaderText = "ID";
        this.colId.Name = "colId";
        this.colId.ReadOnly = true;

        // 
        // colNombre
        // 
        this.colNombre.FillWeight = 110F;
        this.colNombre.HeaderText = "Ubicación";
        this.colNombre.Name = "colNombre";
        this.colNombre.ReadOnly = true;

        // 
        // colPeligro
        // 
        this.colPeligro.FillWeight = 50F;
        this.colPeligro.HeaderText = "Peligro";
        this.colPeligro.Name = "colPeligro";
        this.colPeligro.ReadOnly = true;

        // 
        // colPista
        // 
        this.colPista.FillWeight = 130F;
        this.colPista.HeaderText = "Pista";
        this.colPista.Name = "colPista";
        this.colPista.ReadOnly = true;

        // 
        // colSiguiente
        // 
        this.colSiguiente.FillWeight = 80F;
        this.colSiguiente.HeaderText = "Siguiente";
        this.colSiguiente.Name = "colSiguiente";
        this.colSiguiente.ReadOnly = true;

        // 
        // pnlInferior
        // 
        this.pnlInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.pnlInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlInferior.Controls.Add(this.txtEsquema);
        this.pnlInferior.Controls.Add(this.lblEsquema);
        this.pnlInferior.Controls.Add(this.lblTotalNodos);
        this.pnlInferior.Location = new System.Drawing.Point(345, 510);
        this.pnlInferior.Name = "pnlInferior";
        this.pnlInferior.Size = new System.Drawing.Size(627, 85);
        this.pnlInferior.TabIndex = 4;

        // 
        // lblTotalNodos
        // 
        this.lblTotalNodos.AutoSize = true;
        this.lblTotalNodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTotalNodos.Location = new System.Drawing.Point(8, 8);
        this.lblTotalNodos.Name = "lblTotalNodos";
        this.lblTotalNodos.Size = new System.Drawing.Size(89, 15);
        this.lblTotalNodos.TabIndex = 0;
        this.lblTotalNodos.Text = "Total nodos: 0";

        // 
        // lblEsquema
        // 
        this.lblEsquema.AutoSize = true;
        this.lblEsquema.Location = new System.Drawing.Point(8, 28);
        this.lblEsquema.Name = "lblEsquema";
        this.lblEsquema.Size = new System.Drawing.Size(161, 15);
        this.lblEsquema.TabIndex = 1;
        this.lblEsquema.Text = "Representación de la lista:";

        // 
        // txtEsquema
        // 
        this.txtEsquema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtEsquema.Location = new System.Drawing.Point(8, 48);
        this.txtEsquema.Name = "txtEsquema";
        this.txtEsquema.ReadOnly = true;
        this.txtEsquema.Size = new System.Drawing.Size(608, 23);
        this.txtEsquema.TabIndex = 2;
        this.txtEsquema.Text = "Inicio -> NULL";

        // 
        // FrmRutaTesoro
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(984, 611);
        this.Controls.Add(this.pnlInferior);
        this.Controls.Add(this.grpVisualizacion);
        this.Controls.Add(this.grpAcciones);
        this.Controls.Add(this.grpDatos);
        this.Controls.Add(this.pnlSuperior);
        this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.MinimumSize = new System.Drawing.Size(850, 550);
        this.Name = "FrmRutaTesoro";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Reto 2 - La Ruta del Tesoro Perdido";
        this.grpDatos.ResumeLayout(false);
        this.grpDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudPeligro)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
        this.grpAcciones.ResumeLayout(false);
        this.grpVisualizacion.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvRuta)).EndInit();
        this.pnlInferior.ResumeLayout(false);
        this.pnlInferior.PerformLayout();
        this.pnlSuperior.ResumeLayout(false);
        this.pnlSuperior.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picMapa)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlSuperior;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSubtitulo;
    private System.Windows.Forms.PictureBox picMapa;
    private System.Windows.Forms.GroupBox grpDatos;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.NumericUpDown nudId;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblPista;
    private System.Windows.Forms.TextBox txtPista;
    private System.Windows.Forms.Label lblPeligro;
    private System.Windows.Forms.NumericUpDown nudPeligro;
    private System.Windows.Forms.GroupBox grpAcciones;
    private System.Windows.Forms.Button btnInsertarFinal;
    private System.Windows.Forms.Button btnInsertarInicio;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnCargarEjemplo;
    private System.Windows.Forms.Button btnRecorrer;
    private System.Windows.Forms.Button btnVaciar;
    private System.Windows.Forms.GroupBox grpVisualizacion;
    private System.Windows.Forms.DataGridView dgvRuta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPeligro;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPista;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSiguiente;
    private System.Windows.Forms.Panel pnlInferior;
    private System.Windows.Forms.Label lblTotalNodos;
    private System.Windows.Forms.Label lblEsquema;
    private System.Windows.Forms.TextBox txtEsquema;
}
