using ComplejoDeCines.HTTP;
using DataApi.Dominio;
using Newtonsoft.Json;
using Reportes;
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
    public partial class ReporteVendedores : Form
    {
        private int aux = 0;
        public string cnn;
        public ReporteVendedores()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            txtCantidad.Text = "0";
            cbSinVentas.Checked = false;
        }
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.All<char>(Char.IsDigit) && !(string.IsNullOrEmpty(txtCantidad.Text)))
            {
                Reportes.FrmRptVentasxVendedor rptVxVendedor = new Reportes.FrmRptVentasxVendedor(dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(txtCantidad.Text), aux);
                rptVxVendedor.cnn = cnn;
                rptVxVendedor.Show();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Valor 'cantidad' incorrecto, pruebe otra vez !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Text = "0";
            }

        }

        private void cbSinVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSinVentas.Checked)
            {
                aux = 1;
                txtCantidad.Text = "0";
                txtCantidad.Enabled = false;
            }
            else
            {
                txtCantidad.Enabled = true;
                aux = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
