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
    public partial class FORMPRINCIPAL : Form
    {
        public FORMPRINCIPAL()
        {
            InitializeComponent();
        }

        private void MENUCLIENTE_Click(object sender, EventArgs e)
        {
            Form telaCLIENTE = new Form1CLIENTE();

            telaCLIENTE.Show();
        }
    }
}
