using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES
{
    public sealed partial class FrmLogin : Form
    {
        public DataTable Datos;
        public bool adm = false;
        E_Login objEntidad = new E_Login();
        N_Login objNegocio = new N_Login();
        public static FrmLogin Instancia { get; } = new FrmLogin();
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.Text != "" && TxtUsuario.Text != "")
            {
                Datos = objNegocio.Ingresando(TxtUsuario.Text, TxtContraseña.Text);

                if (Datos.Rows.Count == 1)
                {

                    if (Datos.Rows[0][2].ToString() == "ADMINISTRADOR")
                    {
                        adm = true;
                    }
                    else if (Datos.Rows[0][2].ToString() == "GENERA")
                    {
                        adm = false;
                    }

                    TxtUsuario.Text = "";
                    TxtContraseña.Text = "";

                    this.Hide();
                    FrmRegistroE frmRegistroE = new FrmRegistroE(adm);
                    frmRegistroE.Show();

                    adm = false;

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }

            }
            else if (TxtContraseña.Text == "" || TxtUsuario.Text == "")
            {
                MessageBox.Show("Debe rellenar ambos campos");
            }
        }
    }
}
