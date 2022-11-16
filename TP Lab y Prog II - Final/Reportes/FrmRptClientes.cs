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
    public partial class FrmRptClientes : Form
    {
        public int idPelicula = 0;
        public int idGenero = 0;
        public string cnn;
        public FrmRptClientes(int genero, int pelicula)
        {
            InitializeComponent();
            idPelicula = pelicula;
            idGenero = genero;  
        }
        public FrmRptClientes()
        {
            InitializeComponent();
        }

        private void FrmRptClientes_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            string nombreSP = "";
            string nombreParam = "";
            if (idGenero == 0)
            {
                nombreSP = "Reporte_Clientes_Pelicula";
                nombreParam = "@PELICULA";
            }
            if(idPelicula == 0)
            {
                nombreSP = "Reporte_Clientes_Genero";
                nombreParam = "@GENERO";
            }
            SqlCommand cmd = new SqlCommand(nombreSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(nombreParam, idGenero);

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
