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
    public partial class FuncionXPeli : Form
    {
        public FuncionXPeli()
        {
            InitializeComponent();
        }

        private void FuncionXPeli_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
        }

        private void Limpiar()
        {
            //dtpFecha.fecha = hoy;
            cboFuncion.SelectedIndex = -1;
            cboPelicula.SelectedIndex = -1;
        }

        private void Validar()
        {
            if (cboFuncion.SelectedIndex == -1 || cboPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Validar();
        }
    }
}
