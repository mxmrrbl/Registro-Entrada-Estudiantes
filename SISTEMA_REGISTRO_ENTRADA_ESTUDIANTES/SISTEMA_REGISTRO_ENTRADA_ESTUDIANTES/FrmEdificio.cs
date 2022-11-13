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
    public partial class FrmEdificio : Form
    {
        private string ID_E;
        private bool editando = false;
        E_Edificio objEntidad = new E_Edificio();
        N_Edificio objNegocio = new N_Edificio();
        public FrmEdificio()
        {
            InitializeComponent();
        }

        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdificio_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmRegistroE frmRegistroE = new FrmRegistroE(true);
            frmRegistroE.Show();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Edificio n_Edificio = new N_Edificio();
            TblEdificio.DataSource = n_Edificio.ListandoEdificio(buscar);
        }

        private void FrmEdificio_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(TxtBuscar.Text);
        }

        private void LimpiarTxtbx()
        {
            TxtNombre.Text = "";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTxtbx();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (editando == false)
            {
                try
                {
                    objEntidad.Nombre_Edificio = TxtNombre.Text.ToUpper();


                    objNegocio.InsertandoEdificio(objEntidad);
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
                    objEntidad.ID_Edificio = Convert.ToInt32(ID_E);
                    objEntidad.Nombre_Edificio = TxtNombre.Text.ToUpper();


                    objNegocio.EditandoEdificio(objEntidad);
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
            if (TblEdificio.SelectedRows.Count > 0)
            {
                editando = true;

                ID_E = TblEdificio.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = TblEdificio.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TblEdificio.SelectedRows.Count > 0)
            {
                objEntidad.ID_Edificio = Convert.ToInt32(TblEdificio.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoEdificio(objEntidad);

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
