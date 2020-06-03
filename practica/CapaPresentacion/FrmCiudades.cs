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
    public partial class FrmCiudades : Form
    {
        private bool Editar = false;
        readonly E_Ciudades objEntidad = new E_Ciudades();
        readonly N_Ciudades objNeogocio = new N_Ciudades();
        public FrmCiudades()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Iver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarRegistros()
        {
            dgvList.DataSource = N_Ciudades.mostrarRegistros();
        }

        public void LimpiarDatos()
        {
            Editar = false;
            txtCode.Text = "";
            txtDescription.Text = "";
            txtDescription.Focus();
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count>0)
            {
                Editar = true;
                txtCode.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
                txtDescription.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MensajeError("Selec a  Row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count>0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("You Really Want to delete the Register", "Ciy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion==DialogResult.OK)
                {
                    objEntidad.IdCiudades = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value.ToString());
                    objNeogocio.EliminarRegistro(objEntidad);

                    MessageBox.Show("Successfully removed");

                    MostrarRegistros();
                }
                else
                {
                    MensajeError("Select a Row First");
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Editar==false)
            {
                try
                {
                    objEntidad.Descripcion = txtDescription.Text.ToUpper();

                    objNeogocio.InsertarRegistro(objEntidad);

                    MessageBox.Show("Inserted Correctly");
                    MostrarRegistros();
                    LimpiarDatos();
                }
                catch (Exception)
                {

                    MensajeError("Could not Insert Register");
                }

            }
            if (Editar == true)
            {
                try
                {
                    objEntidad.IdCiudades = Convert.ToInt32(txtCode.Text);
                    objEntidad.Descripcion = txtDescription.Text.ToUpper();

                    objNeogocio.EditarRegistros(objEntidad);

                    MessageBox.Show("The Register Was Successfully Edited");
                    MostrarRegistros();
                    LimpiarDatos();
                }
                catch (Exception)
                {

                    MensajeError("Could not Edited Register");
                }

            }

        }
    }
}
