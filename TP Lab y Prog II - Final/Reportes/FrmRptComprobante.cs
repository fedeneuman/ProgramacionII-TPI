using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reportes
{
    public partial class FrmRptComprobante : Form
    {

        public DateTime fechaDesde = DateTime.Now;
        public DateTime fechaHasta = DateTime.Now;
        public int idCliente = 0;
        public int idVendedor = 0;
        public string cnn;

        public FrmRptComprobante(DateTime paramDesde, DateTime paramHasta, int cliente, int Vendedor)
        {
            InitializeComponent();
            fechaDesde = paramDesde;
            fechaHasta = paramHasta;
            idCliente = cliente;
            idVendedor = Vendedor;
        }
        public FrmRptComprobante()
        {
            InitializeComponent();
        }

        private void FrmRptComprobante_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT c.FECHA_RESERVA fecha, c.ID_COMPROBANTE nro_de_factura, cli.NOMBRE cliente, v.APELLIDO + ' ' + v.NOMBRE \r\n\tvendedor, SUM(dc.PRECIO*dc.CANTIDAD) importe_total,p.nombre as pelicula\r\n\tFROM COMPROBANTES c\r\n\tJOIN CLIENTES cli on cli.ID_CLIENTE = c.ID_CLIENTE\r\n\tJOIN VENDEDORES v ON v.ID_VENDEDOR = c.ID_VENDEDOR\r\n\tJOIN DETALLE_COMPROBANTE dc ON dc.ID_COMPROBANTE = c.ID_COMPROBANTE\r\n\tjoin PELICULAS p on dc.ID_PELICULA = p.ID_PELICULA\r\n\tGROUP BY c.ID_COMPROBANTE, c.FECHA_RESERVA, cli.NOMBRE, v.APELLIDO, v.NOMBRE,p.NOMBRE\r\n\tORDER BY c.ID_COMPROBANTE", conn);
            SqlCommand cmd = new SqlCommand("Reporte_Comprobante", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha_desde", fechaDesde);
            cmd.Parameters.AddWithValue("@fecha_hasta", fechaHasta);
            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
            cmd.Parameters.AddWithValue("@id_vendedor", idVendedor);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new
            ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }
    }
    
      
}
    
