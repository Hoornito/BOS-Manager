using Domain.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using UI.Tools.LanguageManager;

namespace UI.ChildForms
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            TranducirForm.Current.TraducirFormulario(this);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //generate a report with data from pedidoEntity using the report viewer

        }


    }
}
