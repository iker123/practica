using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmListadoUsuarios : Form
    {
        readonly E_Usuarios objEntidad = new E_Usuarios();
        readonly N_Usuarios objNegocio = new N_Usuarios();
        public FrmListadoUsuarios()
        {
            InitializeComponent();
        }
        #region MENSAJES --BIENVENIDA AND WELCOME
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Iver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region OCULTAR COLUMNAS INNECESARIAS
        public void AccionesTabla()
        {
            //Ocultar Llaves primarias y foraneas en el DgvCliente
            dgvUsuario.Columns[0].Visible = false;
            dgvUsuario.Columns[2].Visible = false;
            dgvUsuario.Columns[4].Visible = false;

            //MOSTRAR LOS NOMBRES DE LAS COLUMNAS EN EL dgv 
            dgvUsuario.Columns[1].HeaderText = "Usuario";
            dgvUsuario.Columns[3].HeaderText = "Acceso";
            dgvUsuario.Columns[5].HeaderText = "Profesional";
        }
        #endregion

        #region MOSTRAR REGISTRO EN EL dgv
        public void MostrarRegistro()
        {
            dgvUsuario.DataSource = N_Usuarios.MostrarRegistrosU();
            AccionesTabla();
        }
        #endregion
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
            dgvUsuario.ClearSelection();
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void btnNewUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios nuevoregistro = new FrmUsuarios();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();
            nuevoregistro.Dispose();
        }

        private void BtnEditUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios editarregistro = new FrmUsuarios();
            editarregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                editarregistro.txtCodigoU.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
                editarregistro.txtUsuario.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                editarregistro.txtContraseña.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                editarregistro.cbAcceso.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
                editarregistro.cbProfesional.SelectedValue = dgvUsuario.CurrentRow.Cells[4].Value.ToString();

                editarregistro.ShowDialog();
            }
            else
            {
                MensajeError("Seleccione la fila a Editar");
            }
            editarregistro.Dispose();
        }

        private void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("You Really Want to delete the Register", "Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    objEntidad.IdUsuarios = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarRegistro(objEntidad);

                    MensajeConfirmacion("Successfully removed");

                    MostrarRegistro();
                }
                else
                {
                    MensajeError("Select a Row First");
                }

            }
        }
    }
}

