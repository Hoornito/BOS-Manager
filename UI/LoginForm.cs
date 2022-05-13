using Contratos.Controllers;

using SL.BLL;
using SL.BLL.CompositeBLL;
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

        public LoginForm(IClienteController clienteController, IPedidoController pedidoController, IDetalleController detalleController, IProductoController productoController, IFacturaController facturaController)
        {
            _detalleController = detalleController;
            _clienteController = clienteController;
            _pedidoController = pedidoController;
            _productoController = productoController;
            _facturaController = facturaController;
            InitializeComponent();
            TranducirForm.Current.TraducirFormulario(this);
        }
        UsuarioEntity user = new UsuarioEntity();
        private void button1_Click(object sender, EventArgs e)
        {
            user.nombre = TB_Usuario.Text;
            user.pw = TB_Contraseña.Text;

            if (BLLLogin.Current.Verify(user) == true)
            {
                MainForm test = new MainForm(_clienteController, _pedidoController, _detalleController, _productoController, _facturaController);
                this.Hide();
                test.Show();

                MessageBox.Show($"Bienvenido {user.nombre}.");
            }
            else
            {
                MessageBox.Show("Error en el usuario o contraseña, verificar.");
            }
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
