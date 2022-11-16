using ComplejoDeCines.HTTP;
using DataApi.Dominio;
using DataApi.Dominios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplejoDeCines.Presentacion
{
    public partial class Comprobante : Form
    {
        public string accion;
        public Comprobantes comp;
        public Comprobantes compE = new Comprobantes();
        public int auxDet;
        public int posicion;
        public int indexDGV;
        public comprobanteString compS = new comprobanteString();

        public Comprobante(comprobanteString compS, Comprobantes compE)
        {
            InitializeComponent();
            comp = new Comprobantes();
            auxDet = 1;
            posicion = 0;
            indexDGV = 0;
            this.compS = compS;
            this.compE = compE;
        }
        public Comprobante()
        {
            InitializeComponent();
            comp = new Comprobantes();
            auxDet = 1;
            posicion = 0;
            indexDGV = 0;
        }
        private async void Comprobante1_Load(object sender, EventArgs e)
        {
            this.Text = "Cargar Comprobante";
            btnGuardar.Visible = false;
            btnAceptar.Visible = false;
            btnEditar.Visible = false;
            dtpFecha.Enabled = false;
            dgvComprobante.DefaultCellStyle.ForeColor = Color.Black;
            await CargarComboAsync("clientes", "a", cboCliente);
            await CargarComboAsync("vendedores", "a", cboVendedor);
            await CargarComboAsync("cines", "a", cboCine);
            await CargarComboAsync("formas_de_compras", "a", cboFormaCompra);
            await CargarComboAsync("descuento", "a", cboDescuento);
            Limpiar();
            if (accion == "editar")
            {
                this.Text = "Editar Comprobante N° " + compE.IdComprobante.ToString(accion);
                btnGuardar.Visible = false;
                btnAgregar.Visible = false;
                btnAceptar.Visible = true;
                btnEditar.Visible = true;
                MostrarDetalleComprobante(false, 1);
                MostrarDetalleComprobante(false, 2);
                CargarCombosEditar(compS);
                await ConsultarDetalleDeCombo(compS);
            }
            else
            {
                MostrarDetalleComprobante(false, 1);
                MostrarDetalleComprobante(false, 2);
            }
        }

        private async Task ConsultarDetalleDeCombo(comprobanteString compS)
        {
            //LLenar DGV
            int idComprobante = compS.IdComprobante;
            string idComp = JsonConvert.SerializeObject(idComprobante);
            string url = "https://localhost:7028/Consultar_Detalles_Comprobante?idComprobante=" + idComprobante.ToString();
            var data = await ClientSingleton.GetInstance().PostAsync(url, idComp);
            List<DetallesComprobanteString> detList = JsonConvert.DeserializeObject<List<DetallesComprobanteString>>(data);

            foreach (DetallesComprobanteString d in detList)
            {
                dgvComprobante.Rows.Add(new object[] { d.IdDetalle, d.Pelicula, d.Funcion, d.Sala, d.Butaca, d.Precio });
            }
            //Crear Lista con ID
            int idComproE = compE.IdComprobante;
            string idCompE = JsonConvert.SerializeObject(idComproE);
            string urlE = "https://localhost:7028/Consultar_Detalles_Comprobante_Ids?idComprobante=" + idCompE.ToString();
            var dataE = await ClientSingleton.GetInstance().PostAsync(urlE, idCompE);
            List<DetallesComprobante> detListE = JsonConvert.DeserializeObject<List<DetallesComprobante>>(dataE);
            foreach (DetallesComprobante d in detListE)
            {
                DetallesComprobante dE = new DetallesComprobante();
                dE.IdDetalleComprobante = d.IdDetalleComprobante;
                dE.IdPelicula = d.IdPelicula;
                dE.IdFuncion = d.IdFuncion;
                dE.IdSala = d.IdSala;
                dE.IdButaca = d.IdButaca;
                dE.Cantidad = d.Cantidad;
                dE.Precio = d.Precio;
                compE.AgregarDetalle(dE);
            }
        }

        private void CargarCombosEditar(comprobanteString compS)
        {
            cboVendedor.SelectedValue = compE.IdVendedor;
            cboCliente.SelectedValue = compE.IdCliente;
            cboCine.SelectedValue = compE.IdCine;
            dtpFecha.Value = compE.FechaReserva;
            cboFormaCompra.SelectedValue = compE.IdFormaCompra;
            cboDescuento.SelectedValue = compE.IdTipoDescuento;
        }
        //Metodos Habilitar y Mostrar
        public void HabilitarBotones(bool x)
        {
            btnAgregar.Visible = x;
            btnEliminar.Visible = x;
            btnGuardar.Visible = !x;
            btnEditar.Visible = x;
            btnAceptar.Visible = x;
        }
        public void Limpiar()
        {
            cboVendedor.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboCine.SelectedIndex = -1;
            cboFormaCompra.SelectedIndex = -1;
            cboDescuento.SelectedIndex = -1;
            cboPelicula.SelectedIndex = -1;
            cboFuncion.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            cboButaca.SelectedIndex = -1;
            txtxPrecio.Text = String.Empty;
        }
        private void LimpiarDetalle(bool x)
        {
            cboVendedor.Enabled = !x;
            cboCliente.Enabled = !x;
            cboCine.Enabled = !x;
            cboFormaCompra.Enabled = !x;
            cboDescuento.Enabled = !x;
            cboPelicula.SelectedIndex = -1;
            cboFuncion.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            cboButaca.SelectedIndex = -1;
            txtxPrecio.Text = String.Empty;

        }
        private void MostrarDetalleComprobante(bool x, int etapa)
        {
            if (etapa == 1)
            {
                lblPelicula.Visible = x;
                cboPelicula.Visible = x;
            }
            else if (etapa == 2)
            {
                lblFuncion.Visible = x;
                lblSala.Visible = x;
                lblButaca.Visible = x;
                lblPrecio.Visible = x;
                cboFuncion.Visible = x;
                cboSala.Visible = x;
                cboButaca.Visible = x;
                txtxPrecio.Visible = x;
            }
        }
        //Cargar Combos
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
        private async Task CargarPrecioAsync(string nombreTabla, string referencia)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros(1, nombreTabla));
            lst.Add(new Parametros(2, referencia));
            string valoresCombo = JsonConvert.SerializeObject(lst);
            string url = "https://localhost:7028/Comprobante?nombreTabla=" + nombreTabla + "&referencia=" + referencia;
            var data = await ClientSingleton.GetInstance().PostAsync(url, valoresCombo);
            List<Parametros> combo = JsonConvert.DeserializeObject<List<Parametros>>(data);
            foreach (Parametros p in combo)
            {
                txtxPrecio.Text = p.Precio.ToString();
            }


        }
        private async void cboCine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCine.SelectedIndex != -1)
            {
                await CargarPeliculas();
                cboPelicula.SelectedIndex = -1;
                cboFuncion.SelectedIndex = -1;
                cboSala.SelectedIndex = -1;
                cboButaca.SelectedIndex = -1;
                txtxPrecio.Text = "";
                MostrarDetalleComprobante(true, 1);
            }
        }
        private async Task CargarPeliculas()
        {
            cboPelicula.Visible = true;
            lblPelicula.Visible = true;
            await CargarComboAsync("peliculas", "a", cboPelicula);

        }
        private async void cboPelicula_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedIndex != -1)
            {
                await CargarFunciones(cboPelicula.SelectedValue.ToString());
                cboFuncion.SelectedIndex = -1;
                cboSala.SelectedIndex = -1;
                cboButaca.SelectedIndex = -1;
                txtxPrecio.Text = "";
                MostrarDetalleComprobante(true, 2);
            }

        }
        private async Task CargarFunciones(string referencia)
        {
            cboFuncion.Visible = true;
            await CargarComboAsync("funciones", referencia, cboFuncion);
        }
        private async void cboFuncion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboFuncion.SelectedIndex != -1)
            {
                await CargarSalas(cboCine.SelectedValue.ToString());
                cboSala.SelectedIndex = -1;
                cboButaca.SelectedIndex = -1;
                txtxPrecio.Text = "";
            }
        }
        private async Task CargarSalas(string referencia)
        {
            cboSala.Visible = true;
            await CargarComboAsync("salas", referencia, cboSala);
        }
        private async void cboSala_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboFuncion.SelectedIndex != -1)
            {
                await CargarButaca(cboSala.SelectedValue.ToString());
                await CargarPrecio(cboSala.SelectedValue.ToString());
                cboButaca.SelectedIndex = -1;
            }
        }
        private async Task CargarButaca(string referencia)
        {
            cboSala.Visible = true;
            await CargarComboAsync("butacas", referencia, cboButaca);
        }
        private async Task CargarPrecio(string idSala)
        {
            await CargarPrecioAsync("precio", idSala);
        }
        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboVendedor.SelectedIndex == -1 || cboCliente.SelectedIndex == -1 ||
                cboCine.SelectedIndex == -1 || cboFormaCompra.SelectedIndex == -1 ||
                cboDescuento.SelectedIndex == -1 || cboPelicula.SelectedIndex == -1 ||
                cboFuncion.SelectedIndex == -1 || cboSala.SelectedIndex == -1 ||
                cboButaca.SelectedIndex == -1 || string.IsNullOrEmpty(txtxPrecio.Text))
            {
                MessageBox.Show("Falta ingresar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( Existe()==false )
            {
                DetallesComprobante det = new DetallesComprobante();
                det.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
                det.IdFuncion = Convert.ToInt32(cboFuncion.SelectedValue);
                det.IdSala = Convert.ToInt32(cboSala.SelectedValue);
                det.Cantidad = 1;
                det.IdButaca = Convert.ToInt32(cboButaca.SelectedValue);
                det.Precio = double.Parse(txtxPrecio.Text);
                det.IdDetalleComprobante = auxDet;
                comp.AgregarDetalle(det);
                dgvComprobante.Rows.Add(new object[] { det.IdDetalleComprobante, cboPelicula.Text, cboFuncion.Text, cboSala.Text, cboButaca.Text, txtxPrecio.Text });
                LimpiarDetalle(true);
                auxDet += 1;
                btnAceptar.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                cboPelicula.Focus();
            }
        }

        private bool Existe()
        {
            bool aux = false;
            foreach(DataGridViewRow r in dgvComprobante.Rows)
            {
                if (cboSala.Text == dgvComprobante.CurrentRow.Cells[3].Value.ToString() && cboButaca.Text == dgvComprobante.CurrentRow.Cells[4].Value.ToString()&&
                    cboPelicula.Text == dgvComprobante.CurrentRow.Cells[1].Value.ToString() && cboFuncion.Text == dgvComprobante.CurrentRow.Cells[2].Value.ToString())
                {
                    MessageBox.Show("Butaca ocupada, seleccione otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    aux = true;
                    break;
                }

            }
            return aux;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (accion == "editar")
            {
                HabilitarBotones(false);
                LimpiarDetalle(true);
                await CargarPeliculas();
                posicion = Convert.ToInt32(dgvComprobante.CurrentRow.Cells[0].Value.ToString());
                indexDGV = dgvComprobante.CurrentRow.Index;
                cboPelicula.SelectedIndex = -1;
            }
            else
            {
                HabilitarBotones(false);
                cboPelicula.Text = dgvComprobante.CurrentRow.Cells[1].Value.ToString();
                cboFuncion.Text = dgvComprobante.CurrentRow.Cells[2].Value.ToString();
                cboSala.Text = dgvComprobante.CurrentRow.Cells[3].Value.ToString();
                cboButaca.Text = dgvComprobante.CurrentRow.Cells[4].Value.ToString();
                txtxPrecio.Text = dgvComprobante.CurrentRow.Cells[5].Value.ToString();
                posicion = Convert.ToInt32(dgvComprobante.CurrentRow.Cells[0].Value.ToString());
                indexDGV = dgvComprobante.CurrentRow.Index;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedIndex == -1 || cboFuncion.SelectedIndex == -1 || cboSala.SelectedIndex == -1 ||
                cboButaca.SelectedIndex == -1)
            {
                DialogResult dr = MessageBox.Show("Debe ingresar datos en todos los campos.", "Error", MessageBoxButtons.OK);
            }
            else if (Existe() == false)
            {
                if (accion == "editar")
                {
                    HabilitarBotones(true);
                    DetallesComprobante det = new DetallesComprobante();
                    det.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
                    det.IdFuncion = Convert.ToInt32(cboFuncion.SelectedValue);
                    det.IdSala = Convert.ToInt32(cboSala.SelectedValue);
                    det.Cantidad = 1;
                    det.IdButaca = Convert.ToInt32(cboButaca.SelectedValue);
                    det.Precio = double.Parse(txtxPrecio.Text);
                    det.IdDetalleComprobante = posicion;
                    compE.EditarDetalle(det);
                    dgvComprobante[1, indexDGV].Value = cboPelicula.Text;
                    dgvComprobante[2, indexDGV].Value = cboFuncion.Text;
                    dgvComprobante[3, indexDGV].Value = cboSala.Text;
                    dgvComprobante[4, indexDGV].Value = cboButaca.Text;
                    dgvComprobante[5, indexDGV].Value = txtxPrecio.Text;
                    LimpiarDetalle(true);
                }
                else
                {

                    HabilitarBotones(true);
                    DetallesComprobante det = new DetallesComprobante();
                    det.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
                    det.IdFuncion = Convert.ToInt32(cboFuncion.SelectedValue);
                    det.IdSala = Convert.ToInt32(cboSala.SelectedValue);
                    det.Cantidad = 1;
                    det.IdButaca = Convert.ToInt32(cboButaca.SelectedValue);
                    det.Precio = double.Parse(txtxPrecio.Text);
                    det.IdDetalleComprobante = posicion;
                    comp.EditarDetalle(det);
                    dgvComprobante[1, indexDGV].Value = cboPelicula.Text;
                    dgvComprobante[2, indexDGV].Value = cboFuncion.Text;
                    dgvComprobante[3, indexDGV].Value = cboSala.Text;
                    dgvComprobante[4, indexDGV].Value = cboButaca.Text;
                    dgvComprobante[5, indexDGV].Value = txtxPrecio.Text;
                    LimpiarDetalle(true);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminarlo?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                if (accion == "editar")
                {
                    compE.QuitarDetalle(Convert.ToInt32(dgvComprobante.CurrentRow.Index));
                    dgvComprobante.Rows.Remove(dgvComprobante.CurrentRow);
                }
                else
                {
                    comp.QuitarDetalle(Convert.ToInt32(dgvComprobante.CurrentRow.Index));
                    dgvComprobante.Rows.Remove(dgvComprobante.CurrentRow);
                }
            }
            LimpiarDetalle(true);
            if(accion == "editar")
            {
                if (dgvComprobante.Rows.Count == 0)
                {
                    btnAceptar.Visible = false;
                    btnEditar.Visible = false;                    
                }
            }
            else
            {
                if (dgvComprobante.Rows.Count == 0)
                {
                    Limpiar();
                    LimpiarDetalle(false);
                    btnAceptar.Visible = false;
                    btnEditar.Visible = false;
                    cboPelicula.Visible = false;
                    cboFuncion.Visible = false;
                    cboSala.Visible = false;
                    cboButaca.Visible = false;
                    txtxPrecio.Visible = false;
                    lblPelicula.Visible = false;
                    lblFuncion.Visible = false;
                    lblSala.Visible = false;
                    lblButaca.Visible = false;
                    lblPrecio.Visible = false;
                }
            }
        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if( accion == "editar")
            {
                DialogResult dr = MessageBox.Show("Desea guardar definitivamente el comprobante: " + compE.IdComprobante.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo);
                compE.IdComprobante = compE.IdComprobante;
                compE.IdVendedor = Convert.ToInt32(cboVendedor.SelectedValue.ToString());
                compE.IdCliente = Convert.ToInt32(cboCliente.SelectedValue.ToString());
                compE.IdCine = Convert.ToInt32(cboCine.SelectedValue.ToString());
                compE.FechaReserva = dtpFecha.Value;
                compE.IdFormaCompra = Convert.ToInt32(cboFormaCompra.SelectedValue.ToString());
                compE.IdTipoDescuento = Convert.ToInt32(cboDescuento.SelectedValue.ToString());
                compE.Baja = false;

                if (dr == DialogResult.Yes)
                {
                    await GuardarComprobanteEditado(compE);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo ejecutar la accion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desea guardar definitivamente el comprobante ?", "Confirmar", MessageBoxButtons.YesNo);
                comp.IdComprobante = 1;
                comp.IdVendedor = Convert.ToInt32(cboVendedor.SelectedValue.ToString());
                comp.IdCliente = Convert.ToInt32(cboCliente.SelectedValue.ToString());
                comp.IdCine = Convert.ToInt32(cboCine.SelectedValue.ToString());
                comp.FechaReserva = dtpFecha.Value;
                comp.IdFormaCompra = Convert.ToInt32(cboFormaCompra.SelectedValue.ToString());
                comp.IdTipoDescuento = Convert.ToInt32(cboDescuento.SelectedValue.ToString());
                comp.Baja = false;

                if (dr == DialogResult.Yes)
                {
                    await GuardarComprobante(comp);
                    Limpiar();
                    LimpiarDetalle(false);

                    btnAceptar.Visible = false;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    cboPelicula.Visible = false;
                    cboFuncion.Visible = false;
                    cboSala.Visible = false;
                    cboButaca.Visible = false;
                    txtxPrecio.Visible = false;
                    lblPelicula.Visible = false;
                    lblFuncion.Visible = false;
                    lblSala.Visible = false;
                    lblButaca.Visible = false;
                    lblPrecio.Visible = false;
                    dgvComprobante.Rows.Clear();

                }
                else
                {
                    MessageBox.Show("No se pudo ejecutar la accion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Limpiar();
            }            
        }
        private async Task GuardarComprobante(Comprobantes comp)
        {
            string comprobanteJson = JsonConvert.SerializeObject(comp);
            string url = "https://localhost:7028/Guardar_Comprobante";
            var data = await ClientSingleton.GetInstance().PostAsync(url, comprobanteJson);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async Task GuardarComprobanteEditado(Comprobantes compE)
        {
            string comprobanteJson = JsonConvert.SerializeObject(compE);
            string url = "https://localhost:7028/Editar_Comprobante";
            var data = await ClientSingleton.GetInstance().PutAsync(url, comprobanteJson);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}