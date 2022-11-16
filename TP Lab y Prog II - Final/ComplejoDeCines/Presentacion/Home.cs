using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplejoDeCines.Presentacion
{
    public partial class Home : Form
    {
        public string tipo;
        public string cnn = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = COMPLEJO_DE_CINES; Integrated Security = True";
        public Home()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea cerrar sesion?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        { 
            MIClientesCargar.Enabled = false;
            MiClientesAdmin.Enabled = false;
            MIVendCargar.Enabled = false;
            MIVendAdmin.Enabled = false;
            MIAdminCines.Enabled = false;
            MIAdminSalas.Enabled = false;
            MIPeliculaAdmin.Enabled = false;
            MIPeliculaAFuncion.Enabled = false;
            if (tipo == "empleado")
            {
                MIVendedores.Visible = false;
                MIUsuarios.Visible = false;
                MIVarios.Visible = false;
                MIAdminSalas.Visible = false;
                MIPeliculaAFuncion.Visible = false;
                MIReportes.Visible = false;
            }
            else if (tipo == "gerente")
            {
                MIVarios.Visible = false;
            }
        }
        public void LevantarForms(string form, string tipo)
        {
            this.Hide();
            if (form == "cargavarios")
            {
                CargaVarios frm = new CargaVarios();
                frm.tipo = tipo;
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "pelicula")
            {
                Pelicula frm = new Pelicula();
                frm.tipo = tipo;
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "cine")
            {
                Cine frm = new Cine();
                frm.tipo = tipo;
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "agregar a funcion")
            {
                FuncionXPeli frm = new FuncionXPeli();
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "persona")
            {
                Persona frm = new Persona();
                frm.tipo = tipo;
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "comprobante")
            {
                Comprobante frm = new Comprobante();
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "salaButaca")
            {
                SalaButaca frm = new SalaButaca();
                frm.ShowDialog();
                this.Show();
            }
            else if (form == "reporte")
            {
                if (tipo == "clientes")
                {
                    ReporteClientes frm = new ReporteClientes();
                    frm.cnn = cnn;
                    frm.ShowDialog();
                    this.Show();
                }
                else if (tipo == "butacas")
                {
                    ReporteButacas frm = new ReporteButacas();
                    frm.cnn = cnn;
                    frm.ShowDialog();
                    this.Show();
                }
                else if (tipo == "vendedores")
                {
                    ReporteVendedores frm = new ReporteVendedores();
                    frm.cnn = cnn;
                    frm.ShowDialog();
                    this.Show();
                }
                else if (tipo == "peliculas")
                {
                    ReportePeliculas frm = new ReportePeliculas();
                    frm.cnn = cnn;
                    frm.ShowDialog();
                    this.Show();
                }
                else if (tipo == "comprobantes")
                {
                    ReporteComprobante frm = new ReporteComprobante();
                    frm.cnn = cnn;
                    frm.ShowDialog();
                    this.Show();
                }
            }
            else if (form == "AcercaDe")
            {
                AcercaDe frm = new AcercaDe();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                Admin frm = new Admin();
                frm.tipo = tipo;
                if (this.tipo == "empleado")
                {
                    frm.user = "empleado";
                }
                frm.ShowDialog();
                this.Show();
            }

        }

        //--------------------------------------------------------------------
        // Empieza carga de LevantarForms() a las distintas pestanias
        // Clientes-- Listo
        private void MIClientesCargar_Click(object sender, EventArgs e)
        {
            LevantarForms("persona", "Cliente");
        }

        private void MIClientesAdmin_Click(object sender, EventArgs e)
        {
            LevantarForms("admin", "Cliente");
        }

        // Vendedores -- Listo
        private void MIVendCargar_Click(object sender, EventArgs e)
        {
            LevantarForms("persona", "Vendedor");
        }

        private void MIVendAdmin_Click(object sender, EventArgs e)
        {
            LevantarForms("admin", "Vendedor");
        }

        // Facturas -- Listo
        private void MIFacturasCargar_Click(object sender, EventArgs e)
        {
            LevantarForms("comprobante", "");
        }

        private void MIFacturasAdmin_Click(object sender, EventArgs e)
        {
            LevantarForms("admin", "Comprobante");
        }

        // Cines -- Listo

        private void MIAdminCines_Click(object sender, EventArgs e)
        {

            if (tipo == "empleado")
            {
                LevantarForms("cine", "empleado");
            }
            else
            {
                LevantarForms("cine", "otro");
            }
        }

        // Salas/Butacas -- VER

        private void MIAdminSalas_Click(object sender, EventArgs e)
        {
            LevantarForms("salaButaca", "sala");
        }

        // Peliculas -- Listo
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipo == "empleado")
            {
                LevantarForms("pelicula", "empleado");
            }
            else if (tipo == "gerente")
            {
                LevantarForms("pelicula", "gerente");
            }
            else
            {
                LevantarForms("pelicula", "admin");
            }
        }
        private void MIAgregarPeliAFuncion_Click(object sender, EventArgs e)
        {
            LevantarForms("agregar a funcion", "");
        }

        // Usuarios -- Listo
        private void MIUsuarioCargar_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Usuario");
        }

        // Varios -- Listo
        private void MIProvinicias_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Provincia");
        }

        private void MICiudades_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Ciudad");
        }

        private void MIBarrios_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Barrio");
        }

        private void MITiposDoc_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Tipos de documento");
        }

        private void MITiposClientes_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Tipos de cliente");
        }

        private void tiposSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Tipos de sala");
        }

        private void MICondIva_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Condicion IVA");
        }

        private void MIFormasPago_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Formas de pago");
        }

        private void MIDescuentos_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Descuento");
        }

        private void MIFormasCompra_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Formas de compra");
        }

        private void generosPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Generos de pelicula");
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Funcion");
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Idioma");
        }

        private void subtituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Subtitulo");
        }

        private void clasificacionEdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("cargavarios", "Clasificacion de edades");
        }

        // Reportes -- En progreso
        private void clientesQueNoAsistieronAPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("reporte", "clientes");
        }

        private void modificarPrecioDeButacasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("reporte", "butacas");
        }

        private void estadoDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("reporte", "vendedores");
        }

        private void peliculasPorEstacion8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("reporte", "peliculas");
        }

        private void comprobantesPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("reporte", "comprobantes");
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevantarForms("AcercaDe", "");
        }
    }
}
