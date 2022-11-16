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
    public partial class SalaButaca : Form
    {
        public SalaButaca()
        {
            InitializeComponent();
        }
        
        public void HabilitarBotones(bool x)
        {
            btnGuardar.Enabled = !x;
            btnEditar.Enabled = x;
            btnEliminar.Enabled = x;
            btnAgregar.Enabled = x;
        }

        public void Limpiar()
        {
            cboCine.SelectedIndex = -1;
            txtSala.Text = String.Empty;
            cboTipoSala.SelectedIndex = -1;
            txtFilas.Text = String.Empty;
            txtPrecioButaca.Text = String.Empty;
            txtButacasXFila.Text = String.Empty;
        }

        private void SalaButaca_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            CargarCombos();
        }

        private void CargarCombos()
        {
        }

        private void Validar()
        {
            if(cboCine.SelectedIndex == -1 || txtSala.Text == String.Empty || cboTipoSala.SelectedIndex == -1 ||
            txtFilas.Text == String.Empty || txtPrecioButaca.Text == String.Empty ||
            txtButacasXFila.Text == String.Empty)
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Validar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true);
            Limpiar();
            Validar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar la sala: ______?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
