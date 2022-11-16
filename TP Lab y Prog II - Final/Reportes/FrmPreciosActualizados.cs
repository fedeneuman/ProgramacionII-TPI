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
    public partial class FrmPreciosActualizados : Form
    {
        public int idCine = 0;
        public int idSala=0;
        public double porcentaje=0;
        public string cnn;
        public FrmPreciosActualizados(int Cine, int Sala, double porcentaje)
        {
            InitializeComponent();
            idCine = Cine;
            idSala = Sala;
            porcentaje = porcentaje;
        }
        public FrmPreciosActualizados()
        {
            InitializeComponent();
        }

        private void FrmPreciosActualizados_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LUT25U4\\SQLEXPRESS;Initial Catalog=COMPLEJO_DE_CINES;Integrated Security=True");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT c.NOMBRE cine, s.NRO_SALA sala, s.PRECIO_X_BUTACA precio_unitario_actual, dbo.precio_con_aumento(s.PRECIO_X_BUTACA,0.50) \r\n\tprecio_unitario_modificado, COUNT(b.NRO_BUTACA)*s.PRECIO_X_BUTACA precio_total_actual,SUM(dbo.precio_con_aumento(s.PRECIO_X_BUTACA,0.50)) \r\n\tprecio_total_modificado, COUNT(b.NRO_BUTACA) cantidad_de_butacas\r\n\tFROM SALAS s\r\n\tJOIN CINES c ON c.ID_CINE = s.ID_CINE\r\n\tJOIN BUTACAS b ON b.ID_SALA = s.ID_SALA\r\n\tGROUP BY c.NOMBRE, s.NRO_SALA, s.PRECIO_X_BUTACA", conn);
            //DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            //SqlCommand cmd = new SqlCommand("select v.nombre+' '+v.apellido as Vendedor, sum(cantidad) as Cantidad_de_Ventas , Month(FECHA_RESERVA) as Fecha\r\nfrom COMPROBANTES c\r\njoin VENDEDORES v on v.ID_VENDEDOR = c.ID_VENDEDOR\r\njoin DETALLE_COMPROBANTE dt on dt.ID_COMPROBANTE = c.ID_COMPROBANTE\r\ngroup by CANTIDAD , v.nombre+' '+v.apellido, month (FECHA_RESERVA)", conn);
            SqlCommand cmd = new SqlCommand("Reporte_Butacas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cine",idCine);
            cmd.Parameters.AddWithValue("@sala", idSala);
            cmd.Parameters.AddWithValue("@porcentaje", porcentaje);
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
