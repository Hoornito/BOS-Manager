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

using UI.ChildForms;
using UI.Tools.FormComms;

namespace UI.GrandChildForms
{
    public partial class ClientesAddForm : Form
    {
        public ICommPedidoCliente commPedido { get; set; }
        private readonly IClienteController _clienteController;
        public ClientesAddForm(IClienteController clienteController, string cliente)
        {
            
            _clienteController = clienteController;
            InitializeComponent();
            txtTelefono.Text = cliente;
        }
        public ClientesAddForm()
        {
            InitializeComponent();
        }

        private void OnlyNumber(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity(EntityState.Added);
                //CargarDatos(cliente);

                cliente.Nombre = txtNombre.Text;
                cliente.DNI = txtDNI.Text;
                cliente.Dirección = txtDireccion.Text;
                cliente.MailContacto = txtmail.Text;
                cliente.Teléfono = txtTelefono.Text;

                _clienteController.GuardarCambios(cliente);
                commPedido.RefeshDir(cliente);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }
    }
}
