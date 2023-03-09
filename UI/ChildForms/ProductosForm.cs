using Contratos.Controllers;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using UI.Tools.LanguageManager;

namespace UI.ChildForms
{
    public partial class ProductosForm : Form
    {
        private readonly IProductoController _productoController;
        public ProductosForm(IProductoController productoController)
        {
            _productoController = productoController;

            InitializeComponent();
            LlenarGrilla();
            TranducirForm.Current.TraducirFormulario(this);
        }

        #region Metodos

        private bool AlreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void LlenarGrilla()
        {
            dataGridView1.AutoGenerateColumns = true;

            //UTILIZANDO LINQ
            var listaDetalle = _productoController.GetAll().Select
                (x => new
                {
                    Nombre = x.Nombre,
                    Precio = x.PrecioUnidad,
                    Cantidad = x.Cantidad,
                    Tipo = x.Tipo,
                    Descripción = x.Descripción,
                    Estado = x.Active
                });
            //dataGridView1.Columns[1].HeaderText = "Precio por Unidad";
            dataGridView1.DataSource = listaDetalle.ToList();
        }

        private ProductoEntity LlenarDatos(ProductoEntity producto)
        {
            producto.Nombre = txtNombre.Text;
            producto.PrecioUnidad = Convert.ToDecimal(txtPrecio.Text);
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            producto.Descripción = txtDescripción.Text;
            producto.Tipo = cboTipo.Text;
            return producto;
        }
        #endregion

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity(EntityState.Added);

                LlenarDatos(producto);
                //producto.Nombre = txtNombre.Text;
                //producto.PrecioUnidad = Convert.ToDouble(txtPrecio.Text);
                //producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                //producto.Descripción = txtDescripción.Text;

                _productoController.GuardarCambios(producto);

                LlenarGrilla();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el producto, contactesé con un administrador.");
            }
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity(EntityState.Deleted);

                LlenarDatos(producto);
                //producto.Nombre = txtNombre.Text;
                //producto.PrecioUnidad = Convert.ToDouble(txtPrecio.Text);
                //producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                //producto.Descripción = txtDescripción.Text;

                _productoController.GuardarCambios(producto);

                LlenarGrilla();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar el producto, contactesé con un administrador.");
            }
        }

        private void ActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity(EntityState.Modified);

                LlenarDatos(producto);
                //producto.Nombre = txtNombre.Text;
                //producto.PrecioUnidad = Convert.ToDouble(txtPrecio.Text);
                //producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                //producto.Descripción = txtDescripción.Text;

                _productoController.GuardarCambios(producto);

                LlenarGrilla();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar el producto, contactesé con un administrador.");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductoEntity producto = new ProductoEntity();
            producto.Nombre = (string)dataGridView1.SelectedCells[0].Value;
            producto = _productoController.GetProducto(producto.Nombre);
            txtNombre.Text = producto.Nombre;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.PrecioUnidad.ToString();
            txtDescripción.Text = producto.Descripción;

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != ',')
            {
                e.Handled = true;
            }

            char separatorChar = 's';

            if (ch == ',')
            {
                if (txtPrecio.Text.Length == 0) e.Handled = true;
                if (txtPrecio.SelectionStart == 0) e.Handled = true;
                if (AlreadyExist(txtPrecio.Text, ref separatorChar)) e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != ',')
            {
                e.Handled = true;
            }

            char separatorChar = 's';

            if (ch == ',')
            {
                if (txtPrecio.Text.Length == 0) e.Handled = true;
                if (txtPrecio.SelectionStart == 0) e.Handled = true;
                if (AlreadyExist(txtPrecio.Text, ref separatorChar)) e.Handled = true;
            }
        }
    }
}
