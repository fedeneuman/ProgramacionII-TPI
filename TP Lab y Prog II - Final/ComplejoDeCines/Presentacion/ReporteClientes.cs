using ComplejoDeCines.HTTP;
using DataApi.Dominio;
using Newtonsoft.Json;
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
    public partial class ReporteClientes : Form
    {
        private int pelicula;
        private int genero;
        public string cnn;
        public ReporteClientes()
        {
            InitializeComponent();
            genero = 0;
            pelicula = 0;
        }

        private async void ReporteClientes_Load(object sender, EventArgs e)
        {
            await CargarComboAsync("Peliculas", "a", cboPelicula);
            await CargarCombo("Generos", "a", cboGenero);
            Limpiar();
        }
        private async Task CargarCombo(string nombreTabla, string referencia, ComboBox cbo)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros(1, nombreTabla));
            lst.Add(new Parametros(2, referencia));
            string valoresCombo = JsonConvert.SerializeObject(lst);
            string url = "https://localhost:7028/Carga_Varios?nombreTabla=" + nombreTabla + "&referencia=" + referencia;
            var data = await ClientSingleton.GetInstance().PostAsync(url, valoresCombo);
            List<Parametros> combo = JsonConvert.DeserializeObject<List<Parametros>>(data);
            cbo.DataSource = combo;
            cbo.ValueMember = "Codigo";
            cbo.DisplayMember = "Valor";
        }
        private async Task CargarComboAsync(string nombreTabla, string referencia, ComboBox cbo)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros(1, nombreTabla));
            lst.Add(new Parametros(2, referencia));
            string valoresCombo = JsonConvert.SerializeObject(lst);
            string url = "https://localhost:7028/Comprobante?nombreTabla=" + nombreTabla + "&referencia=" + referencia;
            var data = await ClientSingleton.GetInstance().PostAsync(url, valoresCombo);
            List<Parametros> combo = JsonConvert.DeserializeObject<List<Parametros>>(data);
            cbo.DataSource = combo;
            cbo.ValueMember = "Codigo";
            cbo.DisplayMember = "Valor";


        }
        public void Limpiar()
        {
            cboPelicula.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedIndex == -1)
            {
                pelicula = 0;
            }
            else
            {
                pelicula = Convert.ToInt32(cboPelicula.SelectedValue.ToString());
            }
            if (cboGenero.SelectedIndex == -1)
            {
                genero = 0;
            }
            else
            {
                genero = Convert.ToInt32(cboGenero.SelectedValue.ToString());
            }

            Reportes.FrmRptClientes reporte = new Reportes.FrmRptClientes(genero, pelicula);
            reporte.cnn = cnn;
            reporte.Show();
            Limpiar();
        }
        private void cboPelicula_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboGenero.SelectedIndex = -1;
        }

        private void cboGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboPelicula.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
