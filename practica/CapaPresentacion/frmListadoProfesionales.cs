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
    public partial class frmListadoProfesionales : Form
    {
        readonly E_Profesionales  objEntidad = new E_Profesionales();
        readonly N_Profesionales objNeogocio = new N_Profesionales();
        public frmListadoProfesionales()
        {
            InitializeComponent();
            LlenarCombobox();
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
            txtCodigo.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCodigo.Focus();
        }

        private void LlenarCombobox()
        {
            cbCiudad.DataSource = N_Ciudades.mostrarRegistros();
            cbCiudad.ValueMember = "idciudades";
            cbCiudad.DisplayMember = "descripcion";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Trim()!="")
            {
                if (Program.Evento==0)
                {
                    try
                    {
                        objEntidad.CiProfesionales = txtCedula.Text.ToUpper();
                        objEntidad.Nombres = txtNombre.Text.ToUpper();
                        objEntidad.Apellidos = txtApellidos.Text.ToUpper();
                        objEntidad.Direccion = txtDireccion.Text.ToUpper();
                        objEntidad.Telefono = txtTelefono.Text.ToUpper();
                        objEntidad.Correo = txtCorreo.Text.ToUpper();
                        objEntidad.IdCiudades = Convert.ToInt32(cbCiudad.SelectedValue);

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
                        objEntidad.IdProfesionales = Convert.ToInt32(txtCodigo.Text.ToUpper());
                        objEntidad.CiProfesionales = txtCedula.Text.ToUpper();
                        objEntidad.Nombres = txtNombre.Text.ToUpper();
                        objEntidad.Apellidos = txtApellidos.Text.ToUpper();
                        objEntidad.Direccion = txtDireccion.Text.ToUpper();
                        objEntidad.Telefono = txtTelefono.Text.ToUpper();
                        objEntidad.Correo = txtCorreo.Text.ToUpper();
                        objEntidad.IdCiudades = Convert.ToInt32(cbCiudad.SelectedValue);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListadoProfesionales_Load(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            LlenarCombobox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmListadoProfesionales nuevoregistro = new frmListadoProfesionales();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();

        }
    }
}
