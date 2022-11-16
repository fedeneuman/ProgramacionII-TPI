namespace ComplejoDeCines.Presentacion
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MITransaccion = new System.Windows.Forms.ToolStripMenuItem();
            this.MIFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.MIFacturasCargar = new System.Windows.Forms.ToolStripMenuItem();
            this.MIFacturasAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MIReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesQueNoAsistieronAPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPrecioDeButacasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasPorEstacion8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobantesPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MISoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MIClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MIClientesCargar = new System.Windows.Forms.ToolStripMenuItem();
            this.MiClientesAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MIVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MIVendCargar = new System.Windows.Forms.ToolStripMenuItem();
            this.MIVendAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MICines = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAdminCines = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAdminSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.MIPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.MIPeliculaAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MIPeliculaAFuncion = new System.Windows.Forms.ToolStripMenuItem();
            this.MIUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MIUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MIVarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MIProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.MICiudades = new System.Windows.Forms.ToolStripMenuItem();
            this.MIBarrios = new System.Windows.Forms.ToolStripMenuItem();
            this.MITiposDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.MITiposCli = new System.Windows.Forms.ToolStripMenuItem();
            this.MITiposSala = new System.Windows.Forms.ToolStripMenuItem();
            this.MICondIVA = new System.Windows.Forms.ToolStripMenuItem();
            this.MIDescuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.MIFormasPago = new System.Windows.Forms.ToolStripMenuItem();
            this.MIFormasCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.MIGenerosPeli = new System.Windows.Forms.ToolStripMenuItem();
            this.MIIdiomas = new System.Windows.Forms.ToolStripMenuItem();
            this.MISubtitulos = new System.Windows.Forms.ToolStripMenuItem();
            this.MIFunciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MICasifEdades = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MITransaccion,
            this.MIReportes,
            this.MISoporte,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 72);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MITransaccion
            // 
            this.MITransaccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIFacturas});
            this.MITransaccion.Name = "MITransaccion";
            this.MITransaccion.Padding = new System.Windows.Forms.Padding(150, 4, 150, 4);
            this.MITransaccion.Size = new System.Drawing.Size(457, 64);
            this.MITransaccion.Text = "Transaccion";
            // 
            // MIFacturas
            // 
            this.MIFacturas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIFacturasCargar,
            this.MIFacturasAdmin});
            this.MIFacturas.Name = "MIFacturas";
            this.MIFacturas.Size = new System.Drawing.Size(296, 44);
            this.MIFacturas.Text = "Comprobantes";
            // 
            // MIFacturasCargar
            // 
            this.MIFacturasCargar.Name = "MIFacturasCargar";
            this.MIFacturasCargar.Size = new System.Drawing.Size(259, 44);
            this.MIFacturasCargar.Text = "Cargar";
            this.MIFacturasCargar.Click += new System.EventHandler(this.MIFacturasCargar_Click);
            // 
            // MIFacturasAdmin
            // 
            this.MIFacturasAdmin.Name = "MIFacturasAdmin";
            this.MIFacturasAdmin.Size = new System.Drawing.Size(259, 44);
            this.MIFacturasAdmin.Text = "Administrar";
            this.MIFacturasAdmin.Click += new System.EventHandler(this.MIFacturasAdmin_Click);
            // 
            // MIReportes
            // 
            this.MIReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesQueNoAsistieronAPeliculasToolStripMenuItem,
            this.modificarPrecioDeButacasToolStripMenuItem,
            this.estadoDeVendedoresToolStripMenuItem,
            this.peliculasPorEstacion8ToolStripMenuItem,
            this.comprobantesPorFechaToolStripMenuItem});
            this.MIReportes.Name = "MIReportes";
            this.MIReportes.Padding = new System.Windows.Forms.Padding(80, 4, 4, 0);
            this.MIReportes.Size = new System.Drawing.Size(209, 64);
            this.MIReportes.Text = "Reportes";
            // 
            // clientesQueNoAsistieronAPeliculasToolStripMenuItem
            // 
            this.clientesQueNoAsistieronAPeliculasToolStripMenuItem.Name = "clientesQueNoAsistieronAPeliculasToolStripMenuItem";
            this.clientesQueNoAsistieronAPeliculasToolStripMenuItem.Size = new System.Drawing.Size(555, 44);
            this.clientesQueNoAsistieronAPeliculasToolStripMenuItem.Text = "Clientes que no asistieron a peliculas";
            this.clientesQueNoAsistieronAPeliculasToolStripMenuItem.Click += new System.EventHandler(this.clientesQueNoAsistieronAPeliculasToolStripMenuItem_Click);
            // 
            // modificarPrecioDeButacasToolStripMenuItem
            // 
            this.modificarPrecioDeButacasToolStripMenuItem.Name = "modificarPrecioDeButacasToolStripMenuItem";
            this.modificarPrecioDeButacasToolStripMenuItem.Size = new System.Drawing.Size(555, 44);
            this.modificarPrecioDeButacasToolStripMenuItem.Text = "Consultar aumento/descuento";
            this.modificarPrecioDeButacasToolStripMenuItem.Click += new System.EventHandler(this.modificarPrecioDeButacasToolStripMenuItem_Click);
            // 
            // estadoDeVendedoresToolStripMenuItem
            // 
            this.estadoDeVendedoresToolStripMenuItem.Name = "estadoDeVendedoresToolStripMenuItem";
            this.estadoDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(555, 44);
            this.estadoDeVendedoresToolStripMenuItem.Text = "Ventas por vendedor";
            this.estadoDeVendedoresToolStripMenuItem.Click += new System.EventHandler(this.estadoDeVendedoresToolStripMenuItem_Click);
            // 
            // peliculasPorEstacion8ToolStripMenuItem
            // 
            this.peliculasPorEstacion8ToolStripMenuItem.Name = "peliculasPorEstacion8ToolStripMenuItem";
            this.peliculasPorEstacion8ToolStripMenuItem.Size = new System.Drawing.Size(555, 44);
            this.peliculasPorEstacion8ToolStripMenuItem.Text = "Peliculas por estacion";
            this.peliculasPorEstacion8ToolStripMenuItem.Click += new System.EventHandler(this.peliculasPorEstacion8ToolStripMenuItem_Click);
            // 
            // comprobantesPorFechaToolStripMenuItem
            // 
            this.comprobantesPorFechaToolStripMenuItem.Name = "comprobantesPorFechaToolStripMenuItem";
            this.comprobantesPorFechaToolStripMenuItem.Size = new System.Drawing.Size(555, 44);
            this.comprobantesPorFechaToolStripMenuItem.Text = "Comprobantes por fecha";
            this.comprobantesPorFechaToolStripMenuItem.Click += new System.EventHandler(this.comprobantesPorFechaToolStripMenuItem_Click);
            // 
            // MISoporte
            // 
            this.MISoporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIClientes,
            this.MIVendedores,
            this.MICines,
            this.MIPeliculas,
            this.MIUsuarios,
            this.MIVarios});
            this.MISoporte.Name = "MISoporte";
            this.MISoporte.Padding = new System.Windows.Forms.Padding(210, 4, 4, 0);
            this.MISoporte.Size = new System.Drawing.Size(329, 64);
            this.MISoporte.Text = "Soporte";
            // 
            // MIClientes
            // 
            this.MIClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIClientesCargar,
            this.MiClientesAdmin});
            this.MIClientes.Name = "MIClientes";
            this.MIClientes.Size = new System.Drawing.Size(261, 44);
            this.MIClientes.Text = "Clientes";
            // 
            // MIClientesCargar
            // 
            this.MIClientesCargar.Name = "MIClientesCargar";
            this.MIClientesCargar.Size = new System.Drawing.Size(259, 44);
            this.MIClientesCargar.Text = "Cargar";
            this.MIClientesCargar.Click += new System.EventHandler(this.MIClientesCargar_Click);
            // 
            // MiClientesAdmin
            // 
            this.MiClientesAdmin.Name = "MiClientesAdmin";
            this.MiClientesAdmin.Size = new System.Drawing.Size(259, 44);
            this.MiClientesAdmin.Text = "Administrar";
            this.MiClientesAdmin.Click += new System.EventHandler(this.MIClientesAdmin_Click);
            // 
            // MIVendedores
            // 
            this.MIVendedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIVendCargar,
            this.MIVendAdmin});
            this.MIVendedores.Name = "MIVendedores";
            this.MIVendedores.Size = new System.Drawing.Size(261, 44);
            this.MIVendedores.Text = "Vendedores";
            // 
            // MIVendCargar
            // 
            this.MIVendCargar.Name = "MIVendCargar";
            this.MIVendCargar.Size = new System.Drawing.Size(259, 44);
            this.MIVendCargar.Text = "Cargar";
            this.MIVendCargar.Click += new System.EventHandler(this.MIVendCargar_Click);
            // 
            // MIVendAdmin
            // 
            this.MIVendAdmin.Name = "MIVendAdmin";
            this.MIVendAdmin.Size = new System.Drawing.Size(259, 44);
            this.MIVendAdmin.Text = "Administrar";
            this.MIVendAdmin.Click += new System.EventHandler(this.MIVendAdmin_Click);
            // 
            // MICines
            // 
            this.MICines.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIAdminCines,
            this.MIAdminSalas});
            this.MICines.Name = "MICines";
            this.MICines.Size = new System.Drawing.Size(261, 44);
            this.MICines.Text = "Cines";
            // 
            // MIAdminCines
            // 
            this.MIAdminCines.Name = "MIAdminCines";
            this.MIAdminCines.Size = new System.Drawing.Size(298, 44);
            this.MIAdminCines.Text = "Cines";
            this.MIAdminCines.Click += new System.EventHandler(this.MIAdminCines_Click);
            // 
            // MIAdminSalas
            // 
            this.MIAdminSalas.Name = "MIAdminSalas";
            this.MIAdminSalas.Size = new System.Drawing.Size(298, 44);
            this.MIAdminSalas.Text = "Salas y Butacas";
            this.MIAdminSalas.Click += new System.EventHandler(this.MIAdminSalas_Click);
            // 
            // MIPeliculas
            // 
            this.MIPeliculas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIPeliculaAdmin,
            this.MIPeliculaAFuncion});
            this.MIPeliculas.Name = "MIPeliculas";
            this.MIPeliculas.Size = new System.Drawing.Size(261, 44);
            this.MIPeliculas.Text = "Peliculas";
            // 
            // MIPeliculaAdmin
            // 
            this.MIPeliculaAdmin.Name = "MIPeliculaAdmin";
            this.MIPeliculaAdmin.Size = new System.Drawing.Size(334, 44);
            this.MIPeliculaAdmin.Text = "Administrar";
            this.MIPeliculaAdmin.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // MIPeliculaAFuncion
            // 
            this.MIPeliculaAFuncion.Name = "MIPeliculaAFuncion";
            this.MIPeliculaAFuncion.Size = new System.Drawing.Size(334, 44);
            this.MIPeliculaAFuncion.Text = "Agregar a funcion";
            this.MIPeliculaAFuncion.Click += new System.EventHandler(this.MIAgregarPeliAFuncion_Click);
            // 
            // MIUsuarios
            // 
            this.MIUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIUserAdmin});
            this.MIUsuarios.Name = "MIUsuarios";
            this.MIUsuarios.Size = new System.Drawing.Size(261, 44);
            this.MIUsuarios.Text = "Usuarios";
            // 
            // MIUserAdmin
            // 
            this.MIUserAdmin.Name = "MIUserAdmin";
            this.MIUserAdmin.Size = new System.Drawing.Size(259, 44);
            this.MIUserAdmin.Text = "Administrar";
            this.MIUserAdmin.Click += new System.EventHandler(this.MIUsuarioCargar_Click);
            // 
            // MIVarios
            // 
            this.MIVarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIProvincias,
            this.MICiudades,
            this.MIBarrios,
            this.MITiposDoc,
            this.MITiposCli,
            this.MITiposSala,
            this.MICondIVA,
            this.MIDescuentos,
            this.MIFormasPago,
            this.MIFormasCompra,
            this.MIGenerosPeli,
            this.MIIdiomas,
            this.MISubtitulos,
            this.MIFunciones,
            this.MICasifEdades});
            this.MIVarios.Name = "MIVarios";
            this.MIVarios.Size = new System.Drawing.Size(261, 44);
            this.MIVarios.Text = "Varios";
            // 
            // MIProvincias
            // 
            this.MIProvincias.Enabled = false;
            this.MIProvincias.Name = "MIProvincias";
            this.MIProvincias.Size = new System.Drawing.Size(359, 44);
            this.MIProvincias.Text = "Provincias";
            this.MIProvincias.Click += new System.EventHandler(this.MIProvinicias_Click);
            // 
            // MICiudades
            // 
            this.MICiudades.Enabled = false;
            this.MICiudades.Name = "MICiudades";
            this.MICiudades.Size = new System.Drawing.Size(359, 44);
            this.MICiudades.Text = "Ciudades";
            this.MICiudades.Click += new System.EventHandler(this.MICiudades_Click);
            // 
            // MIBarrios
            // 
            this.MIBarrios.Enabled = false;
            this.MIBarrios.Name = "MIBarrios";
            this.MIBarrios.Size = new System.Drawing.Size(359, 44);
            this.MIBarrios.Text = "Barrios";
            this.MIBarrios.Click += new System.EventHandler(this.MIBarrios_Click);
            // 
            // MITiposDoc
            // 
            this.MITiposDoc.Enabled = false;
            this.MITiposDoc.Name = "MITiposDoc";
            this.MITiposDoc.Size = new System.Drawing.Size(359, 44);
            this.MITiposDoc.Text = "Tipos documento";
            this.MITiposDoc.Click += new System.EventHandler(this.MITiposDoc_Click);
            // 
            // MITiposCli
            // 
            this.MITiposCli.Enabled = false;
            this.MITiposCli.Name = "MITiposCli";
            this.MITiposCli.Size = new System.Drawing.Size(359, 44);
            this.MITiposCli.Text = "Tipos clientes";
            this.MITiposCli.Click += new System.EventHandler(this.MITiposClientes_Click);
            // 
            // MITiposSala
            // 
            this.MITiposSala.Enabled = false;
            this.MITiposSala.Name = "MITiposSala";
            this.MITiposSala.Size = new System.Drawing.Size(359, 44);
            this.MITiposSala.Text = "Tipos salas";
            this.MITiposSala.Click += new System.EventHandler(this.tiposSalaToolStripMenuItem_Click);
            // 
            // MICondIVA
            // 
            this.MICondIVA.Enabled = false;
            this.MICondIVA.Name = "MICondIVA";
            this.MICondIVA.Size = new System.Drawing.Size(359, 44);
            this.MICondIVA.Text = "Condiciones IVA";
            this.MICondIVA.Click += new System.EventHandler(this.MICondIva_Click);
            // 
            // MIDescuentos
            // 
            this.MIDescuentos.Enabled = false;
            this.MIDescuentos.Name = "MIDescuentos";
            this.MIDescuentos.Size = new System.Drawing.Size(359, 44);
            this.MIDescuentos.Text = "Descuentos";
            this.MIDescuentos.Click += new System.EventHandler(this.MIDescuentos_Click);
            // 
            // MIFormasPago
            // 
            this.MIFormasPago.Enabled = false;
            this.MIFormasPago.Name = "MIFormasPago";
            this.MIFormasPago.Size = new System.Drawing.Size(359, 44);
            this.MIFormasPago.Text = "Formas de pago";
            this.MIFormasPago.Click += new System.EventHandler(this.MIFormasPago_Click);
            // 
            // MIFormasCompra
            // 
            this.MIFormasCompra.Enabled = false;
            this.MIFormasCompra.Name = "MIFormasCompra";
            this.MIFormasCompra.Size = new System.Drawing.Size(359, 44);
            this.MIFormasCompra.Text = "Formas de compra";
            this.MIFormasCompra.Click += new System.EventHandler(this.MIFormasCompra_Click);
            // 
            // MIGenerosPeli
            // 
            this.MIGenerosPeli.Enabled = false;
            this.MIGenerosPeli.Name = "MIGenerosPeli";
            this.MIGenerosPeli.Size = new System.Drawing.Size(359, 44);
            this.MIGenerosPeli.Text = "Generos peliculas";
            this.MIGenerosPeli.Click += new System.EventHandler(this.generosPeliculasToolStripMenuItem_Click);
            // 
            // MIIdiomas
            // 
            this.MIIdiomas.Enabled = false;
            this.MIIdiomas.Name = "MIIdiomas";
            this.MIIdiomas.Size = new System.Drawing.Size(359, 44);
            this.MIIdiomas.Text = "Idiomas";
            this.MIIdiomas.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // MISubtitulos
            // 
            this.MISubtitulos.Enabled = false;
            this.MISubtitulos.Name = "MISubtitulos";
            this.MISubtitulos.Size = new System.Drawing.Size(359, 44);
            this.MISubtitulos.Text = "Subtitulos";
            this.MISubtitulos.Click += new System.EventHandler(this.subtituloToolStripMenuItem_Click);
            // 
            // MIFunciones
            // 
            this.MIFunciones.Enabled = false;
            this.MIFunciones.Name = "MIFunciones";
            this.MIFunciones.Size = new System.Drawing.Size(359, 44);
            this.MIFunciones.Text = "Funciones";
            this.MIFunciones.Click += new System.EventHandler(this.funcionToolStripMenuItem_Click);
            // 
            // MICasifEdades
            // 
            this.MICasifEdades.Enabled = false;
            this.MICasifEdades.Name = "MICasifEdades";
            this.MICasifEdades.Size = new System.Drawing.Size(359, 44);
            this.MICasifEdades.Text = "Clasificacion edades";
            this.MICasifEdades.Click += new System.EventHandler(this.clasificacionEdadesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acerdaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(150, 4, 4, 20);
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(248, 64);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(236, 44);
            this.acerdaDeToolStripMenuItem.Text = "Acerca de";
            this.acerdaDeToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::ComplejoDeCines.Properties.Resources.btn_salir_over;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(76, 1055);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(239, 64);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::ComplejoDeCines.Properties.Resources.btn_salir_over;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(30, 809);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 58);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Salir";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComplejoDeCines.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MITransaccion;
        private ToolStripMenuItem MISoporte;
        private ToolStripMenuItem MIClientes;
        private ToolStripMenuItem MIClientesCargar;
        private ToolStripMenuItem MiClientesAdmin;
        private ToolStripMenuItem MIVendedores;
        private ToolStripMenuItem MIVendCargar;
        private ToolStripMenuItem MIVendAdmin;
        private ToolStripMenuItem MICines;
        private ToolStripMenuItem MIAdminCines;
        private ToolStripMenuItem MIAdminSalas;
        private ToolStripMenuItem MIPeliculas;
        private ToolStripMenuItem MIPeliculaAdmin;
        private ToolStripMenuItem MIPeliculaAFuncion;
        private ToolStripMenuItem MIUsuarios;
        private ToolStripMenuItem MIUserAdmin;
        private ToolStripMenuItem MIVarios;
        private ToolStripMenuItem MIProvincias;
        private ToolStripMenuItem MICiudades;
        private ToolStripMenuItem MIBarrios;
        private ToolStripMenuItem MITiposDoc;
        private ToolStripMenuItem MITiposCli;
        private ToolStripMenuItem MITiposSala;
        private ToolStripMenuItem MICondIVA;
        private ToolStripMenuItem MIDescuentos;
        private ToolStripMenuItem MIFormasPago;
        private ToolStripMenuItem MIFormasCompra;
        private ToolStripMenuItem MIGenerosPeli;
        private ToolStripMenuItem MIIdiomas;
        private ToolStripMenuItem MISubtitulos;
        private ToolStripMenuItem MIFunciones;
        private ToolStripMenuItem MICasifEdades;
        private ToolStripMenuItem MIFacturas;
        private ToolStripMenuItem MIFacturasCargar;
        private ToolStripMenuItem MIFacturasAdmin;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acerdaDeToolStripMenuItem;
        private ToolStripMenuItem MIReportes;
        private ToolStripMenuItem clientesQueNoAsistieronAPeliculasToolStripMenuItem;
        private ToolStripMenuItem modificarPrecioDeButacasToolStripMenuItem;
        private ToolStripMenuItem estadoDeVendedoresToolStripMenuItem;
        private ToolStripMenuItem peliculasPorEstacion8ToolStripMenuItem;
        private ToolStripMenuItem comprobantesPorFechaToolStripMenuItem;
        private Button btnSalir;
        private Button btnLogin;
    }
}