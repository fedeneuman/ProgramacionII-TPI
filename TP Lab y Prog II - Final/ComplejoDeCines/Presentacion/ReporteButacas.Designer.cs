namespace ComplejoDeCines.Presentacion
{
    partial class ReporteButacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteButacas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAumento = new System.Windows.Forms.RadioButton();
            this.rbDescuento = new System.Windows.Forms.RadioButton();
            this.cboCine = new System.Windows.Forms.ComboBox();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(273, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(585, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(585, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(869, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "%";
            // 
            // rbAumento
            // 
            this.rbAumento.AutoSize = true;
            this.rbAumento.BackColor = System.Drawing.Color.Transparent;
            this.rbAumento.ForeColor = System.Drawing.Color.Khaki;
            this.rbAumento.Location = new System.Drawing.Point(273, 380);
            this.rbAumento.Margin = new System.Windows.Forms.Padding(1);
            this.rbAumento.Name = "rbAumento";
            this.rbAumento.Size = new System.Drawing.Size(133, 35);
            this.rbAumento.TabIndex = 4;
            this.rbAumento.TabStop = true;
            this.rbAumento.Text = "Aumento";
            this.rbAumento.UseVisualStyleBackColor = false;
            // 
            // rbDescuento
            // 
            this.rbDescuento.AutoSize = true;
            this.rbDescuento.BackColor = System.Drawing.Color.Transparent;
            this.rbDescuento.ForeColor = System.Drawing.Color.Khaki;
            this.rbDescuento.Location = new System.Drawing.Point(408, 380);
            this.rbDescuento.Margin = new System.Windows.Forms.Padding(1);
            this.rbDescuento.Name = "rbDescuento";
            this.rbDescuento.Size = new System.Drawing.Size(147, 35);
            this.rbDescuento.TabIndex = 5;
            this.rbDescuento.TabStop = true;
            this.rbDescuento.Text = "Descuento";
            this.rbDescuento.UseVisualStyleBackColor = false;
            // 
            // cboCine
            // 
            this.cboCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCine.FormattingEnabled = true;
            this.cboCine.Location = new System.Drawing.Point(273, 291);
            this.cboCine.Margin = new System.Windows.Forms.Padding(1);
            this.cboCine.Name = "cboCine";
            this.cboCine.Size = new System.Drawing.Size(282, 39);
            this.cboCine.TabIndex = 6;
            this.cboCine.SelectionChangeCommitted += new System.EventHandler(this.cboCine_SelectionChangeCommitted);
            // 
            // cboSala
            // 
            this.cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(585, 291);
            this.cboSala.Margin = new System.Windows.Forms.Padding(1);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(282, 39);
            this.cboSala.TabIndex = 7;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(585, 384);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(1);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(282, 37);
            this.txtPorcentaje.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(336, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consultar Aumentos / Descuentos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(717, 444);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(1);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 45);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 159;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(25, 650);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 45);
            this.btnSalir.TabIndex = 160;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ReporteButacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComplejoDeCines.Properties.Resources.fondo_reporte;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.cboCine);
            this.Controls.Add(this.rbDescuento);
            this.Controls.Add(this.rbAumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "ReporteButacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar aumentos/descuentos";
            this.Load += new System.EventHandler(this.ReporteButacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbAumento;
        private RadioButton rbDescuento;
        private ComboBox cboCine;
        private ComboBox cboSala;
        private TextBox txtPorcentaje;
        private Label label5;
        private Button btnConsultar;
        private PictureBox pictureBox2;
        private Button btnSalir;
    }
}