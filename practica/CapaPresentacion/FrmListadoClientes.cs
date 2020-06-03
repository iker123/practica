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
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmListadoClientes : Form
    {
        readonly E_Clientes objEntidad = new E_Clientes();
        readonly N_Clientes objNegocio = new N_Clientes();
        public FrmListadoClientes()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
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
            dgvClient.Columns[0].Visible = false;
            dgvClient.Columns[6].Visible = false;
            dgvClient.Columns[7].Visible = false;

            //MOSTRAR LOS NOMBRES DE LAS COLUMNAS EN EL dgv 
            dgvClient.Columns[1].HeaderText = "Nº CI o RUC";
            dgvClient.Columns[2].HeaderText = "Razón Social";
            dgvClient.Columns[3].HeaderText = "Dirección";
            dgvClient.Columns[4].HeaderText = "Teléfono";
            dgvClient.Columns[5].HeaderText = "Correo";
        }
        #endregion

        #region MOSTRAR REGISTRO EN EL dgv
        public void MostrarRegistro()
        {
            dgvClient.DataSource = N_Clientes.MostrarRegistrosC();
            AccionesTabla();
        }
        #endregion

        #region BUSCAR REGISTROS
        public void BuscarRegistros()
        {
            dgvClient.DataSource = N_Clientes.BuscarRegistrosC(txtBuscarCliente.Text);
        }
        #endregion
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        #region EXPORTAR DATOS A EXCEL
        public void ExportarDatos(DataGridView dgbProfesionales)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);
            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in dgvClient.Columns)
            {
                indicecolumna++;

                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 0;

            foreach (DataGridViewRow fila in dgvClient.Rows)
            {
                indicefila++;

                indicecolumna = 0;
                foreach (DataGridViewColumn columna in dgvClient.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }
        #endregion

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        #region NUEVO CLIENTE
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            FrmCliente nuevoregistro = new FrmCliente();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();
        }
        #endregion

        #region EDITAR CLIENTE
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmCliente editarregistro = new FrmCliente();
            editarregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            if (dgvClient.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                editarregistro.txtCodigoC.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
                editarregistro.txtCioRUCC.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
                editarregistro.txtRazonSocialC.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
                editarregistro.txtDireccionC.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
                editarregistro.txtTelefonoC.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
                editarregistro.txtCorreoC.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
                editarregistro.cbProfesionC.Text = dgvClient.CurrentRow.Cells[6].Value.ToString();
                editarregistro.cbCiudadC.SelectedValue = dgvClient.CurrentRow.Cells[7].Value.ToString();
                editarregistro.ShowDialog();
            }
            else
            {
                MensajeError("Seleccione la fila a Editar");
            }
        }

        #endregion

        private void btnExExcel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvClient);
        }

        #region ELIMINAR CLIENTE
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvClient.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("You Really Want to delete the Register", "Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    objEntidad.IdClientes = Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value.ToString());
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

        #endregion

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistros();
        }
    }
}

