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
    public partial class Persona : Form
    {
        public string tipo;
        public string accion;
        public Persona()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            cboCustom.SelectedIndex = -1;
            //dtpFechaIng.fecha = hoy;
            cboTipoDoc.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
            txtTelefono.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cboCondIVA.SelectedIndex = -1;
            txtNroDoc.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAltura.Text = string.Empty;
            rbSocio.Checked = false;
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            if (tipo == "Cliente")
            {
                this.Text = "Cargar " + tipo;
                lblTitulo.Text = "Cargar " + tipo;
                lblApellido.Visible = false;
                txtApellido.Visible = false;
                lblCustom.Text = "Tipo Cli:";
                dtpFechaIng.Visible = false;
                btnGuardar.Visible = false; // Boton Guardar
                if (accion == "editar")
                {
                    btnAgregar.Visible = false;
                    btnGuardar.Visible = true;
                    lblTitulo.Text = "Editar " + tipo;
                    this.Text = "Editar " + tipo;
                }
            }
            else
            {
                this.Text = "Cargar " + tipo;
                lblTitulo.Text = "Cargar " + tipo;
                lblCustom.Text = "Ingreso: ";
                lblCondIVA.Visible = false;
                cboCondIVA.Visible = false;
                rbSocio.Visible = false;
                cboCustom.Visible = false;
                btnGuardar.Visible = false; // Boton Guardar
                if (accion == "editar")
                {
                    btnAgregar.Visible = false;
                    btnGuardar.Visible = true;
                    lblTitulo.Text = "Editar " + tipo;
                    this.Text = "Editar " + tipo;
                }
            }
            CargarCombos();
        }

        private void CargarCombos()
        {
        }

        private void Validar(string tipo)
        {
            if (tipo == "cliente")
            {
                if (txtNombre.Text == string.Empty || cboCustom.SelectedIndex == -1 ||
                   cboTipoDoc.SelectedIndex == -1 || cboBarrio.SelectedIndex == -1 ||
                   txtTelefono.Text == string.Empty || cboCondIVA.SelectedIndex == -1 ||
                   txtNroDoc.Text == string.Empty || txtCalle.Text == string.Empty ||
                   txtAltura.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            if (tipo == "vendedor")
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty ||
                    cboTipoDoc.SelectedIndex == -1 || cboBarrio.SelectedIndex == -1 ||
                    txtTelefono.Text == string.Empty || cboCondIVA.SelectedIndex == -1 ||
                    txtNroDoc.Text == string.Empty || txtCalle.Text == string.Empty ||
                    txtAltura.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea agregar al cliente: ______?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            Limpiar();
            Validar("cliente");
            Validar("vendedore");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea actualizar al cliente: ______?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            Limpiar();
            Validar("cliente");
            Validar("vendedore");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
