using ComplejoDeCines.HTTP;
using DataApi.Dominio;
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
    public partial class Login : Form
    {
        // auxiliar para activar la funcion ver de la contrasenia.
        bool auxVer = true;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void LevantarHome(string tipo)
        {
            this.Hide();

            Home frm = new Home();
            frm.tipo = tipo;
            frm.ShowDialog();

            this.Show();
            txtUser.Focus();
            Limpiar();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await ConsultarLogin(txtUser.Text, txtPass.Text);
        }

        private async Task ConsultarLogin(string usuario, string contraseña)
        {
            Usuarios user = new Usuarios(usuario, contraseña, "a");
            string datosUsuario = JsonConvert.SerializeObject(user);
            string url = "https://localhost:7028/Usuario";
            var data = await ClientSingleton.GetInstance().PostAsync(url, datosUsuario);
            List<Usuarios> datosLst = JsonConvert.DeserializeObject<List<Usuarios>>(data);

            // abre una pantalla u otra (Gerente/Empleado/Admin)
            if (datosLst == null)
            {
                MessageBox.Show("Usuario o contraseña incorrecta!", "Error", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                foreach (Usuarios u in datosLst)
                {
                    if (u.Jerarquia == "gerente")
                    {
                        LevantarHome("gerente");
                    }
                    else if (u.Jerarquia == "empleado")
                    {
                        LevantarHome("empleado");
                    }
                    else if (u.Jerarquia == "admin")
                    {
                        LevantarHome("admin");
                    }
                }
            }




        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {

            if (auxVer)
            {
                txtPass.UseSystemPasswordChar = false;
                auxVer = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                auxVer = true;
            }
        }

        public void Limpiar()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
            auxVer = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
