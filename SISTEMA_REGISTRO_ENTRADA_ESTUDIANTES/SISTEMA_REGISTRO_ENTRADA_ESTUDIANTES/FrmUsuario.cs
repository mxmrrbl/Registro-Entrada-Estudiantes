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
    public partial class FrmUsuario : Form
    {
        private string ID_U;
        private bool editando = false;
        E_Usuario objEntidad = new E_Usuario();
        N_Usuario objNegocio = new N_Usuario();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmRegistroE frmRegistroE = new FrmRegistroE(true);
            frmRegistroE.Show();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Usuario n_Usuario = new N_Usuario();
            TblUsuario.DataSource = n_Usuario.ListandoUsuario(buscar);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(TxtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTxtbx();
        }

        private void LimpiarTxtbx()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtContraseña.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (editando == false)
            {
                try
                {
                    objEntidad.Nombre_Usuario = TxtNombre.Text.ToUpper();
                    objEntidad.Apellido_Usuario = TxtApellido.Text.ToUpper();
                    objEntidad.Fecha_Nacimiento = Convert.ToDateTime(DtpFechaN.Value);
                    objEntidad.Contraseña = TxtContraseña.Text;
                    objEntidad.Tipo = Convert.ToString(CbxTipo.Text);

                    objNegocio.InsertandoUsuario(objEntidad);
                    MessageBox.Show("Registro guardado");
                    mostrarBuscarTabla("");
                    LimpiarTxtbx();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, registro no guardado" + ex);

                }

            }
            else
            {
                try
                {
                    objEntidad.ID_Usuario = Convert.ToInt32(ID_U);
                    objEntidad.Nombre_Usuario = TxtNombre.Text.ToUpper();
                    objEntidad.Apellido_Usuario = TxtApellido.Text.ToUpper();
                    objEntidad.Fecha_Nacimiento = Convert.ToDateTime(DtpFechaN.Value);
                    objEntidad.Contraseña = TxtContraseña.Text;
                    objEntidad.Tipo = Convert.ToString(CbxTipo.Text);

                    objNegocio.EditandoUsuario(objEntidad);
                    MessageBox.Show("Registro guardado");
                    mostrarBuscarTabla("");
                    LimpiarTxtbx();

                    editando = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, registro no editado" + ex);

                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (TblUsuario.SelectedRows.Count > 0)
            {
                editando = true;

                ID_U = TblUsuario.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = TblUsuario.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = TblUsuario.CurrentRow.Cells[2].Value.ToString();
                TxtContraseña.Text = TblUsuario.CurrentRow.Cells[5].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TblUsuario.SelectedRows.Count > 0)
            {
                objEntidad.ID_Usuario = Convert.ToInt32(TblUsuario.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoUsuario(objEntidad);

                MessageBox.Show("Registro eliminado");
                mostrarBuscarTabla("");

            }
            else
            {
                MessageBox.Show("Selecciona una fila a eliminar");
            }
        }
    }
}
