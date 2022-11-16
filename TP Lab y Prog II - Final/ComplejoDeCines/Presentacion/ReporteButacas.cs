using ComplejoDeCines.HTTP;
using DataApi.Dominio;
using Reportes;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
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
    public partial class ReporteButacas : Form
    {
        private int cine;
        private int sala;
        private double porcentaje;
        public string cnn;
        public ReporteButacas()
        {
            InitializeComponent();
            cine = 0;
            sala = 0;
            porcentaje = 0;

        }

        private async void ReporteButacas_Load(object sender, EventArgs e)
        {
            await CargarComboAsync("cines", "a", cboCine);
            txtPorcentaje.Text = "0";
            Limpiar();
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
            cboCine.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            txtPorcentaje.Text = "0";
            rbAumento.Checked = true;
        }

        private async void cboCine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCine.SelectedIndex != -1)
            {
                await CargarSalas(cboCine.SelectedValue.ToString());
                cboSala.SelectedIndex = -1;
            }
        }
        private async Task CargarSalas(string referencia)
        {
            await CargarComboAsync("salas", referencia, cboSala);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboCine.SelectedIndex == -1 || cboSala.SelectedIndex == -1 || string.IsNullOrEmpty(txtPorcentaje.Text) || txtPorcentaje.Text.Any<char>(Char.IsLetter))
            {
                MessageBox.Show("Valores incorrectos, por favor controlelos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentaje.Text = "0";
            }
            else
            {
                if (rbAumento.Checked)
                {
                    porcentaje = Convert.ToDouble(txtPorcentaje.Text);
                }
                if (rbDescuento.Checked)
                {
                    porcentaje = -1 * Convert.ToDouble(txtPorcentaje.Text);
                }
                Reportes.FrmPreciosActualizados rpt = new Reportes.FrmPreciosActualizados();
                rpt.cnn = cnn;
                rpt.idCine = Convert.ToInt32(cboCine.SelectedValue);
                rpt.idSala = Convert.ToInt32(cboSala.SelectedValue);
                rpt.porcentaje = porcentaje;
                rpt.Show();
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


