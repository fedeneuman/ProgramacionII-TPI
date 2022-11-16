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
    public partial class Pelicula : Form
    {
        public string tipo;
        public Pelicula()
        {
            InitializeComponent();
        }


        // Load
        private void Pelicula_Load(object sender, EventArgs e)
        {
            if (tipo == "empleado")
            {
                Habilitar(false);
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
            }
            else
            {
                txtNombre.Focus();
                btnGuardar.Enabled = false;
            }
            CargarCombos();
        }

        private void CargarCombos()
        {
        }

        // Funciones
        public void Habilitar(bool x)
        {
            txtNombre.Enabled = x;
            txtDuracion.Enabled = x;
            txtDescripcion.Enabled = x;
            cboGenero.Enabled = x;
            cboIdioma.Enabled = x;
            cboSubtitulo.Enabled = x;
            cboClasifEdades.Enabled = x;
        }
        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtDuracion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboSubtitulo.SelectedIndex = -1;
            cboClasifEdades.SelectedIndex = -1;
        }

        private void Validar()
        {
            if(txtNombre.Text == string.Empty || txtDuracion.Text == string.Empty || txtDescripcion.Text == string.Empty ||
            cboGenero.SelectedIndex == -1 || cboIdioma.SelectedIndex == -1 || cboSubtitulo.SelectedIndex == -1 ||
            cboClasifEdades.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK);
            }
        }

        // Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNombre.Focus();
            Validar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tipo == "gerente" || tipo == "admin")
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }
            Limpiar();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tipo == "gerente" || tipo == "admin")
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                Limpiar();
            }
            Limpiar();
            txtNombre.Focus();
            Validar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            Limpiar();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}