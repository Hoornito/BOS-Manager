using Contratos.Controllers;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.GrandChildForms
{
    public partial class ProductoAddForm : Form
    {
        private readonly IProductoController _productoController;
        private string tipoProd;
        public ProductoAddForm(IProductoController productoController, string nombre, string tipo)
        {
            
            _productoController = productoController;
            InitializeComponent();
            txtNombre.Text = nombre;
            tipoProd = tipo;
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity(EntityState.Modified);
                producto.Nombre = txtNombre.Text;
                var productohelper = _productoController.GetProducto(producto.Nombre);
                producto.PrecioUnidad = productohelper.PrecioUnidad;
                producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                producto.Tipo = tipoProd;
                _productoController.GuardarCambios(producto);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add100_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity(EntityState.Modified);

                producto.Nombre = txtNombre.Text;
                producto.Cantidad = 100;
                producto.Tipo = tipoProd;
                _productoController.GuardarCambios(producto);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add200_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntity producto = new ProductoEntity(EntityState.Modified);

                producto.Nombre = txtNombre.Text;
                producto.Cantidad = 200;
                producto.Tipo = tipoProd;

                _productoController.GuardarCambios(producto);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
