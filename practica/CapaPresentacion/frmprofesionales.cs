using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmprofesionales : Form
    {
        readonly E_Profesionales objEntidad = new E_Profesionales();
        readonly N_Profesionales objNegocio = new N_Profesionales();

        public frmprofesionales()
        {
            InitializeComponent();
            
        }
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Iver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       public void AccionesTabla()
        {
            dgvPorfessional.Columns[0].Visible = false;
            dgvPorfessional.Columns[7].Visible = false;

            dgvPorfessional.Columns[1].HeaderText = "Nª Cédula";
            dgvPorfessional.Columns[2].HeaderText = "Nombres";
            dgvPorfessional.Columns[3].HeaderText = "Apellidos";
            dgvPorfessional.Columns[4].HeaderText = "Dirección";
            dgvPorfessional.Columns[5].HeaderText = "Teléfono";
            dgvPorfessional.Columns[6].HeaderText = "Correo";
        }

        public void MostrarRegistro()
        {
            dgvPorfessional.DataSource = N_Profesionales.mostrarRegistros();
            AccionesTabla();
        }

        public void BuscarRegistros()
        {
            dgvPorfessional.DataSource = N_Profesionales.BuscarRegistros(txtBuscar.Text);
        }

        private void frmprofesionales_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }
        private void ActualizarDatos(object sender,FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        public void ExportarDatos(DataGridView dgbProfesionales)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);
            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in dgvPorfessional.Columns)
            {
                indicecolumna++;

                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 0;

            foreach (DataGridViewRow fila in dgvPorfessional.Rows)
            {
                indicefila++;

                indicecolumna = 0;
                foreach (DataGridViewColumn columna in dgvPorfessional.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmListadoProfesionales nuevoregistro = new frmListadoProfesionales();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmListadoProfesionales editarregistro = new frmListadoProfesionales();
            editarregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            if (dgvPorfessional.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                editarregistro.txtCodigo.Text = dgvPorfessional.CurrentRow.Cells[0].Value.ToString();
                editarregistro.txtCedula.Text = dgvPorfessional.CurrentRow.Cells[1].Value.ToString();
                editarregistro.txtNombre.Text = dgvPorfessional.CurrentRow.Cells[2].Value.ToString();
                editarregistro.txtApellidos.Text = dgvPorfessional.CurrentRow.Cells[3].Value.ToString();
                editarregistro.txtDireccion.Text = dgvPorfessional.CurrentRow.Cells[4].Value.ToString();
                editarregistro.txtTelefono.Text = dgvPorfessional.CurrentRow.Cells[5].Value.ToString();
                editarregistro.txtCorreo.Text = dgvPorfessional.CurrentRow.Cells[6].Value.ToString();
                editarregistro.cbCiudad.SelectedValue = dgvPorfessional.CurrentRow.Cells[7].Value.ToString();
                editarregistro.ShowDialog();
            }
            else
            {
                MensajeError("Seleccione la fila a Editar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (dgvPorfessional.SelectedRows.Count > 0)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("You Really Want to delete the Register", "Profesional", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        objEntidad.IdProfesionales = Convert.ToInt32(dgvPorfessional.CurrentRow.Cells[0].Value.ToString());
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvPorfessional);
        }
    }
}
