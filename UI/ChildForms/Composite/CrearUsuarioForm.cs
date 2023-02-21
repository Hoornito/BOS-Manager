using SL.Contratos.Controllers;
using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.ChildForms.Composite
{
    public partial class CrearUsuarioForm : Form
    {
        private readonly IUsuariosController _usuariosController;
        public CrearUsuarioForm(IUsuariosController usuariosController)
        {
            _usuariosController = usuariosController;
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            //create new usuario
            var usuario = new UsuarioEntity
            {
                usuario = txt_Usuario.Text,
                pw = txt_pw.Text,
                nombre = txt_Nombre.Text,
                apellido = txt_Apellido.Text,
                email = txt_Mail.Text,
                telefono = txt_Telefono.Text,
            };
            _usuariosController.CrearUsuario(usuario);
        }
    }
}
