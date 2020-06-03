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
    public partial class FrmUsuarios : Form
    {
        readonly E_Usuarios  objEntidad = new E_Usuarios();
        readonly N_Usuarios objNeogocio = new N_Usuarios();

        public FrmUsuarios()
        {
            InitializeComponent();
            LlenarCombobox();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            
        }
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Iver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LimpiarTexto()
        {
            txtCodigoU.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtCodigoU.Focus();
        }

        private void LlenarCombobox()
        {
            cbProfesional.DataSource = N_Profesionales.mostrarRegistros();
            cbProfesional.ValueMember = "idprofesionales";
            cbProfesional.DisplayMember = "nombres";
        }
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            LlenarCombobox();
        }

        private void btnNewU_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" | txtContraseña.Text.Trim()!="")
            {
                if (Program.Evento == 0)
                {
                    try
                    {
                        objEntidad.Usuarios = txtUsuario.Text.ToUpper();
                        objEntidad.Contrasena = txtContraseña.Text.Trim();
                        objEntidad.Acceso = cbAcceso.Text.ToUpper();
                        objEntidad.IdProfesionales = Convert.ToInt32(cbProfesional.SelectedValue);

                        objNeogocio.InsertarRegistro(objEntidad);
                        MensajeConfirmacion("Se inserto correctamente");
                        Program.Evento = 0;
                        LimpiarTexto();
                        Close();
                    }
                    catch (Exception)
                    {

                        MensajeError("NO SE PUDO INSERTAR EL REGISTRO");
                    }
                }
                else
                {
                    try
                    {
                        objEntidad.IdUsuarios = Convert.ToInt32(txtCodigoU.Text.ToUpper());
                        objEntidad.Usuarios = txtUsuario.Text.ToUpper();
                        objEntidad.Contrasena = txtContraseña.Text.Trim();
                        objEntidad.Acceso = cbAcceso.Text.ToUpper();
                        objEntidad.IdProfesionales = Convert.ToInt32(cbProfesional.SelectedValue);

                        objNeogocio.EditarRegistros(objEntidad);

                        MensajeConfirmacion("Se Modifico correctamente");
                        Program.Evento = 0;
                        LimpiarTexto();
                        Close();
                    }
                    catch (Exception)
                    {

                        MensajeError("NO SE PUDO Editar EL REGISTRO");
                    }
                }
            }
            else
            {
                MensajeError("LLENE LOS CAMPOS CORRESPONDIENTES PARA GUARDAR EL REGISTRO");
            }
        }

        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnprofesionales_Click(object sender, EventArgs e)
        {
            frmListadoProfesionales nuevoregistro = new frmListadoProfesionales();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog(); ;
        }
    }
}
