namespace ComplejoDeCines.Presentacion
{
    partial class Comprobante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboDescuento = new System.Windows.Forms.ComboBox();
            this.cboFormaCompra = new System.Windows.Forms.ComboBox();
            this.cboCine = new System.Windows.Forms.ComboBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvComprobante = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblFromaCompra = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCine = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblButaca = new System.Windows.Forms.Label();
            this.cboButaca = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(512, 656);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 45);
            this.btnAceptar.TabIndex = 58;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboSala
            // 
            this.cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(738, 194);
            this.cboSala.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(240, 39);
            this.cboSala.TabIndex = 46;
            this.cboSala.SelectionChangeCommitted += new System.EventHandler(this.cboSala_SelectionChangeCommitted);
            // 
            // cboFuncion
            // 
            this.cboFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(738, 145);
            this.cboFuncion.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(240, 39);
            this.cboFuncion.TabIndex = 44;
            this.cboFuncion.SelectionChangeCommitted += new System.EventHandler(this.cboFuncion_SelectionChangeCommitted);
            // 
            // cboPelicula
            // 
            this.cboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(738, 97);
            this.cboPelicula.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(240, 39);
            this.cboPelicula.TabIndex = 42;
            this.cboPelicula.SelectionChangeCommitted += new System.EventHandler(this.cboPelicula_SelectionChangeCommitted);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(348, 242);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 37);
            this.dtpFecha.TabIndex = 38;
            // 
            // cboDescuento
            // 
            this.cboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescuento.FormattingEnabled = true;
            this.cboDescuento.Location = new System.Drawing.Point(348, 340);
            this.cboDescuento.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboDescuento.Name = "cboDescuento";
            this.cboDescuento.Size = new System.Drawing.Size(240, 39);
            this.cboDescuento.TabIndex = 41;
            // 
            // cboFormaCompra
            // 
            this.cboFormaCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaCompra.FormattingEnabled = true;
            this.cboFormaCompra.Location = new System.Drawing.Point(348, 289);
            this.cboFormaCompra.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboFormaCompra.Name = "cboFormaCompra";
            this.cboFormaCompra.Size = new System.Drawing.Size(240, 39);
            this.cboFormaCompra.TabIndex = 40;
            // 
            // cboCine
            // 
            this.cboCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCine.FormattingEnabled = true;
            this.cboCine.Location = new System.Drawing.Point(348, 193);
            this.cboCine.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboCine.Name = "cboCine";
            this.cboCine.Size = new System.Drawing.Size(240, 39);
            this.cboCine.TabIndex = 36;
            this.cboCine.SelectionChangeCommitted += new System.EventHandler(this.cboCine_SelectionChangeCommitted);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(348, 96);
            this.cboVendedor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(240, 39);
            this.cboVendedor.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(550, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 41);
            this.label14.TabIndex = 64;
            this.label14.Text = "Comprobante";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(251, 389);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 45);
            this.btnGuardar.TabIndex = 57;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(858, 656);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 45);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(382, 656);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 45);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(252, 656);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 45);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvComprobante
            // 
            this.dgvComprobante.AllowUserToAddRows = false;
            this.dgvComprobante.AllowUserToDeleteRows = false;
            this.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pelicula,
            this.Funcion,
            this.Sala,
            this.Butaca,
            this.Precio});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprobante.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprobante.Location = new System.Drawing.Point(251, 439);
            this.dgvComprobante.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvComprobante.Name = "dgvComprobante";
            this.dgvComprobante.ReadOnly = true;
            this.dgvComprobante.RowHeadersWidth = 62;
            this.dgvComprobante.RowTemplate.Height = 28;
            this.dgvComprobante.Size = new System.Drawing.Size(727, 204);
            this.dgvComprobante.TabIndex = 63;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // Pelicula
            // 
            this.Pelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.MinimumWidth = 6;
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // Funcion
            // 
            this.Funcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Funcion.HeaderText = "Funcion";
            this.Funcion.MinimumWidth = 6;
            this.Funcion.Name = "Funcion";
            this.Funcion.ReadOnly = true;
            this.Funcion.Width = 130;
            // 
            // Sala
            // 
            this.Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sala.HeaderText = "Sala";
            this.Sala.MinimumWidth = 6;
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            this.Sala.Width = 92;
            // 
            // Butaca
            // 
            this.Butaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Butaca.HeaderText = "Butaca";
            this.Butaca.MinimumWidth = 6;
            this.Butaca.Name = "Butaca";
            this.Butaca.ReadOnly = true;
            this.Butaca.Width = 119;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 113;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(858, 389);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 45);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtxPrecio
            // 
            this.txtxPrecio.Enabled = false;
            this.txtxPrecio.Location = new System.Drawing.Point(738, 293);
            this.txtxPrecio.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtxPrecio.Name = "txtxPrecio";
            this.txtxPrecio.Size = new System.Drawing.Size(240, 37);
            this.txtxPrecio.TabIndex = 50;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.ForeColor = System.Drawing.Color.Khaki;
            this.lblPrecio.Location = new System.Drawing.Point(651, 296);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(82, 31);
            this.lblPrecio.TabIndex = 61;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.Transparent;
            this.lblSala.ForeColor = System.Drawing.Color.Khaki;
            this.lblSala.Location = new System.Drawing.Point(671, 197);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(61, 31);
            this.lblSala.TabIndex = 56;
            this.lblSala.Text = "Sala:";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncion.ForeColor = System.Drawing.Color.Khaki;
            this.lblFuncion.Location = new System.Drawing.Point(636, 149);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(99, 31);
            this.lblFuncion.TabIndex = 54;
            this.lblFuncion.Text = "Funcion:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.ForeColor = System.Drawing.Color.Khaki;
            this.lblPelicula.Location = new System.Drawing.Point(635, 101);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(97, 31);
            this.lblPelicula.TabIndex = 51;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuento.ForeColor = System.Drawing.Color.Khaki;
            this.lblDescuento.Location = new System.Drawing.Point(215, 344);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(127, 31);
            this.lblDescuento.TabIndex = 49;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblFromaCompra
            // 
            this.lblFromaCompra.AutoSize = true;
            this.lblFromaCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblFromaCompra.ForeColor = System.Drawing.Color.Khaki;
            this.lblFromaCompra.Location = new System.Drawing.Point(172, 293);
            this.lblFromaCompra.Name = "lblFromaCompra";
            this.lblFromaCompra.Size = new System.Drawing.Size(170, 31);
            this.lblFromaCompra.TabIndex = 45;
            this.lblFromaCompra.Text = "Forma Compra:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.ForeColor = System.Drawing.Color.Khaki;
            this.lblFecha.Location = new System.Drawing.Point(264, 245);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 31);
            this.lblFecha.TabIndex = 43;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCine
            // 
            this.lblCine.AutoSize = true;
            this.lblCine.BackColor = System.Drawing.Color.Transparent;
            this.lblCine.ForeColor = System.Drawing.Color.Khaki;
            this.lblCine.Location = new System.Drawing.Point(278, 196);
            this.lblCine.Name = "lblCine";
            this.lblCine.Size = new System.Drawing.Size(64, 31);
            this.lblCine.TabIndex = 39;
            this.lblCine.Text = "Cine:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.ForeColor = System.Drawing.Color.Khaki;
            this.lblCliente.Location = new System.Drawing.Point(252, 148);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(90, 31);
            this.lblCliente.TabIndex = 37;
            this.lblCliente.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(224, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Vendedor:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblButaca
            // 
            this.lblButaca.AutoSize = true;
            this.lblButaca.BackColor = System.Drawing.Color.Transparent;
            this.lblButaca.ForeColor = System.Drawing.Color.Khaki;
            this.lblButaca.Location = new System.Drawing.Point(645, 248);
            this.lblButaca.Name = "lblButaca";
            this.lblButaca.Size = new System.Drawing.Size(88, 31);
            this.lblButaca.TabIndex = 62;
            this.lblButaca.Text = "Butaca:";
            // 
            // cboButaca
            // 
            this.cboButaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButaca.FormattingEnabled = true;
            this.cboButaca.Location = new System.Drawing.Point(738, 243);
            this.cboButaca.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboButaca.Name = "cboButaca";
            this.cboButaca.Size = new System.Drawing.Size(240, 39);
            this.cboButaca.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(472, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(362, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 159;
            this.pictureBox2.TabStop = false;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(348, 144);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(240, 39);
            this.cboCliente.TabIndex = 160;
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComplejoDeCines.Properties.Resources.fondo_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboButaca);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.cboFuncion);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboDescuento);
            this.Controls.Add(this.cboFormaCompra);
            this.Controls.Add(this.cboCine);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvComprobante);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblButaca);
            this.Controls.Add(this.txtxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblFromaCompra);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCine);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Comprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante";
            this.Load += new System.EventHandler(this.Comprobante1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAceptar;
        private ComboBox cboSala;
        private ComboBox cboFuncion;
        private ComboBox cboPelicula;
        private DateTimePicker dtpFecha;
        private ComboBox cboDescuento;
        private ComboBox cboFormaCompra;
        private ComboBox cboCine;
        private ComboBox cboVendedor;
        private Label label14;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvComprobante;
        private Button btnAgregar;
        private TextBox txtxPrecio;
        private Label lblPrecio;
        private Label lblSala;
        private Label lblFuncion;
        private Label lblPelicula;
        private Label lblDescuento;
        private Label lblFromaCompra;
        private Label lblFecha;
        private Label lblCine;
        private Label lblCliente;
        private Label label1;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox cboButaca;
        private Label lblButaca;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Pelicula;
        private DataGridViewTextBoxColumn Funcion;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Butaca;
        private DataGridViewTextBoxColumn Precio;
        private ComboBox cboCliente;
    }
}