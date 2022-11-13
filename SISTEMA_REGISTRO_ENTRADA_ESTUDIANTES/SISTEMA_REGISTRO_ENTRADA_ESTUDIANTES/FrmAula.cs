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
    public partial class FrmAula : Form
    {
        private string ID_A;
        private bool editando = false;
        E_Aula objEntidad = new E_Aula();
        N_Aula objNegocio = new N_Aula();
        public DataTable Datos;
        

        public FrmAula()
        {
            InitializeComponent();
            cargarCbxEdificios();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAula_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmRegistroE frmRegistroE = new FrmRegistroE(true);
            frmRegistroE.Show();
        }

        public void cargarCbxEdificios()
        {
            Datos = objNegocio.CargandoEdificios();

            CbxEdificio.ValueMember = "ID";
            CbxEdificio.DisplayMember = "NOMBRE";
            CbxEdificio.DataSource = Datos;
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Aula n_Aula = new N_Aula();
            TblAula.DataSource = n_Aula.ListandoAula(buscar);
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(TxtBuscar.Text);
        }

        private void LimpiarTxtbx()
        {
            TxtPiso.Text = "";
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
                    objEntidad.Edificio_ID = Convert.ToInt32(CbxEdificio.SelectedValue);
                    objEntidad.Piso_Aula = Convert.ToInt32(TxtPiso.Value);
                    objEntidad.Nombre_Aula = TxtNombre.Text.ToUpper();

                  

                    objNegocio.InsertandoAula(objEntidad);
                    MessageBox.Show("Registro guardado");
                    mostrarBuscarTabla("");
                    LimpiarTxtbx();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, registro no guardado: " + ex);

                }

            }
            else
            {
                try
                {
                    objEntidad.ID_Aula = Convert.ToInt32(ID_A);
                    objEntidad.Edificio_ID = Convert.ToInt32(CbxEdificio.SelectedValue);
                    objEntidad.Piso_Aula = Convert.ToInt32(TxtPiso.Text);
                    objEntidad.Nombre_Aula = TxtNombre.Text.ToUpper();


                    objNegocio.EditandoAula(objEntidad);
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
            if (TblAula.SelectedRows.Count > 0)
            {
                editando = true;

                ID_A = TblAula.CurrentRow.Cells[0].Value.ToString();
                TxtPiso.Text = TblAula.CurrentRow.Cells[2].Value.ToString();
                TxtNombre.Text = TblAula.CurrentRow.Cells[3].Value.ToString();
  
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TblAula.SelectedRows.Count > 0)
            {
                objEntidad.ID_Aula = Convert.ToInt32(TblAula.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoAula(objEntidad);

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
