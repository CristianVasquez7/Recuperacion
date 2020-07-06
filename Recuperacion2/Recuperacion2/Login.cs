using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperacion2
{
    //https://www.youtube.com/watch?v=en_eqatpDEo este seria basicamente como hice el diseño del login
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text=="USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Silver; 
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text=="")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;

            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ventana5 = new Form1();

            ventana5.Show();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "Cristian" && txtpass.Text == "d117")
            {
                this.Hide();
                Listado ventana7 = new Listado();

                    ventana7.Show();
            }
            else

            {
                MessageBox.Show("Error en el usuario y contraseña...!!Intente nuevamente!!...");
                    txtuser.Text = "";
                txtpass.Text = "";


            }

        }
    }
}
