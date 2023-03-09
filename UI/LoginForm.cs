using Contratos.Controllers;

using SL.BLL;
using SL.BLL.CompositeBLL;
using SL.Contratos.Controllers;
using SL.Domain.Entities;
using SL.Services.Extensions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Tools.LanguageManager;

namespace UI
{
    public partial class LoginForm : Form
    {
        private readonly IDetalleController _detalleController;
        private readonly IClienteController _clienteController;
        private readonly IPedidoController _pedidoController;
        private readonly IProductoController _productoController;
        private readonly IFacturaController _facturaController;
        private readonly IPermisosController _permisosController;
        private readonly IUsuariosController _usuariosController;
        private readonly ILoggerController _loggerController;
        private readonly IReporteController _reporteController;

        public LoginForm(
            IClienteController clienteController,
            IPedidoController pedidoController,
            IDetalleController detalleController,
            IProductoController productoController,
            IFacturaController facturaController,
            IPermisosController permisosController,
            IUsuariosController usuariosController,
            ILoggerController loggerController,
            IReporteController reporteController)
        {
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
            TranducirForm.Current.TraducirFormulario(this);

        }
        UsuarioEntity user = new UsuarioEntity();
        private void button1_Click(object sender, EventArgs e)
        {
            user.usuario = TB_Usuario.Text;
            user.pw = TB_Contraseña.Text;

            if (_usuariosController.Login(user))
            {
                user = _permisosController.GetUsuario(user.usuario);
                MainForm mainForm = new MainForm(_clienteController, _pedidoController, _detalleController, _productoController, _facturaController, _permisosController, _usuariosController, _loggerController, _reporteController, user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            //if (BLLLogin.Current.Verify(user) == true)
            //{
            //    var usuario = _permisosController.GetUsuario(user.nombre);
            //    MainForm mf = new MainForm(_clienteController, _pedidoController, _detalleController, _productoController, _facturaController, _permisosController, usuario);
            //    this.Hide();
            //    mf.Show();

            //    MessageBox.Show($"Bienvenido {user.nombre}.");
            //}
            //else
            //{
            //    MessageBox.Show("Error en el usuario o contraseña, verificar.");
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TB_Contraseña.PasswordChar = '\0';
            }
            else
            {
                TB_Contraseña.PasswordChar = '•';
            }
        }

    }
}
