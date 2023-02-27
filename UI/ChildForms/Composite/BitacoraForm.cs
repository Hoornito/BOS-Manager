using Contratos.Controllers;

using SL.Contratos.Controllers;
using SL.Services;

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
using UI.Tools.LanguageManager;

namespace UI.ChildForms.Composite
{
    public partial class BitacoraForm : Form
    {
        private readonly ILoggerController _loggerController;
        public BitacoraForm(ILoggerController loggerController)
        {
            _loggerController = loggerController;
            InitializeComponent();

            //TranducirForm.Current.TraducirFormulario(this);
            LlenarGrilla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LogView.DataSource = _loggerController.LogFilter(dateTimePicker1.Value, cb_severidad.Text).Select((x => new
            {
                Fecha = x.Timestamp,
                Severidad = x.Severity,
                Mensaje = x.Message
            })).ToList();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LogView.DataSource = _loggerController.LogFilter(dateTimePicker1.Value, cb_severidad.Text).Select((x => new
            {
                Fecha = x.Timestamp,
                Severidad = x.Severity,
                Mensaje = x.Message
            })).ToList();
        }

        private void LlenarGrilla()
        {
            var listaLogs = _loggerController.GetLog().Select
                (x => new
                {
                    Fecha = x.Timestamp,
                    Severidad = x.Severity,
                    Mensaje = x.Message
                });
            LogView.DataSource = listaLogs.ToList();
        }
    }
}
