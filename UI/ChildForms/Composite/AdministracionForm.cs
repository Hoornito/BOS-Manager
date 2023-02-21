using Contratos.Controllers;

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

using UI.Tools.LanguageManager;

namespace UI.ChildForms.Composite
{
    public partial class AdministracionForm : Form
    {
        private readonly IPermisosController _permisosController;
        private readonly IUsuariosController _usuariosController;
        private Form currentChildForm;
        public AdministracionForm(IPermisosController permisosController, IUsuariosController usuariosController)
        {
            _permisosController = permisosController;
            _usuariosController = usuariosController;
            
            InitializeComponent();
            TranducirForm.Current.TraducirFormulario(this);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatenteFamiliaForm(_permisosController));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsuarioForm(_permisosController));
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
            panelAdmin.Controls.Add(childForm);
            panelAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CrearUsuarioForm(_usuariosController));
        }
    }
}
