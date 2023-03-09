using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using Newtonsoft.Json.Linq;

using SL.Contratos.Controllers;
using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Tools.LanguageManager;

namespace UI.ChildForms
{
    public partial class ConfiguracionUsuarioForm : Form
    {
        private readonly IUsuariosController _usuariosController;
        private readonly UsuarioEntity _usr;
        public ConfiguracionUsuarioForm(IUsuariosController usuariosController, UsuarioEntity usr)
        {
            _usuariosController = usuariosController;
            _usr = usr;

            InitializeComponent();
            TranducirForm.Current.TraducirFormulario(this);
            //comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "appsettings.json";
            string jsonString = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonString);
            JObject sectionToModify = (JObject)jsonObject["AppSettings"];
            string idioma = "";
            if (comboBox1.SelectedItem.ToString() == "Español")
            {
                idioma = "es-ES";
                //update usuario using usuariosservice with new idioma selected

                _usuariosController.CambiarIdiomaUsuario(idioma, _usr.usuario);
            }
            else if (comboBox1.SelectedItem.ToString() == "Ingles")
            {
                idioma = "en-US";
                _usuariosController.CambiarIdiomaUsuario(idioma, _usr.usuario);
            }
            sectionToModify["Culture"] = idioma;
            File.WriteAllText(filePath, jsonObject.ToString());
            TranducirForm.Current.SeleccionarIdioma(idioma);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "" || comboBox1.SelectedItem.ToString() == null || comboBox1.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un idioma. \n Please select a language.");
            }
            else if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void ConfiguracionUsuarioForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
