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
    public partial class CargaVarios : Form
    {
        public string tipo;
        public Usuarios usuario;
        public List<Usuarios> uList;
        public CargaVarios()
        {
            InitializeComponent();
            usuario = new Usuarios();
            uList = new List<Usuarios>();
        }

        public void Limpiar()
        {
            txtSubtitulo1.Text = String.Empty;
            cboSubtitulo2.SelectedIndex = -1;
            txtSubtitulo3.Text = String.Empty;
            txtSubtitulo4.Text = String.Empty;
        }

        private async void CargaVarios_Load(object sender, EventArgs e)
        {
            // Set titulos
            if (tipo == "Tipos de documento" || tipo == "Tipos de cliente" || tipo == "Condicion IVA" ||
                tipo == "Formas de pago" || tipo == "Formas de compra" || tipo == "Tipos de sala" ||
                tipo == "Generos de pelicula" || tipo == "Clasificacion de edades")
            {
                this.Text = tipo;
                lblTitulo.Text = "Cargar " + tipo;
                lblTitulo2.Text = "Administrar " + tipo;
            }
            else if (tipo == "Ciudad" || tipo == "Funcion")
            {
                this.Text = tipo + "es";
                lblTitulo.Text = "Cargar " + tipo + "es";
                lblTitulo2.Text = "Administrar " + tipo + "es";
            }
            else
            {
                this.Text = tipo + "s";
                lblTitulo.Text = "Cargar " + tipo + "s";
                lblTitulo2.Text = "Administrar " + tipo + "s";
            }

            // Habilito-Deshabilito Componentes
            if (tipo == "Ciudad")
            {
                lblSubtitulo3.Visible = false;
                lblSubtitulo1.Text = tipo;
                lblSubtitulo2.Text = "Provincia";
                txtSubtitulo3.Visible = false;
                dtpFuncion.Visible = false;
                lblSubtitulo4.Visible = false;
                txtSubtitulo4.Visible = false;
                await CargarCombo(lblSubtitulo2.Text + "s", "a", cboSubtitulo2);
                cboHora.Visible = false;
            }
            else if (tipo == "Barrio")
            {
                lblSubtitulo1.Text = tipo;
                lblSubtitulo2.Text = "Ciudad";
                lblSubtitulo3.Text = "Provincia";
                txtSubtitulo3.Enabled = false;
                dtpFuncion.Visible = false;
                lblSubtitulo4.Visible = false;
                txtSubtitulo4.Visible = false;
                await CargarCombo(lblSubtitulo2.Text + "es", "a", cboSubtitulo2);
                cboHora.Visible = false;

            }
            else if (tipo == "Funcion")
            {
                lblSubtitulo1.Text = "Fecha " + tipo;
                txtSubtitulo1.Visible = false;
                lblSubtitulo2.Visible = false;
                cboSubtitulo2.Visible = false;
                lblSubtitulo3.Text = "Hora " + tipo;
                lblSubtitulo4.Visible = false;
                txtSubtitulo4.Visible = false;
                await CargarCombo("funciones", "a", cboHora);
            }
            else if (tipo == "Usuario")
            {
                lblSubtitulo1.Text = tipo;
                lblSubtitulo2.Text = "Alcance";
                lblSubtitulo3.Visible = false;
                txtSubtitulo3.Visible = false;
                dtpFuncion.Visible = false;
                lblSubtitulo4.Text = "Contraseña";
                cboHora.Visible = false;
                uList = await CargarDGV();
                btnGuardar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
            else
            {
                lblSubtitulo1.Text = tipo;
                cboSubtitulo2.Visible = false;
                lblSubtitulo2.Visible = false;
                lblSubtitulo3.Visible = false;
                txtSubtitulo3.Visible = false;
                dtpFuncion.Visible = false;
                lblSubtitulo4.Visible = false;
                txtSubtitulo4.Visible = false;
                cboHora.Visible = false;
            }
            Limpiar();

        }

        private void Inicializar()
        {
            usuario = new Usuarios();
            uList = new List<Usuarios>();
        }


        private async Task<List<Usuarios>> CargarDGV()
        {
            //Cargar DGV
            string url = "https://localhost:7028/Consultar_Usuario";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<Usuarios> uList = JsonConvert.DeserializeObject<List<Usuarios>>(data);

            foreach (Usuarios u in uList)
            {
                dgvCargarVarios.Rows.Add(new object[] { u.Usuario, u.Contraseña, u.Jerarquia });
            }
            return uList;
        }

        private bool ValidarUsuarios()
        {
            bool aux = false;
            if (string.IsNullOrEmpty(txtSubtitulo1.Text) || cboSubtitulo2.SelectedIndex == -1 || string.IsNullOrEmpty(txtSubtitulo4.Text))
            {
                MessageBox.Show("Debe ingresar datos en todos los campos.", "Error", MessageBoxButtons.OK);
                aux = true;
            }
            else
            {
                foreach (Usuarios u in uList)
                {
                    if (u.Usuario == txtSubtitulo1.Text)
                    {
                        MessageBox.Show("El usuario ya existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = true;
                        Limpiar();
                        break;
                    }

                }

                txtSubtitulo1.Focus();
            }

            return aux;
        }

        private async Task CargarCombo(string nombreTabla, string referencia, ComboBox cbo)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros(1, nombreTabla));
            lst.Add(new Parametros(2, referencia));
            string valoresCombo = JsonConvert.SerializeObject(lst);
            string url = "https://localhost:7028/CargaVarios?nombreTabla=" + nombreTabla + "&referencia=" + referencia;
            var data = await ClientSingleton.GetInstance().PostAsync(url, valoresCombo);
            List<Parametros> combo = JsonConvert.DeserializeObject<List<Parametros>>(data);
            cbo.DataSource = combo;
            cbo.ValueMember = "Codigo";
            cbo.DisplayMember = "Valor";
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {

            if (ValidarUsuarios() == false)
            {
                usuario.Usuario = txtSubtitulo1.Text;
                usuario.Contraseña = txtSubtitulo4.Text;
                usuario.Jerarquia = cboSubtitulo2.Text;
                string Json = JsonConvert.SerializeObject(usuario);
                string url = "https://localhost:7028/Insertar_Usuario";
                var data = await ClientSingleton.GetInstance().PostAsync(url, Json);
                MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();

                txtSubtitulo1.Focus();
                dgvCargarVarios.Rows.Clear();
                await CargarDGV();
                Inicializar();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtSubtitulo1.Text = dgvCargarVarios.CurrentRow.Cells[0].Value.ToString();
            txtSubtitulo4.Text = dgvCargarVarios.CurrentRow.Cells[1].Value.ToString();
            cboSubtitulo2.Text = dgvCargarVarios.CurrentRow.Cells[2].Value.ToString();
            txtSubtitulo1.Enabled = false;
            btnCargar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = false;
            btnGuardar.Visible = true;
            txtSubtitulo1.Focus();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar al usuario '" + dgvCargarVarios.CurrentRow.Cells[0].Value.ToString() + "'?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Usuarios u = new Usuarios();
                u.Usuario = dgvCargarVarios.CurrentRow.Cells[0].Value.ToString();
                u.Contraseña = dgvCargarVarios.CurrentRow.Cells[1].Value.ToString();
                u.Jerarquia = dgvCargarVarios.CurrentRow.Cells[2].Value.ToString();

                await EliminarUsuario(u);
            }
            Limpiar();
            txtSubtitulo1.Focus();
            Inicializar();
        }

        private async Task EliminarUsuario(Usuarios u)
        {
            string Json = JsonConvert.SerializeObject(u);
            string url = "https://localhost:7028/Eliminar_Usuario";
            var data = await ClientSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCargarVarios.Rows.Clear();
            await CargarDGV();
            btnCargar.Visible = true;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void cboSubtitulo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (cboSubtitulo2.SelectedIndex != -1)
            {
                await ProvinciaXCiudad("Provincia", cboSubtitulo2.Text);
            }
            */

        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario.Usuario = txtSubtitulo1.Text;
            usuario.Contraseña = txtSubtitulo4.Text;
            usuario.Jerarquia = cboSubtitulo2.Text;
            await EditarUsuario(usuario);

            dgvCargarVarios.Rows.Clear();
            await CargarDGV();
            btnCargar.Visible = true;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = false;
            Inicializar();
            txtSubtitulo1.Enabled = true;
            txtSubtitulo1.Text = string.Empty;
            txtSubtitulo4.Text = string.Empty;
            cboSubtitulo2.SelectedIndex = -1;
        }

        private async Task EditarUsuario(Usuarios usuario)
        {
            string Json = JsonConvert.SerializeObject(usuario);
            string url = "https://localhost:7028/Editar_Usuario";
            var data = await ClientSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCargarVarios_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
            btnEditar.Visible = true;
        }
    }
}


