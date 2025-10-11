using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_bloq_copia_e_cola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox.ShortcutsEnabled = false;
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control == (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                txtBox.ShortcutsEnabled = false;
            }
        }
    }
}
