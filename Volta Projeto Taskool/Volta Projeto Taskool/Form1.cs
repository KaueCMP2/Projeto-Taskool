using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volta_Projeto_Taskool
{
    public partial class FormMenu : Form
    {
        int hora = DateTime.Now.Hour;

        public FormMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Visible = true;
            lblRelogio.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btIngles_Click(object sender, EventArgs e)
        {
            var trocarIdioma = MessageBox.Show("Tem certeza que quer trocar o idioma", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SystemSounds.Beep.Play();

            if (trocarIdioma == DialogResult.Yes)
            {
                if (hora > 4 && hora < 12)
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Good Morning, nome");
                }

                else if (hora > 12 && hora < 18)
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Good Afternoon, nome");
                }

                else if (hora > 18 && hora < 23)
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Good Evening, nome");
                }

                else
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Good Sun-Up nome");
                }

                lblMensagem.Text = "To be trapped, just idealize freedom.";
                lblAutor.Text = "Made by me, for me";
            }
        }

        private void btPurtugues_Click(object sender, EventArgs e)
        {
            var trocarIdioma = MessageBox.Show("Tem certeza que quer trocar o idioma", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SystemSounds.Beep.Play();

            if (trocarIdioma == DialogResult.Yes)
            {
                if (hora > 4 && hora < 12)
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Bom dia, nome");
                }

                else if (hora > 12 && hora < 18)
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Boa tarde, nome");
                }

                else if (hora > 18 && hora < 23)
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Boa noite, nome");
                }

                else
                {
                    lblCumprimento.Visible = true;
                    lblCumprimento.Text = ($"Boa madrugadad, nome");
                }

                lblMensagem.Text = "Para estar preso, basta idealizar a liberdade.";
                lblAutor.Text = "Por eu, para eu";
            }
            lblMensagem.Text = "To be trapped, just idealize freedom.";
            lblAutor.Text = "Made by me, for me";
        }
    }
}
