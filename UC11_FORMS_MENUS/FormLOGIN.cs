using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_FORMS_MENUS
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telaprincipal = new FORMPRINCIPAL();
            telaprincipal.Closed += (s, args) => this.Close();
            telaprincipal.Show();

        }
    }
}
