using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        //VARIABLES PARA REDIMENSIONAR EL FORMULARIO
        private const int tamañogrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        #region METODO PARA AMPLIAR FORMULARIO

        // METODOS DE TIPO OVERRIDE PARA AMPLIAR O MODIFICAR EL FORMULARIO
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e); // ESQUINA ENFIRIOR DERECHO PARA REDIRECCIONAR

            //DIBUJAR UN RECTANGULO

            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            //INICIAMOS UNA INSTANCIA CON LA UBICACION Y EL TAMAÑO ESPECIFICADOS PARA EL RECTANGULO
            rectangulogrid = new Rectangle(ClientRectangle.Width - tamañogrid, ClientRectangle.Height - tamañogrid, tamañogrid, tamañogrid);

            region.Exclude(rectangulogrid);

            panelPrincipal.Region = region;

            Invalidate();
        }
        #endregion

        #region METODO WndProc
        protected override void WndProc(ref Message sms)
        {
            //instruccion de seleccion
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);

                    //INSTACIAMOS UNA NUEVA INSTANCIA (POINT) CON LAS COORDENADAS ESPESIFICADAS (POSICION HORIZONTAL Y VERTICAL)
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));

                    if (!rectangulogrid.Contains(RefPoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }
        #endregion

        #region METODO PARA DAR ESTILO AL RECTANGULO

        //METODO PARA DAR ESTILO AL RECTANGULO
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 61, 69));

            e.Graphics.FillRectangle(solidBrush, rectangulogrid);

            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);
        }
        #endregion

        //VARIABLES QUE GUARDAN EL TAMOÑO DE NUESTRO FORMULARIO Y LAS COORDENADAS

        int lx, ly;
        int sw, sh;

        #region BOTON CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás Seguro de Cerrar el Programa?","Alerta", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region BOTON MINIMIZAR
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        #endregion

        #region BOTON RESTAURAR
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }
        #endregion

        #region BOTON MINIMIZAR
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region LLAMAR A FORMULARIO PROFESIONALES clikbtnProfesionales
        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            AbriFormularios <frmprofesionales>();
        }
        #endregion

        #region LLAMAR A FORMULARIO CLIENTES clikbtnCiudades
        private void btnCiudades_Click(object sender, EventArgs e)
        {
            AbriFormularios<FrmCiudades>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbriFormularios<FrmListadoUsuarios>();
        }
        #endregion

        #region LLAMAR A FORMULARIO CLIENTES clikbtnCliente
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbriFormularios<FrmListadoClientes>();
        }
        #endregion

        #region METODO  PARA ABRIR FORMULARIO DENTRO DE PANANELCONTENEDOR
        private void AbriFormularios <FormularioAbrir> () where FormularioAbrir:Form,new()
        {
            Form Formularios;

            Formularios = panelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                panelContenedor.Controls.Add(Formularios);
                panelContenedor.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();

            }
            else
            {
                Formularios.BringToFront();
            }
        }
        #endregion

    }
}
