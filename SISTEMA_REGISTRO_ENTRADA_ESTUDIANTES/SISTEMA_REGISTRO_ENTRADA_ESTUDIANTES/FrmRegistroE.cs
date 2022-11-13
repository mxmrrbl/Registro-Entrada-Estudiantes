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
    public partial class FrmRegistroE : Form
    {
        private string ID_E;
        private bool editando = false;
        E_Entrada objEntidad = new E_Entrada();
        N_Entrada objNegocio = new N_Entrada();
        public DataTable Datos;
        private bool adm = false;

        
        public FrmRegistroE(bool Adm)
        {
            InitializeComponent();
            this.adm = Adm;
            acciones();
            cargarCbxEdificios();
        }

        public void acciones()
        {
            if (this.adm == true)
            {
                BtnAulas.Visible = true;
                BtnEdificios.Visible = true;
                BtnUsuarios.Visible = true;

                LbLSesion.Text = "GESTION DE ENTRADAS - ADMINISTRADOR";
            }
            else if (this.adm == false)
            {
                BtnAulas.Visible = false;
                BtnEdificios.Visible = false;
                BtnUsuarios.Visible = false;

                LbLSesion.Text = "GESTION DE ENTRADAS - USUARIO GENERAL";
            }
        }

        private void FrmRegistroE_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Instancia.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void cargarCbxEdificios()
        {
            Datos = objNegocio.CargandoEdificios();

            CbxEdificio.ValueMember = "ID";
            CbxEdificio.DisplayMember = "NOMBRE";
            CbxEdificio.DataSource = Datos;
        }

        public void cargarCbxAulas()
        {
            int id_Edificio = Convert.ToInt32(CbxEdificio.SelectedValue.ToString());
            Datos = objNegocio.CargandoAulas(id_Edificio);

            CbxAula.ValueMember = "ID";
            CbxAula.DisplayMember = "CODIGO";
            CbxAula.DataSource = Datos;
        }

        private void CbxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCbxAulas();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Entrada n_Entrada = new N_Entrada();
            TblEntradas.DataSource = n_Entrada.ListandoEntrada(buscar);
        }

        private void FrmRegistroE_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(TxtBuscar.Text);
        }

        private void LimpiarTxtbx()
        {
            TxtMatricula.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtMotivo.Text = "";
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
                    objEntidad.Matricula = TxtMatricula.Text.ToUpper();
                    objEntidad.Nombre_Estudiante = TxtNombre.Text.ToUpper();
                    objEntidad.Apellido_Estudiante = TxtApellido.Text.ToUpper();
                    objEntidad.Edificio_Nombre = Convert.ToString(CbxEdificio.Text);
                    objEntidad.Aula_Codigo = Convert.ToString(CbxAula.Text);
                    objEntidad.Entrada = Convert.ToDateTime(DtpEntrada.Value);
                    objEntidad.Salida = Convert.ToDateTime(DtpSalida.Value);
                    objEntidad.Motivo = TxtMotivo.Text.ToUpper();


                    objNegocio.InsertandoEntrada(objEntidad);
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
                    objEntidad.ID_Entrada = Convert.ToInt32(ID_E);
                    objEntidad.Matricula = TxtMatricula.Text.ToUpper();
                    objEntidad.Nombre_Estudiante = TxtNombre.Text.ToUpper();
                    objEntidad.Apellido_Estudiante = TxtApellido.Text.ToUpper();
                    objEntidad.Edificio_Nombre = Convert.ToString(CbxEdificio.Text);
                    objEntidad.Aula_Codigo = Convert.ToString(CbxAula.Text);
                    objEntidad.Entrada = Convert.ToDateTime(DtpEntrada.Value);
                    objEntidad.Salida = Convert.ToDateTime(DtpSalida.Value);
                    objEntidad.Motivo = TxtMotivo.Text.ToUpper();

                    objNegocio.EditandoEntrada(objEntidad);
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
            if (TblEntradas.SelectedRows.Count > 0)
            {
                editando = true;

                ID_E = TblEntradas.CurrentRow.Cells[0].Value.ToString();
                TxtMatricula.Text = TblEntradas.CurrentRow.Cells[1].Value.ToString();
                TxtNombre.Text = TblEntradas.CurrentRow.Cells[2].Value.ToString();
                TxtApellido.Text = TblEntradas.CurrentRow.Cells[3].Value.ToString();
                TxtMotivo.Text = TblEntradas.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(TblEntradas.SelectedRows.Count > 0)
            {
                objEntidad.ID_Entrada = Convert.ToInt32(TblEntradas.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoEntrada(objEntidad);

                MessageBox.Show("Registro eliminado");
                mostrarBuscarTabla("");

            }
            else
            {
                MessageBox.Show("Selecciona una fila a eliminar");
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void BtnAulas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAula frmFrmAula = new FrmAula();
            frmFrmAula.Show();
        }

        private void BtnEdificios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEdificio frmEdificio = new FrmEdificio();
            frmEdificio.Show();
        }
    }
}
