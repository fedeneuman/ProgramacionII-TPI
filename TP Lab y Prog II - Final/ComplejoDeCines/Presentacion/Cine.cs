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
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }
        public string tipo;
        
        private void Cine_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            txtNombre.Focus();
            if (tipo == "empleado")
            {
                txtNombre.Enabled = false;
                txtCuit.Enabled = false;
                txtTelefono.Enabled = false;
                cboBarrio.Enabled = false;
                txtCiudad.Enabled = false;
                txtCalle.Enabled = false;
                txtAltura.Enabled = false;
                cboCondIVA.Enabled = false;
                txtIIBB.Enabled = false;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
            CargarCombo();
        }

        private void CargarCombo()
        {
        }

        private void Habilitar(bool x)
        {
            btnAgregar.Enabled = x;
            btnEditar.Enabled = x;
            btnEliminar.Enabled = x;
            btnGuardar.Enabled = !x;
        }
        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
            txtCuit.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            cboBarrio.SelectedIndex = -1;
            txtCiudad.Text = String.Empty;
            txtCalle.Text = String.Empty;
            txtAltura.Text = String.Empty;
            cboCondIVA.SelectedIndex = -1;
            txtIIBB.Text = String.Empty;
        }

        private void Validar()
        {
            if (txtNombre.Text == String.Empty || txtCuit.Text == String.Empty || txtTelefono.Text == String.Empty ||
            cboBarrio.SelectedIndex == -1 || txtCiudad.Text == String.Empty || txtCalle.Text == String.Empty ||
            txtAltura.Text == String.Empty || cboCondIVA.SelectedIndex == -1 || txtIIBB.Text == String.Empty)
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNombre.Focus();
            Validar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(true);
            txtNombre.Focus();
            Validar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            txtNombre.Focus();
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

