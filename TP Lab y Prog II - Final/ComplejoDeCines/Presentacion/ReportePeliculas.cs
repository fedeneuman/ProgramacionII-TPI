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
    public partial class ReportePeliculas : Form
    {
        public string cnn;
        public ReportePeliculas()
        {
            InitializeComponent();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Reportes.Reporte reporte = new Reportes.Reporte(cboEstacion.Text);
            reporte.cnn = cnn;
            reporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
