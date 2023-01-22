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

namespace UI.ChildForms
{
    public partial class PatenteFamiliaForm : Form
    {
        private List<PatenteEntity> ListaPatentes;
        private List<FamiliaEntity> ListaFamilias;
        private FamiliaEntity seleccion;


        //private readonly IUsuariosController _usuarioController;
        private readonly IPermisosController _permisosController;
        
        public PatenteFamiliaForm(/*IUsuariosController usuarioController,*/ IPermisosController permisosController)
        {
            InitializeComponent();
            _permisosController = permisosController;
            CargarListasEnMemoria();
        }

        private void CargarListasEnMemoria()
        {
            ListaPatentes = _permisosController.GetAllPatentes().ToList();
            ListaFamilias = _permisosController.GetAllFamilias().ToList();
            
            cb_familia.DataSource = ListaFamilias;
            cb_familia.DisplayMember = "Nombre";
            cb_patentes.DataSource = ListaPatentes;
            cb_patentes.DisplayMember = "Nombre";

            cb_permisos.DataSource = Enum.GetValues(typeof(TipoPermiso));
        }

        private void btn_configurar_Click(object sender, EventArgs e)
        {
            var tmp = (FamiliaEntity)this.cb_familia.SelectedItem ?? ListaFamilias?.GetRange(cb_familia.SelectedIndex == -1 ? 0 : cb_familia.SelectedIndex, ListaFamilias.Count)?.FirstOrDefault() ?? throw new Exception("Ocurrió un error...");
            seleccion = tmp;
            MostrarFamilia();
        }
        private void MostrarFamilia(bool init = false)
        {
            this.treeView.Nodes.Clear();
            
            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            treeView.Nodes.Add(root);

            IList<ComponenteEntity> flia = seleccion.Hijos;

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeView.ExpandAll();
        }
        private void MostrarEnTreeView(TreeNode tn, ComponenteEntity c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            n.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos) //Si el Componente que ingresa es una familia recorremos una recursividad hasta que no tenga mas hijos 
                {
                    MostrarEnTreeView(n, item);
                }
        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip my_menu = new ContextMenuStrip();
            //select the node tag that was right clicked
            //check if it is a right click
            if (e.Button == MouseButtons.Right)
            {
                TreeNode current_node = treeView.GetNodeAt(e.X, e.Y);
                if (current_node != null)
                {
                    treeView.SelectedNode = current_node;
                    ComponenteEntity c = (ComponenteEntity)current_node.Tag;

                    my_menu.Items.Add("Eliminar").Name = "Eliminar";

                    my_menu.Show(treeView, new Point(e.X, e.Y));
                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
            }
                       
        }
        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Eliminar":
                    ComponenteEntity c = (ComponenteEntity)treeView.SelectedNode.Tag;
                    seleccion.QuitarHijo(c);
                    treeView.Nodes.Remove(treeView.SelectedNode);
                    break;
            }
        }

        private void btn_guardarConfig_Click(object sender, EventArgs e)
        {
            try
            {
                var test = seleccion ?? throw new Exception("No hay familia seleccionada");
                
                _permisosController.GuardarFamilia(seleccion);
                MostrarFamilia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_agregarPatente_Click(object sender, EventArgs e)
        {
            //add patente to treeview
            var tmp = (PatenteEntity)this.cb_patentes.SelectedItem ?? ListaPatentes?.GetRange(cb_patentes.SelectedIndex == -1 ? 0 : cb_patentes.SelectedIndex, ListaPatentes.Count)?.FirstOrDefault() ?? throw new Exception("Ocurrió un error...");
            seleccion.AgregarHijo(tmp);
            MostrarFamilia();
            
        }

        private void btn_crearPatente_Click(object sender, EventArgs e)
        {
            try
            {
                _permisosController.GuardarPatente(tb_Patente.Text, cb_permisos.SelectedItem.ToString());
                CargarListasEnMemoria();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
