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
    public partial class ReporteComprobante : Form
    {
        private int cliente, vendedor;
        public string cnn;
        public ReporteComprobante()
        {
            InitializeComponent();
            cliente = 0;
            vendedor = 0;
        }

        private async void ReporteComprobante_Load(object sender, EventArgs e)
        {
            await CargarComboAsync("clientes", "a", cboCliente);
            await CargarComboAsync("vendedores", "a", cboVendedor);
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
            cboVendedor.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex == -1)
            {
                cliente = 0;
            }
            else
            {
                cliente = Convert.ToInt32(cboCliente.SelectedValue.ToString());
            }
            if (cboVendedor.SelectedIndex == -1)
            {
                vendedor = 0;
            }
            else
            {
                vendedor = Convert.ToInt32(cboVendedor.SelectedValue.ToString());
            }
            Reportes.FrmRptComprobante reporte = new Reportes.FrmRptComprobante(dtpFechaDesde.Value, dtpFechaHasta.Value, cliente, vendedor);
            reporte.cnn = cnn;
            reporte.Show();
            Limpiar();
        }
    }
}





