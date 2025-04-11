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
    public partial class Form1CLIENTE : Form
    {
        public Form1CLIENTE()
        {
            InitializeComponent();
        }

        private void menuENDERECO_Click(object sender, EventArgs e)
        {
            Form telaendereco = new FormENDERECO();
            telaendereco.MdiParent = this;
            telaendereco.Show();
        }
    }
}
