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

using UI.Controllers;

namespace UI.ChildForms.Composite
{
    public partial class UsuarioForm : Form
    {
        private readonly IPermisosController _permisosController;
        UsuarioEntity seleccion;
        UsuarioEntity usr;
        public UsuarioForm(IPermisosController permisosController)
        {
            InitializeComponent();
            _permisosController = permisosController;
        }

        private void CargarForm()
        {
            this.cb_Familia.DataSource = _permisosController.GetAllFamilias();
            this.cb_Familia.DisplayMember = "Nombre";
            this.cb_Permisos.DataSource = _permisosController.GetAllPatentes();
            this.cb_Permisos.DisplayMember = "Nombre";
            this.cb_Usuario.DataSource = _permisosController.GetAllUsuariosCompletos();
            this.cb_Usuario.DisplayMember = "Nombre";
        }
        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            CargarForm();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                _permisosController.GuardarPermisos(usr);
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                MessageBox.Show("Guardado");
                CargarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_ConfigurarUsuario_Click(object sender, EventArgs e)
        {
            seleccion = (UsuarioEntity)this.cb_Usuario.SelectedItem;
            usr = new UsuarioEntity();
            usr.Id = seleccion.Id;
            usr.nombre = seleccion.nombre;
            usr.Permisos.AddRange(seleccion.Permisos);

            MostrarPermisos(usr);
        }

        private void MostrarPermisos(UsuarioEntity u)
        {
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(u.nombre);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll();
        }
        
        private void LlenarTreeView(TreeNode padre, ComponenteEntity c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }
        }

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (usr != null)
                {
                    var patente = (PatenteEntity)cb_Permisos.SelectedItem;
                    if (patente != null)
                    {
                        if (usr.Permisos.Exists(e => e.Permiso == patente.Permiso))
                        {
                            MessageBox.Show("El usuario ya tiene ese permiso");
                        }
                        else
                            usr.Permisos.Add(patente);
                    }
                    MostrarPermisos(usr);
                }
                else
                {
                    MessageBox.Show("Seleccionar usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btn_AgregarFamilia_Click(object sender, EventArgs e)
        {
            if (usr != null)
            {
                var familia = (FamiliaEntity)cb_Familia.SelectedItem;
                if (familia != null)
                {
                    usr.Permisos.Add(familia);
                }
                MostrarPermisos(usr);
            }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            //Validar si un nodo fue seleccionado
            if (this.treeView1.SelectedNode != null)
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int position_xy_mouse_row = (int)treeView1.HitTest(e.X, e.Y).Location;
                //Seleccionar el nodo segun la ubicacion
                this.treeView1.SelectedNode = this.treeView1.GetNodeAt(e.X, e.Y);
                if (e.Button == MouseButtons.Right)
                {
                    if (position_xy_mouse_row >= 0)
                    {
                        my_menu.Items.Add("Quitar Permiso").Name = "Eliminar";
                    }
                    my_menu.Show(treeView1, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
            }
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name.ToString())
                {
                    case "Eliminar":
                        //Get object selected from node
                        var nodo = treeView1.SelectedNode;
                        var componente = (ComponenteEntity)nodo.Tag;
                        if (nodo.Parent.Tag is FamiliaEntity && componente is not FamiliaEntity)
                        {
                            MessageBox.Show("Error, no se puede realizar esa acción.");
                        }
                        else
                        {
                            usr.Permisos.Remove(componente);
                            treeView1.Nodes.Remove(nodo);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
