using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateSintepartSRL
{
    public partial class frmSintepart : Form
    {
        int intentos = 0;

        public frmSintepart()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnAceptar_Click(object sender, EventArgs e)
        {
            frmBienvenida frmBienvenida = new frmBienvenida();

            if (txtUsuario.Text == "adm" && txtContraseña.Text == "@1a")
            {
                if (cmbModulo.Text == "ADM" || cmbModulo.Text == "COM" || cmbModulo.Text == "VTA")
                {
                    this.Hide();
                    frmBienvenida.Show();
                }
                else
                {
                    MessageBox.Show("No tiene acceso a este módulo");
                }
            }
            else if (txtUsuario.Text == "John" && txtContraseña.Text == "*2b")
            {
                if (cmbModulo.Text == "SIST")
                {
                    this.Hide();
                    frmBienvenida.Show();
                }
                else
                {
                    MessageBox.Show("No tiene acceso a este módulo");
                }
            }
            else if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "@3c")
            {
                if (cmbModulo.Text == "ADM" || cmbModulo.Text == "VTA")
                {
                    this.Hide();
                    frmBienvenida.Show();
                }
                else
                {
                    MessageBox.Show("No tiene acceso a este módulo");
                }
            }
            else if (txtUsuario.Text == "God" && txtContraseña.Text == "@#4d")
            {
                this.Hide();
                frmBienvenida.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                intentos++;
                if (intentos >= 2)
                {
                    Application.Exit();
                }

            }
        }
    }
}
