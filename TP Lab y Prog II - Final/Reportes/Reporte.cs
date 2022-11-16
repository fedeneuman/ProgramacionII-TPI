using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Reporte : Form
    {
        public string aux = "";
        public string cnn;
        public Reporte(string estacion)
        {
            InitializeComponent();
            aux= estacion;

        }
        public Reporte( )
        {
            InitializeComponent();
            

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Reporte_Peliculas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ESTACION",aux);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new
            ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
