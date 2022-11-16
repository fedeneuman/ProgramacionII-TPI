namespace ComplejoDeCines.Presentacion
{
    partial class CargaVarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaVarios));
            this.txtSubtitulo4 = new System.Windows.Forms.TextBox();
            this.lblSubtitulo4 = new System.Windows.Forms.Label();
            this.txtSubtitulo3 = new System.Windows.Forms.TextBox();
            this.dtpFuncion = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCargarVarios = new System.Windows.Forms.DataGridView();
            this.UsuarioDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JerarquiaDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtSubtitulo1 = new System.Windows.Forms.TextBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblSubtitulo3 = new System.Windows.Forms.Label();
            this.cboSubtitulo2 = new System.Windows.Forms.ComboBox();
            this.lblSubtitulo2 = new System.Windows.Forms.Label();
            this.lblSubtitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarVarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubtitulo4
            // 
            this.txtSubtitulo4.Location = new System.Drawing.Point(286, 255);
            this.txtSubtitulo4.Name = "txtSubtitulo4";
            this.txtSubtitulo4.Size = new System.Drawing.Size(191, 37);
            this.txtSubtitulo4.TabIndex = 34;
            // 
            // lblSubtitulo4
            // 
            this.lblSubtitulo4.AutoSize = true;
            this.lblSubtitulo4.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo4.ForeColor = System.Drawing.Color.Khaki;
            this.lblSubtitulo4.Location = new System.Drawing.Point(286, 221);
            this.lblSubtitulo4.Name = "lblSubtitulo4";
            this.lblSubtitulo4.Size = new System.Drawing.Size(117, 31);
            this.lblSubtitulo4.TabIndex = 45;
            this.lblSubtitulo4.Text = "subtitulo4";
            // 
            // txtSubtitulo3
            // 
            this.txtSubtitulo3.Location = new System.Drawing.Point(11, 171);
            this.txtSubtitulo3.Name = "txtSubtitulo3";
            this.txtSubtitulo3.Size = new System.Drawing.Size(109, 37);
            this.txtSubtitulo3.TabIndex = 32;
            // 
            // dtpFuncion
            // 
            this.dtpFuncion.Location = new System.Drawing.Point(12, 27);
            this.dtpFuncion.Name = "dtpFuncion";
            this.dtpFuncion.Size = new System.Drawing.Size(246, 37);
            this.dtpFuncion.TabIndex = 33;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(863, 395);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 45);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(863, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 45);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCargarVarios
            // 
            this.dgvCargarVarios.AllowUserToAddRows = false;
            this.dgvCargarVarios.AllowUserToDeleteRows = false;
            this.dgvCargarVarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargarVarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioDGV,
            this.PassDGV,
            this.JerarquiaDGV});
            this.dgvCargarVarios.Location = new System.Drawing.Point(286, 395);
            this.dgvCargarVarios.Name = "dgvCargarVarios";
            this.dgvCargarVarios.ReadOnly = true;
            this.dgvCargarVarios.RowHeadersWidth = 62;
            this.dgvCargarVarios.RowTemplate.Height = 28;
            this.dgvCargarVarios.Size = new System.Drawing.Size(558, 259);
            this.dgvCargarVarios.TabIndex = 44;
            this.dgvCargarVarios.Click += new System.EventHandler(this.dgvCargarVarios_Click);
            // 
            // UsuarioDGV
            // 
            this.UsuarioDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioDGV.HeaderText = "Usuario";
            this.UsuarioDGV.MinimumWidth = 6;
            this.UsuarioDGV.Name = "UsuarioDGV";
            this.UsuarioDGV.ReadOnly = true;
            // 
            // PassDGV
            // 
            this.PassDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PassDGV.HeaderText = "Contraseña";
            this.PassDGV.MinimumWidth = 6;
            this.PassDGV.Name = "PassDGV";
            this.PassDGV.ReadOnly = true;
            // 
            // JerarquiaDGV
            // 
            this.JerarquiaDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JerarquiaDGV.HeaderText = "Jerarquia";
            this.JerarquiaDGV.MinimumWidth = 6;
            this.JerarquiaDGV.Name = "JerarquiaDGV";
            this.JerarquiaDGV.ReadOnly = true;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Black;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(859, 165);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(120, 45);
            this.btnCargar.TabIndex = 35;
            this.btnCargar.Text = "Agregar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtSubtitulo1
            // 
            this.txtSubtitulo1.Location = new System.Drawing.Point(286, 171);
            this.txtSubtitulo1.Name = "txtSubtitulo1";
            this.txtSubtitulo1.Size = new System.Drawing.Size(191, 37);
            this.txtSubtitulo1.TabIndex = 30;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(301, 336);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(97, 45);
            this.lblTitulo2.TabIndex = 43;
            this.lblTitulo2.Text = "Titulo";
            // 
            // lblSubtitulo3
            // 
            this.lblSubtitulo3.AutoSize = true;
            this.lblSubtitulo3.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo3.ForeColor = System.Drawing.Color.Khaki;
            this.lblSubtitulo3.Location = new System.Drawing.Point(12, 127);
            this.lblSubtitulo3.Name = "lblSubtitulo3";
            this.lblSubtitulo3.Size = new System.Drawing.Size(117, 31);
            this.lblSubtitulo3.TabIndex = 42;
            this.lblSubtitulo3.Text = "subtitulo3";
            // 
            // cboSubtitulo2
            // 
            this.cboSubtitulo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubtitulo2.FormattingEnabled = true;
            this.cboSubtitulo2.Items.AddRange(new object[] {
            "empleado",
            "gerente",
            "admin"});
            this.cboSubtitulo2.Location = new System.Drawing.Point(498, 171);
            this.cboSubtitulo2.Name = "cboSubtitulo2";
            this.cboSubtitulo2.Size = new System.Drawing.Size(191, 39);
            this.cboSubtitulo2.TabIndex = 31;
            this.cboSubtitulo2.SelectedIndexChanged += new System.EventHandler(this.cboSubtitulo2_SelectedIndexChanged);
            // 
            // lblSubtitulo2
            // 
            this.lblSubtitulo2.AutoSize = true;
            this.lblSubtitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo2.ForeColor = System.Drawing.Color.Khaki;
            this.lblSubtitulo2.Location = new System.Drawing.Point(498, 137);
            this.lblSubtitulo2.Name = "lblSubtitulo2";
            this.lblSubtitulo2.Size = new System.Drawing.Size(117, 31);
            this.lblSubtitulo2.TabIndex = 41;
            this.lblSubtitulo2.Text = "subtitulo2";
            // 
            // lblSubtitulo1
            // 
            this.lblSubtitulo1.AutoSize = true;
            this.lblSubtitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo1.ForeColor = System.Drawing.Color.Khaki;
            this.lblSubtitulo1.Location = new System.Drawing.Point(286, 137);
            this.lblSubtitulo1.Name = "lblSubtitulo1";
            this.lblSubtitulo1.Size = new System.Drawing.Size(117, 31);
            this.lblSubtitulo1.TabIndex = 40;
            this.lblSubtitulo1.Text = "subtitulo1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(301, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 45);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Titulo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(21, 651);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 45);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboHora
            // 
            this.cboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHora.FormattingEnabled = true;
            this.cboHora.Location = new System.Drawing.Point(12, 76);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(108, 39);
            this.cboHora.TabIndex = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(859, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 45);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(286, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(362, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // CargaVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComplejoDeCines.Properties.Resources.fondo_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboHora);
            this.Controls.Add(this.txtSubtitulo4);
            this.Controls.Add(this.lblSubtitulo4);
            this.Controls.Add(this.txtSubtitulo3);
            this.Controls.Add(this.dtpFuncion);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvCargarVarios);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtSubtitulo1);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblSubtitulo3);
            this.Controls.Add(this.cboSubtitulo2);
            this.Controls.Add(this.lblSubtitulo2);
            this.Controls.Add(this.lblSubtitulo1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CargaVarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargarVarios";
            this.Load += new System.EventHandler(this.CargaVarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarVarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSubtitulo4;
        private Label lblSubtitulo4;
        private TextBox txtSubtitulo3;
        private DateTimePicker dtpFuncion;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvCargarVarios;
        private Button btnCargar;
        private TextBox txtSubtitulo1;
        private Label lblTitulo2;
        private Label lblSubtitulo3;
        private ComboBox cboSubtitulo2;
        private Label lblSubtitulo2;
        private Label lblSubtitulo1;
        private Label lblTitulo;
        private Button btnSalir;
        private ComboBox cboHora;
        private DataGridViewTextBoxColumn UsuarioDGV;
        private DataGridViewTextBoxColumn PassDGV;
        private DataGridViewTextBoxColumn JerarquiaDGV;
        private Button btnGuardar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}