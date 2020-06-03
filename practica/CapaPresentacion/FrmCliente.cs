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
    public partial class FrmCliente : Form
    {
        readonly E_Clientes objEntidad = new E_Clientes();
        readonly N_Clientes objNeogocio = new N_Clientes();
        public FrmCliente()
        {
            InitializeComponent();
            LlenarCombobox();
        }

        #region MENSAJE DE VIENVENIDA Y ERROR
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Iver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Welcome Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region METODO LIMPIAR TEXTO
        private void LimpiarTexto()
        {
            txtCodigoC.Text = "";
            txtCioRUCC.Text = "";
            txtRazonSocialC.Text = "";
            txtDireccionC.Text = "";
            txtTelefonoC.Text = "";
            txtCorreoC.Text = "";
        }
        #endregion

        #region LLENAR COMBOBOX CIUDAD
        private void LlenarCombobox()
        {
            cbCiudadC.DataSource = N_Ciudades.mostrarRegistros();
            cbCiudadC.ValueMember = "idciudades";
            cbCiudadC.DisplayMember = "descripcion";

            cbProfesionC.DataSource = N_Profesionales.mostrarRegistros();
            cbProfesionC.ValueMember = "idprofesionales";
            cbProfesionC.DisplayMember = "nombres";
        }
        #endregion
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            LlenarCombobox();
        }


        #region GUARDAR NUEVO CLIENTE

        private void btnNewC_Click(object sender, EventArgs e)
        {
            if (txtCioRUCC.Text.Trim() != "" | txtRazonSocialC.Text.Trim()!="")
            {
                if (Program.Evento == 0)
                {
                    try
                    {
                        objEntidad.CIORUC = txtCioRUCC.Text.ToUpper();
                        objEntidad.Razonsocial = txtRazonSocialC.Text.ToUpper();
                        objEntidad.Direccion = txtDireccionC.Text.ToUpper();
                        objEntidad.Telefono = txtTelefonoC.Text.ToUpper();
                        objEntidad.Correo = txtCorreoC.Text.ToUpper();
                        objEntidad.IdCiudades = Convert.ToInt32(cbCiudadC.SelectedValue);
                        objEntidad.IdProfesionales = Convert.ToInt32(cbProfesionC.SelectedValue);

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
                        objEntidad.IdClientes = Convert.ToInt32(txtCodigoC.Text.ToUpper());
                        objEntidad.CIORUC = txtCioRUCC.Text.ToUpper();
                        objEntidad.Razonsocial = txtRazonSocialC.Text.ToUpper();
                        objEntidad.Direccion = txtDireccionC.Text.ToUpper();
                        objEntidad.Telefono = txtTelefonoC.Text.ToUpper();
                        objEntidad.Correo = txtCorreoC.Text.ToUpper();
                        objEntidad.IdCiudades = Convert.ToInt32(cbCiudadC.SelectedValue);
                        objEntidad.IdProfesionales = Convert.ToInt32(cbProfesionC.SelectedValue);

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
        #endregion

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            FrmCiudades nuevoregistro = new FrmCiudades();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();
        }

        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            frmListadoProfesionales nuevoregistro = new frmListadoProfesionales();
            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();
        }
    }
}
