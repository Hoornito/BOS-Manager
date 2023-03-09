using Contratos.Controllers;

using FontAwesome.Sharp;

using SL.Contratos.Controllers;
using SL.Domain.Entities;

using System;
using System.Drawing;
using System.Windows.Forms;

using UI.ChildForms;
using UI.ChildForms.Composite;
using UI.Controllers;
using UI.Tools.LanguageManager;

namespace UI
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private UsuarioEntity _user;

        private readonly IDetalleController _detalleController;
        private readonly IClienteController _clienteController;
        private readonly IPedidoController _pedidoController;
        private readonly IProductoController _productoController;
        private readonly IFacturaController _facturaController;
        private readonly IPermisosController _permisosController;
        private readonly IUsuariosController _usuariosController;
        private readonly ILoggerController _loggerController;
        private readonly IReporteController _reporteController;
        public MainForm(
            IClienteController clienteController,
            IPedidoController pedidoController,
            IDetalleController detalleController,
            IProductoController productoController,
            IFacturaController facturaController,
            IPermisosController permisosController,
            IUsuariosController usuariosController,
            ILoggerController loggerController,
            IReporteController reporteController,
            UsuarioEntity user)
        {
            _user = user;
            _detalleController = detalleController;
            _clienteController = clienteController;
            _pedidoController = pedidoController;
            _productoController = productoController;
            _facturaController = facturaController;
            _permisosController = permisosController;
            _usuariosController = usuariosController;
            _loggerController = loggerController;
            _reporteController = reporteController;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            TranducirForm.Current.TraducirFormulario(this);
        }

        #region Metodos Front
        //Metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Home";
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        #endregion

        #region estructuras
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(139, 43, 147);
            public static Color color8 = Color.FromArgb(74, 19, 13);
        }
        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null)
            {

            }
            else
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ProductosForm(_productoController));
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FacturacionForm(_detalleController, _pedidoController, _facturaController));
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new PedidosForm(_pedidoController, _detalleController, _productoController, _clienteController));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new ReportesForm(_reporteController));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new ClientesForm(_clienteController));
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new AdministracionForm(_permisosController, _usuariosController, _loggerController));
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new VisualizarPedidosForm(_pedidoController, _detalleController));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnAdministracion.Visible = false;
            btnReportes.Visible = false;
            btnClientes.Visible = false;
            btnPedidos.Visible = false;
            btnFacturacion.Visible = false;
            btnStock.Visible = false;
            btnVisualizar.Visible = false;

            foreach (var permiso in _user.Permisos)
            {
                //if permiso contains hijos, then read permisos in hijos
                if (permiso.Hijos.Count > 0)
                {
                    foreach (var hijo in permiso.Hijos)
                    {
                        HabilitarBotones(hijo);
                    }
                }
                HabilitarBotones(permiso);
            }

        }
        private void HabilitarBotones(ComponenteEntity permiso)
        {
            if (permiso.Permiso == TipoPermiso.Administrador)
            {
                btnAdministracion.Visible = true;
                btnReportes.Visible = true;
                btnClientes.Visible = true;
                btnPedidos.Visible = true;
                btnFacturacion.Visible = true;
                btnStock.Visible = true;
                btnVisualizar.Visible = true;
            }
            else if (permiso.Permiso == TipoPermiso.Cocina)
            {
                btnVisualizar.Visible = true;
            }
            else if (permiso.Permiso == TipoPermiso.Caja)
            {
                btnPedidos.Visible = true;
                btnFacturacion.Visible = true;
                btnVisualizar.Visible = true;
            }
            else if (permiso.Permiso == TipoPermiso.Stock)
            {
                btnStock.Visible = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
            //LoginForm loginForm = new LoginForm(_clienteController, _pedidoController, _detalleController, _productoController, _facturaController, _permisosController, _usuariosController, _loggerController, _reporteController);
            //loginForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new ConfiguracionUsuarioForm(_usuariosController, _user));
        }
    }
}
