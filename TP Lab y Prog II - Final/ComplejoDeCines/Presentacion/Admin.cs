using ComplejoDeCines.HTTP;
using DataApi.Dominio;
using DataApi.Dominios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplejoDeCines.Presentacion
{
    public partial class Admin : Form
    {
        public string tipo;
        public string user;
        public comprobanteString compS;
        public Comprobantes comp;
        public List<Comprobantes> compList;
        public int Id;
        public Admin()
        {
            InitializeComponent();
            compS = new comprobanteString();
            Id = 0;
            comp = new Comprobantes();
            compList = new List<Comprobantes>();
        }
        
        
        private async void Administrar_Load(object sender, EventArgs e)
        {
            this.Text = "Administrar " + tipo;
            lblTitulo.Text = "Administrar " + tipo;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            compList = await CargarDGV();
            if (user == "empleado")
            {
                btnEliminar.Visible = false;
            }
        }

        private async Task<List<Comprobantes>> CargarDGV()
        {
            //Cargar DGV
            string url = "https://localhost:7028/Consultar_Comprobante";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<comprobanteString> dgvComprobante = JsonConvert.DeserializeObject<List<comprobanteString>>(data);

            foreach(comprobanteString comp in dgvComprobante)
            {
                dgvComprobanteAdmin.Rows.Add(new object[] { comp.IdComprobante, comp.Vendedor, comp.Cliente, comp.Cine, comp.FechaReserva, comp.FormaCompra, comp.Descuento });
            }
            //Crea Lista ID
            string urlIds = "https://localhost:7028/Consultar_Comprobante_Ids";
            var dataIds = await ClientSingleton.GetInstance().GetAsync(urlIds);
            List<Comprobantes> compListIds = JsonConvert.DeserializeObject<List<Comprobantes>>(dataIds);

            return compListIds;

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (tipo == "Comprobante")
            {                
                compS.IdComprobante = Convert.ToInt32(dgvComprobanteAdmin.CurrentRow.Cells[0].Value.ToString());
                compS.Vendedor = dgvComprobanteAdmin.CurrentRow.Cells[1].Value.ToString();
                compS.Cliente = dgvComprobanteAdmin.CurrentRow.Cells[2].Value.ToString();
                compS.Cine = dgvComprobanteAdmin.CurrentRow.Cells[3].Value.ToString();
                compS.FechaReserva = Convert.ToDateTime(dgvComprobanteAdmin.CurrentRow.Cells[4].Value.ToString());
                compS.FormaCompra = dgvComprobanteAdmin.CurrentRow.Cells[5].Value.ToString();
                compS.Descuento = dgvComprobanteAdmin.CurrentRow.Cells[6].Value.ToString();

                foreach(Comprobantes c in compList)
                {
                    if(c.IdComprobante == Convert.ToInt32(dgvComprobanteAdmin.CurrentRow.Cells[0].Value.ToString()))
                    {
                        comp.IdComprobante = c.IdComprobante;
                        comp.IdVendedor = c.IdVendedor;
                        comp.IdCliente = c.IdCliente;
                        comp.IdCine = c.IdCine;
                        comp.FechaReserva = c.FechaReserva;
                        comp.IdFormaCompra = c.IdFormaCompra;
                        comp.IdTipoDescuento=c.IdTipoDescuento;
                    }
                }
                this.Hide();
                Comprobante frm = new Comprobante(compS, comp);
                frm.accion = "editar";
                frm.ShowDialog();
                this.Show();
                Inicializar();
                dgvComprobanteAdmin.Rows.Clear();
                compList = await CargarDGV();
            }
            else
            {
                this.Hide();
                Persona frm = new Persona();
                frm.tipo = tipo;
                frm.accion = "editar";
                frm.ShowDialog();
                this.Show();
            }


        }

        private void Inicializar()
        {
            compS = new comprobanteString();
            Id = 0;
            comp = new Comprobantes();
            compList = new List<Comprobantes>();
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar el comprobante "+ dgvComprobanteAdmin.CurrentRow.Cells[0].Value.ToString()+"?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                comp.IdComprobante = Convert.ToInt32(dgvComprobanteAdmin.CurrentRow.Cells[0].Value.ToString());
                comp.IdVendedor = 1;
                comp.IdCliente = 1;
                comp.IdCine = 1;
                comp.FechaReserva = Convert.ToDateTime(dgvComprobanteAdmin.CurrentRow.Cells[4].Value.ToString());
                comp.IdFormaCompra = 1;
                comp.IdTipoDescuento = 1;
                await BajaComprobante(comp);
                Inicializar();
                dgvComprobanteAdmin.Rows.Clear();
                compList = await CargarDGV();
            }
        }

        private async Task BajaComprobante(Comprobantes c)
        {
            string comprobanteJson = JsonConvert.SerializeObject(c);
            string url = "https://localhost:7028/Eliminar_Comprobante";
            var data = await ClientSingleton.GetInstance().PutAsync(url, comprobanteJson);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvComprobanteAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
        }
    }
}

