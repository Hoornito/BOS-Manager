using SL.Tools;

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
    public partial class HeatMapTester : Form
    {
        public HeatMapTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeatMap test = new HeatMap();

            test.GetLatLng("Los Platanos 2354, Buenos Aires, Argentina");


        }
    }
}
