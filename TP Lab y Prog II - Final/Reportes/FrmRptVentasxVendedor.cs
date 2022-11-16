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
    public partial class FrmRptVentasxVendedor : Form
    {   public DateTime fechaDesde = DateTime.Now;
        public DateTime fechaHasta = DateTime.Now;
        public int cantidad = 0;
        public int sinventas = 0;
        public string cnn;
        public FrmRptVentasxVendedor(DateTime fechaDesde, DateTime fechaHasta,int cant, int ventasnulas)
        {
            InitializeComponent();
            this.fechaDesde = fechaDesde;        
            this.fechaHasta = fechaHasta;
            this.cantidad = cant;
            this.sinventas = ventasnulas;

        }
        public FrmRptVentasxVendedor()
        {
            InitializeComponent();
        }

        private void FrmRptVentasxVendedor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            //SqlCommand cmd = new SqlCommand("select v.nombre+' '+v.apellido as Vendedor, sum(cantidad) as Cantidad_de_Ventas , Month(FECHA_RESERVA) as Fecha\r\nfrom COMPROBANTES c\r\njoin VENDEDORES v on v.ID_VENDEDOR = c.ID_VENDEDOR\r\njoin DETALLE_COMPROBANTE dt on dt.ID_COMPROBANTE = c.ID_COMPROBANTE\r\ngroup by CANTIDAD , v.nombre+' '+v.apellido, month (FECHA_RESERVA)", conn);
            SqlCommand cmd = new SqlCommand("Reporte_Vendedor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha_desde", fechaDesde);
            cmd.Parameters.AddWithValue("@fecha_hasta", fechaHasta);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@sin_ventas", sinventas);

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
